using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어가 벽을 뚫고 맵 밖으로 나갔을 때, 초기 위치로 돌아갈 수 있는 시스템을 구현
// 플레이어 오브젝트에 연결해야 하는 스크립트
public class playerPositionInit : MonoBehaviour
{
    // 에디터에서 스크립트마다 값 대입
    [SerializeField] int defaultX;
    [SerializeField] int defaultY;

    void Update()
    {
        // F5 입력 시 지정해둔 초기 위치로 이동
        if (Input.GetKeyDown(KeyCode.F5)) {
            transform.position = new Vector2(defaultX, defaultY);
        }
    }
}