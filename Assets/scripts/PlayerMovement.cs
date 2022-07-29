using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveX, moveY;
<<<<<<< HEAD
    float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능

=======
    [Header("이동 속도 조절")]
    [SerializeField] [Range(1f, 500f)] float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능
>>>>>>> parent of 0eb4a88 (복도 배경 등록, 이동 일부 구현)
    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY); // 기존의 x값과 y값에 위에서 계산한 값을 더함.

        // 카메라를 벗어나지 않도록 범위 제한
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
<<<<<<< HEAD
        if (pos.x < -825) pos.x = -825;
        if (pos.y < -380) pos.y = -380;
        if (pos.x > 825) pos.x = 825;
        if (pos.y > 245) pos.y = 245;
=======
        if (pos.x < 8f) pos.x = 8f;
        if (pos.y < 15f) pos.y = 15f;
        if (pos.x > 100f) pos.x = 100f;
        if (pos.y > 80f) pos.y = 80f;
>>>>>>> parent of 0eb4a88 (복도 배경 등록, 이동 일부 구현)
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }
}
