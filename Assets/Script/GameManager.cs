using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BoardManager boardManager; // ���� �Ŵ��� ����
    public GameObject player; // �÷��̾� ���� ������Ʈ
    public float moveSpeed = 4.0f; // �̵� �ӵ�
    public int diceResult; // �ֻ��� ���
    private int currentSpaceIndex = 0; // ���� ���� ĭ �ε���
    private CharacterController characterController;

    void Start()
    {
        boardManager = FindObjectOfType<BoardManager>(); // ���� �Ŵ��� ã��
        characterController = player.GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }
    

    private void MovePlayer()
    {
        if (diceResult > 0 && boardManager != null)
        {
            Vector3 targetPosition = boardManager.boardSpaces[currentSpaceIndex].transform.position;
            targetPosition.y = player.transform.position.y;

            if (player.transform.position != targetPosition)
            {
                player.transform.position = Vector3.MoveTowards(player.transform.position, targetPosition, moveSpeed * Time.deltaTime);
                characterController.running(); //�� �ȵǴ��� �𸣰���
            }
            else
            {
                characterController.stopping(); //�� �ȵǴ��� �𸣰���
                currentSpaceIndex = (currentSpaceIndex + 1) % boardManager.boardSpaces.Length;
                diceResult--;
            }
        }
    }

    public void SetDiceResult(int result)
    {
        diceResult = result;
    }
}
