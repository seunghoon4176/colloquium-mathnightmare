using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어의 움직임을 조작할 클래스
public class PlayerMovement : MonoBehaviour
{
    // x축의 방향으로 이동할 값, y축의 방향으로 이동할 값 저장할 변수 선언
    float moveX, moveY;
    float moveSpeed = 500f; // 이동 속도 500으로 설정
    
    public int playerInitX = 0;
    public int playerInitY = 0;

    // 해당 방향으로 이동 가능한지를 저장하는 변수를 PlayerPrefs에 등록. (1: 가능, 0: 불가능)
    void Start() {
        PlayerPrefs.SetInt("leftMove", 1);
        PlayerPrefs.SetInt("rightMove", 1);
        PlayerPrefs.SetInt("upMove", 1);
        PlayerPrefs.SetInt("downMove", 1);    

        if (playerInitX != 0 || playerInitY != 0) {
            transform.position = new Vector2(playerInitX, playerInitY);
        }
    }


    // moveX의 유무에 따라 좌표의 변화가 결정됨. 그렇기에 moveX에 1을 곱해주거나 0을 곱해줌으로서 '이동 / 정지'를 결정하려고 x라는 인수에 0또는 1을 받아 사용하는 함수를 정의함.
    void move(int x, int y) {
        transform.position = new Vector2(transform.position.x + (moveX * x), transform.position.y + (moveY * y));
    }

    // update: 프레임마다 처리하는 함수
    void Update()
    {
        // 이동 (상하좌우 키: WASD키 혹은 상하좌우 키)
        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime; // 추가할 x값 계산
        moveY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime; // 추가할 y값 계산

        // x축, y축으로의 이동 여부를 저장하는 변수. 위에서 선언한 move함수의 인수로 사용할 예정
        int tempX = 1;
        int tempY = 1;

        // 조건문을 확인하는 데 걸리는 짧은 시간조차 프레임이 넘어가는 것보다 길 수 있기에 물체가 대각선으로 닿고 있는 특수 케이스부터 처리함.
        if (PlayerPrefs.GetInt("upMove") == 0 && PlayerPrefs.GetInt("leftMove") == 0) { // 위쪽과 왼쪽이 막혔을 때
            if (moveX < 0) { // 왼쪽으로 가려 하면
                tempX = 0; // x축의 이동이 없도록 함
            } if (moveY > 0) { // 위쪽으로 가려 하면
                tempY = 0; // y축의 이동이 없도록 함
            } move(tempX, tempY); // 이동
        } else if (PlayerPrefs.GetInt("upMove") == 0 && PlayerPrefs.GetInt("rightMove") == 0) { // 위쪽과 오른쪽이 막혔을 때
            if (moveX > 0) { // 오른쪽으로 가려 하면
                tempX = 0; // x축의 이동이 없도록 함
            } if (moveY > 0) { // ...
                tempY = 0; // ...
            } move(tempX, tempY); // ..
        } else if (PlayerPrefs.GetInt("downMove") == 0 && PlayerPrefs.GetInt("leftMove") == 0) { // 아래쪽과 왼쪽이 막혔을 때
            if (moveX < 0) {
                tempX = 0;
            } if (moveY < 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if (PlayerPrefs.GetInt("downMove") == 0 && PlayerPrefs.GetInt("rightMove") == 0) { // 아래쪽과 오른쪽이 막혔을 때
            if (moveX > 0) {
                tempX = 0;
            } if (moveY < 0) {
                tempY = 0;
            } move(tempX, tempY);
        } else if ((PlayerPrefs.GetInt("leftMove") == 0 && moveX < 0) || (PlayerPrefs.GetInt("rightMove") == 0 && moveX > 0)) { // 왼쪽이 막혔는데 왼쪽으로 가려 하거나, 오른쪽이 막혔는데 오른쪽으로 가려 하면
            move(0, 1); // x축의 이동이 없도록 함
        } else if ((PlayerPrefs.GetInt("downMove") == 0 && moveY < 0) || (PlayerPrefs.GetInt("upMove") == 0 && moveY > 0)) { // 아래쪽이 막혔는데 아래쪽으로 가려 하거나, 위쪽이 막혔는데 위쪽으로 가려 하면
            move(1, 0); // y축의 이동이 없도록 함
        } else { // 막힌 데가 전혀 없으면
            move(1, 1); // 그냥 이동
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
