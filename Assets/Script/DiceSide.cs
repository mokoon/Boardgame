using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{
    public int oppositeSideValue; // 반대편 주사위 눈의 값
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
            contactTime = 0f; // 접촉 시간 초기화
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (isContacting)
        {
            contactTime += Time.deltaTime;
            if (contactTime >= 0.5f) // 1초 이상 접촉 시
            {
                gameManager.SetDiceResult(oppositeSideValue);
                isContacting = false; // 결과 전송 후 접촉 상태 리셋
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "MainPlace")
        {
            isContacting = false; // 접촉 종료
        }
    }
}
