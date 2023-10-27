using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jumpForce = 5.0f; // 점프 힘 조절을 위한 변수
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스바를 누를 때 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }
    }

    void JumpAction()
    {
        // 오브젝트를 점프시키는 함수
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
