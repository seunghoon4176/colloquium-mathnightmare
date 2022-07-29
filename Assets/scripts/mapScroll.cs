using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapScroll : MonoBehaviour
{
    float moveX, moveY;
    [Header("이동 속도 조절")]
<<<<<<< HEAD
    [SerializeField] [Range(1f, 1000f)] float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~1000으로 설정 가능

=======
    [SerializeField] [Range(1f, 100f)] float moveSpeed = 1000f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능
>>>>>>> parent of 0eb4a88 (복도 배경 등록, 이동 일부 구현)
    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        transform.position = new Vector2(transform.position.x - moveX, transform.position.y - moveY); // 기존의 x값과 y값에 위에서 계산한 값을 뺌.
    }
}
