using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f; // 장애물 생성 주기
    private float timer;

    // ★ 클리어 라인이 어딨는지 추적할 변수
    private Transform clearLine; 

    void Start()
    {
        // 게임이 시작될 때 "ClearLine"이라는 이름을 가진 오브젝트를 찾아서 기억합니다.
        GameObject lineObj = GameObject.Find("ClearLine");
        if (lineObj != null)
        {
            clearLine = lineObj.transform;
        }
    }

    void Update()
    {
        // ★ 핵심 로직: 클리어 라인이 스포너(X좌표)를 지나쳐 왼쪽으로 갔다면?
        // -> 장애물 생성(Update)을 멈추고 함수를 빠져나갑니다!
        if (clearLine != null && clearLine.position.x <= transform.position.x)
        {
            return; 
        }

        // 아래는 기존의 장애물 생성 로직입니다.
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        // 장애물의 Y 높이를 고정해서 생성
        Vector3 spawnPosition = new Vector3(transform.position.x, -0.5f, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}