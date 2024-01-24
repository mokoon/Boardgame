using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject[] boardSpaces;
    public GameObject set; // �θ� ���� ������Ʈ�� �����ϴ� ����
    public int currentPlayerPosition; // ���� �÷��̾� ��ġ

    void Start()
    {
        // 'set' ���� ������Ʈ�� �ڽĵ��� boardSpaces �迭�� �Ҵ�
        boardSpaces = new GameObject[set.transform.childCount];
        for (int i = 0; i < set.transform.childCount; i++)
        {
            boardSpaces[i] = set.transform.GetChild(i).gameObject;
        }

        // �迭�� �� ��ҿ� �����ϴ� ���� �ڵ�
        for (int i = 0; i < boardSpaces.Length; i++)
        {
            Debug.Log("Board Space " + i + " Position: " + boardSpaces[i].transform.position);
        }
    }

    // �ʿ��� �߰� ����� ���⿡ ����

    public void NotifyPlayerPosition(GameObject playerPosition)
    {
        // �÷��̾� ��ġ ������Ʈ
        currentPlayerPosition = System.Array.IndexOf(boardSpaces, playerPosition);
        Debug.Log("Player is at position: " + currentPlayerPosition);
    }

}
