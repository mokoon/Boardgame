using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectToRotate; // ȸ����ų ���� ������Ʈ

    public void RotateY()
    {
        objectToRotate.transform.Rotate(0, 90, 0); // Y������ 90�� ȸ��
    }
}
