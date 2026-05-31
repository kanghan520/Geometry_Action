using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;       // 점프 힘
    public float moveSpeed = 5f;        // 전진 속도 (추가됨)
    private Rigidbody2D rb;
    private bool isGrounded;            // 바닥에 닿아있는지 확인

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. 점프 로직
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
        if (Input.GetMouseButtonDown(0) && isGrounded)
    {
        Debug.Log("점프!"); // 클릭할 때마다 콘솔에 "점프!"가 뜨는지 확인
        rb.linearVelocity = Vector2.up * jumpForce;
    }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}