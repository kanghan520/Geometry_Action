using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // 이건 가시(Obstacle)랑 부딪혔을 때 죽는 기존 코드 (Is Trigger가 꺼진 애들과 충돌)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.attemptCount++; 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Is Trigger가 켜진 결승선을 통과할 때
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            // 1. "ClearText"라는 이름을 가진 숨겨진 UI를 찾아서 켜줍니다.
            GameObject.Find("Canvas").transform.Find("ClearText").gameObject.SetActive(true);
            
            // 2. 게임 세상의 시간을 0으로 만들어서 멈춰버립니다! (모든 이동 정지)
            Time.timeScale = 0; 
        }
    }
}