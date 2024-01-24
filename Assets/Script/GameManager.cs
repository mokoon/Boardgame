using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BoardManager boardManager; // 보드 매니저 참조
    public GameObject player; // 플레이어 게임 오브젝트
    public float moveSpeed = 4.0f; // 이동 속도
    public int diceResult; // 주사위 결과
    private int currentSpaceIndex = 0; // 현재 보드 칸 인덱스
    private CharacterController characterController;

    void Start()
    {
        boardManager = FindObjectOfType<BoardManager>(); // 보드 매니저 찾기
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
                characterController.running(); //왜 안되는지 모르겟음
            }
            else
            {
                characterController.stopping(); //왜 안되는지 모르겟음
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
