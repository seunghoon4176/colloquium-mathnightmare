using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveX, moveY;
    float moveSpeed = 500f; // 이동 속도 500으로 설정. 에디터에서 1~500으로 설정 가능
    
    void Start() {
        PlayerPrefs.SetInt("leftMove", 1);
        PlayerPrefs.SetInt("rightMove", 1);
        PlayerPrefs.SetInt("upMove", 1);
        PlayerPrefs.SetInt("downMove", 1);    
    }

    // moveX의 유무에 따라 좌표의 변화가 결정됨. 그렇기에 moveX에 1을 곱해주거나 0을 곱해줌으로서 '이동 / 정지'를 결정하려고 x라는 인수에 0또는 1을 받아 사용하는 함수를 정의함.
    void move(int x, int y) {
        transform.position = new Vector2(transform.position.x + (moveX * x), transform.position.y + (moveY * y));
    }

    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        int tempX = 1;
        int tempY = 1;

        if (PlayerPrefs.GetInt("upMove") == 0 && PlayerPrefs.GetInt("leftMove") == 0) {
            if (moveX < 0) {
                tempX = 0;
            } if (moveY > 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if (PlayerPrefs.GetInt("upMove") == 0 && PlayerPrefs.GetInt("rightMove") == 0) {
            if (moveX > 0) {
                tempX = 0;
            } if (moveY > 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if (PlayerPrefs.GetInt("downMove") == 0 && PlayerPrefs.GetInt("leftMove") == 0) {
            if (moveX < 0) {
                tempX = 0;
            } if (moveY < 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if (PlayerPrefs.GetInt("downMove") == 0 && PlayerPrefs.GetInt("rightMove") == 0) {
            if (moveX > 0) {
                tempX = 0;
            } if (moveY < 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if ((PlayerPrefs.GetInt("leftMove") == 0 && moveX < 0) || (PlayerPrefs.GetInt("rightMove") == 0 && moveX > 0)) {
            move(0, 1);
        } else if ((PlayerPrefs.GetInt("downMove") == 0 && moveY < 0) || (PlayerPrefs.GetInt("upMove") == 0 && moveY > 0)) {
            move(1, 0);
        } else {
            move(1, 1);
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
