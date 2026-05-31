using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 7f; // 장애물이 왼쪽으로 다가오는 속도입니다

    void Update()
    {
        // Vector2.left는 왼쪽 방향(X축 마이너스 방향)을 의미합니다
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        
        // 장애물이 화면 왼쪽 끝(X=-15)으로 나가면 게임에서 삭제합니다
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}