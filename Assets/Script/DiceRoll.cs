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
        // �ֻ����� ������ ���� ȸ���� ����
        float forceY = Random.Range(5f, 10f); // Y�� ��
        float torqueX = Random.Range(-30f, 30f); // X�� ȸ��
        float torqueZ = Random.Range(-60f, 60f); // Z�� ȸ��

        diceRigidbody.AddForce(Vector3.up * forceY, ForceMode.Impulse);
        diceRigidbody.AddTorque(new Vector3(torqueX, 0, torqueZ), ForceMode.Impulse);
    }
}
