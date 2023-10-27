using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jumpForce = 5.0f; // ���� �� ������ ���� ����
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �����̽��ٸ� ���� �� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }
    }

    void JumpAction()
    {
        // ������Ʈ�� ������Ű�� �Լ�
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
