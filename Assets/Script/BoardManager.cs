using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject[] boardSpaces;
    public GameObject set; // 부모 게임 오브젝트를 지정하는 변수
    public int currentPlayerPosition; // 현재 플레이어 위치

    void Start()
    {
        // 'set' 게임 오브젝트의 자식들을 boardSpaces 배열에 할당
        boardSpaces = new GameObject[set.transform.childCount];
        for (int i = 0; i < set.transform.childCount; i++)
        {
            boardSpaces[i] = set.transform.GetChild(i).gameObject;
        }

        // 배열의 각 요소에 접근하는 예시 코드
        for (int i = 0; i < boardSpaces.Length; i++)
        {
            Debug.Log("Board Space " + i + " Position: " + boardSpaces[i].transform.position);
        }
    }

    // 필요한 추가 기능을 여기에 구현

    public void NotifyPlayerPosition(GameObject playerPosition)
    {
        // 플레이어 위치 업데이트
        currentPlayerPosition = System.Array.IndexOf(boardSpaces, playerPosition);
        Debug.Log("Player is at position: " + currentPlayerPosition);
    }

}
