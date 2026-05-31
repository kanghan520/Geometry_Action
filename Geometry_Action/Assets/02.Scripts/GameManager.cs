using UnityEngine;
using TMPro; // 화면에TextMeshPro 글씨를 제어하기 위해 유니티에게 내리는 필수 주문입니다.

public class GameManager : MonoBehaviour
{
    // static을 붙이면 게임 화면이 죽고 재시작(Reload)되어도 이 숫자는 메모리에 지워지지 않고 유지됩니다.
    public static int attemptCount = 1; 

    // 유니티 인스펙터 창에서 글씨 오브젝트를 연결할 수 있도록 문을 열어두는 코드입니다.
    public TextMeshProUGUI stageText;
    public TextMeshProUGUI attemptText;

    // 게임이 처음 켜지거나, 죽어서 재시작될 때 가장 먼저 딱 한 번 실행되는 곳입니다.
    void Start()
    {
        stageText.text = "Stage 1-1";
        attemptText.text = "Attempt : " + attemptCount;
    }
}