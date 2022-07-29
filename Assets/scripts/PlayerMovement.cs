using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveX, moveY;
    [Header("이동 속도 조절")]
    [SerializeField] [Range(1f, 500f)] float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능
    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY); // 기존의 x값과 y값에 위에서 계산한 값을 더함.

        // 카메라를 벗어나지 않도록 범위 제한
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 8f) pos.x = 8f;
        if (pos.y < 15f) pos.y = 15f;
        if (pos.x > 100f) pos.x = 100f;
        if (pos.y > 80f) pos.y = 80f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }
}
