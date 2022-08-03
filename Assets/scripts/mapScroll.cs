using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경을 이동시키는 스크립트.
public class mapScroll : MonoBehaviour
{
    // 에디터에서 값을 조절할 수 있도록 범위를 지정해줌.
    [SerializeField] [Range(-5000f, 5000f)] float minX = -132f; // 맵의 x좌표의 최솟값
    [SerializeField] [Range(-5000f, 5000f)] float maxX = 229f; // 맵의 x좌표의 최댓값
    [SerializeField] [Range(0f, 500f)] float minY = 55f; // 맵의 y좌표의 최솟값
    [SerializeField] [Range(0f, 500f)] float maxY = 55f; // 맵의 y좌표의 최댓값

    float moveX, moveY; // x축의 방향으로 이동할 값, y축의 방향으로 이동할 값 저장할 변수 선언 (계속 계산하여 갱신함)
    
    [Header("이동 속도 조절")]
    [SerializeField] [Range(1f, 2000f)] float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~2000으로 설정 가능

    void Start() {
        // 사용자가 좌표를 직접 지정했으면
        if (PlayerPrefs.GetInt("playerInitX") != 0 && PlayerPrefs.GetInt("playerInitY") != 0) {
            // 스크립트가 연결된 오브젝트를 지정된 좌표로 이동하고
            transform.position = new Vector2(PlayerPrefs.GetInt("playerInitX"), PlayerPrefs.GetInt("playerInitY"));
            
            // 방금 지정한 좌표가 차후에 영향을 미치지 않도록 초기화
            PlayerPrefs.SetInt("playerInitX", 0);
            PlayerPrefs.SetInt("playerInitY", 0);  
        }
    }

    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        // 기존의 x값과 y값에 위에서 계산한 값을 더해서 갱신함.
        transform.position = new Vector2(transform.position.x - moveX, transform.position.y - moveY);

        // 위에서 갱신한 게 과했다면 번복함.
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < minX) pos.x = minX;
        if (pos.y < minY) pos.y = minY;
        if (pos.x > maxX) pos.x = maxX;
        if (pos.y > maxY) pos.y = maxY;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
