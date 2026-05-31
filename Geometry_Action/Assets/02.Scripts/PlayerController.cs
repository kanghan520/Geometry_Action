using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 15f;
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // ★ 추가된 코드: 고양이의 현재 위아래 솟구치는 속도를 애니메이터(yVelocity)로 계속 보내줍니다!
        anim.SetFloat("yVelocity", rb.linearVelocity.y);

        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
            anim.SetBool("isJumping", true); // 점프 시작!
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("isJumping", false); // 바닥에 닿음 -> 달리기 복귀!
        }
    }
}