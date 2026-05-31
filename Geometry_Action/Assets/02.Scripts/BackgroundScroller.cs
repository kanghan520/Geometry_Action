using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f; // 배경이 움직이는 속도 (Inspector에서 조절 가능)
    
    private float spriteWidth;
    private Vector3 startPosition;

    void Start()
    {
        // 시작 위치를 기억해 둡니다.
        startPosition = transform.position;
        
        // 유니티가 이미지의 가로 길이를 자동으로 계산해서 가져옵니다! (수동 입력 필요 없음)
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // 배경을 지정한 속도만큼 왼쪽으로 계속 이동시킵니다.
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // 만약 배경이 자기 가로 길이만큼 왼쪽으로 완전히 이동했다면?
        if (transform.position.x <= startPosition.x - spriteWidth)
        {
            // 다시 원래 시작했던 위치로 텔레포트시킵니다. (무한 반복)
            transform.position = startPosition;
        }
    }
}