using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTrigger : MonoBehaviour
{
    private BoardManager boardManager;

    void Start()
    {
        // BoardManager 인스턴스 찾기
        boardManager = FindObjectOfType<BoardManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Player 태그를 가진 캐릭터가 칸에 들어오면 BoardManager에 알림
        if (other.CompareTag("Player"))
        {
            boardManager.NotifyPlayerPosition(this.gameObject);
        }
    }
}
