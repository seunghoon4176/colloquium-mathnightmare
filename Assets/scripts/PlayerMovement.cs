using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveX, moveY;
    float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능
    
    void Start() {
        PlayerPrefs.SetInt("canMove", 0);    
    }

    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        if (PlayerPrefs.GetInt("canMove") == 0) {
            transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY); // 기존의 x값과 y값에 위에서 계산한 값을 더함.
        } else if (PlayerPrefs.GetInt("canMove") == 1) {
            if (moveX < 0) {
                transform.position = new Vector2(transform.position.x, transform.position.y + moveY);
            } else {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
            }
        } else if (PlayerPrefs.GetInt("canMove") == 2) {
            if (moveX > 0) {
                transform.position = new Vector2(transform.position.x, transform.position.y + moveY);
            } else {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
            }
        } else if (PlayerPrefs.GetInt("canMove") == 3) {
            if (moveY > 0) {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y);
            } else {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
            }
        } else if (PlayerPrefs.GetInt("canMove") == 4) {
            if (moveY < 0) {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y);
            } else {
                transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
            }
        }

        // 범위 제한
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 6.5f) pos.x = 6.5f;
        if (pos.y < 14) pos.y = 14;
        if (pos.x > 101.5f) pos.x = 101.5f;
        if (pos.y > 80) pos.y = 80;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
