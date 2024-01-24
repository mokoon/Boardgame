using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTrigger : MonoBehaviour
{
    private BoardManager boardManager;

    void Start()
    {
        // BoardManager �ν��Ͻ� ã��
        boardManager = FindObjectOfType<BoardManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Player �±׸� ���� ĳ���Ͱ� ĭ�� ������ BoardManager�� �˸�
        if (other.CompareTag("Player"))
        {
            boardManager.NotifyPlayerPosition(this.gameObject);
        }
    }
}
