using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Animator animator;
    public float jumpForce = 5.0f;
    private bool isGrounded;

    void Update()
    {
        // Ű���� �Է��� �޾� ĳ���� �̵�
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);

        // �̵� �ִϸ��̼� ó��
        if (moveX != 0 || moveZ != 0)
        {
            running();
        }
        else
        {
            stopping();
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("Jump");
            isGrounded = false;
        }
    }

    public void running()
    {
        animator.SetBool("IsRunning", true);
    }

    public void stopping()
    {
        animator.SetBool("IsRunning", false);
    }
    

    void OnCollisionEnter(Collision collision)
    {
        // ĳ���Ͱ� ���� ��Ҵ��� Ȯ��
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
