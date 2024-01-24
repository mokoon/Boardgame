using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{
    public int oppositeSideValue; // �ݴ��� �ֻ��� ���� ��
    private GameManager gameManager;
    private float contactTime = 0f;
    private bool isContacting = false;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MainPlace")
        {
            isContacting = true;
            contactTime = 0f; // ���� �ð� �ʱ�ȭ
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (isContacting)
        {
            contactTime += Time.deltaTime;
            if (contactTime >= 0.5f) // 1�� �̻� ���� ��
            {
                gameManager.SetDiceResult(oppositeSideValue);
                isContacting = false; // ��� ���� �� ���� ���� ����
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "MainPlace")
        {
            isContacting = false; // ���� ����
        }
    }
}
