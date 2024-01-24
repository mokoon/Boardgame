using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public GameObject dice;
    public Button rollButton;

    private Rigidbody diceRigidbody;

    void Start()
    {
        diceRigidbody = dice.GetComponent<Rigidbody>();
        rollButton.onClick.AddListener(RollDice);
    }

    private void RollDice()
    {
        // 주사위에 랜덤한 힘과 회전을 적용
        float forceY = Random.Range(5f, 10f); // Y축 힘
        float torqueX = Random.Range(-30f, 30f); // X축 회전
        float torqueZ = Random.Range(-60f, 60f); // Z축 회전

        diceRigidbody.AddForce(Vector3.up * forceY, ForceMode.Impulse);
        diceRigidbody.AddTorque(new Vector3(torqueX, 0, torqueZ), ForceMode.Impulse);
    }
}
