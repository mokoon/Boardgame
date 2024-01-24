using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectToRotate; // 회전시킬 게임 오브젝트

    public void RotateY()
    {
        objectToRotate.transform.Rotate(0, 90, 0); // Y축으로 90도 회전
    }
}
