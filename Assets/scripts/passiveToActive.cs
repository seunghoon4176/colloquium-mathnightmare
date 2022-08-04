using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 정체되어 있는 문에 기능을 부여하는, 말하자면 수동적인 문을 능동적으로 바꾸는 스크립트.
public class passiveToActive : MonoBehaviour
{
    // 어디로 이동할 수 있는가? (어느 문에 닿고 있는가) 저장하는 변수
    int canMove = 0;

    private void Start() {
        PlayerPrefs.SetInt("playerInitX", 0); // 사용자 지정 좌표 초기화
        PlayerPrefs.SetInt("playerInitY", 0); // 초기화
    }

    void OnTriggerEnter2D(Collider2D other) { // 오브젝트와 접촉하면 실행
        if (other.name == "classDoor") { // 교실 문이랑 접촉했으면
            canMove = 1; // 교실로 이동 가능
        } else if (other.name == "libraryDoor") { // 도서관 문이랑 접촉했으면
            canMove = 2; // 도서관으로 이동 가능
        }
    }

    void OnTriggerExit2D(Collider2D other) { // 접촉에서 벗어나면 실행
        if (other.tag == "passiveDoor") { // 벗어난 게 수동적인 문이라면
            canMove = 0; // 이동 불가능
        }
    }

    // 능동적으로 바뀌어 유발된 움직임을 처리하는 함수
    void triggeredMove() {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) { // 위쪽 방향키를 누르거나 W를 누르면 실행
            if (canMove == 1) { // 교실로 이동 가능하면
                // 교실의 출입구 근처로 사용자 지정 좌표 변경
                PlayerPrefs.SetInt("playerInitX", 950);
                PlayerPrefs.SetInt("playerInitY", 110);

                // 이렇게 지정해주고 넘어가면, 넘어간 씬에서 playerMovement 스크립트가 작동하여 그 좌표로 자동 이동함.
                // 확장성을 충분히 챙긴 스크립트임

                SceneManager.LoadScene("3. classroom"); // 다음 씬으로 넘어가기

            } else if (canMove == 2) { // 도서관으로 이동 가능하면
                // 좌표 지정 안 하고 바로 넘어감.
                // 플레이어가 여러 위치에 있을 필요가 없어서, 처음부터 에디터에서 알맞은 위치에만 두면 이렇게 해도 됨.
                // 교실 씬은 프롤로그가 끝나면 책상 근처에 있다가, 나중에 입구 통해서 다시 돌아오면 입구 근처에 위치해야 해서 좌표 지정이 필수였던 거임.
                
                SceneManager.LoadScene("4-1. library"); // 다음 씬으로 넘어가기
            }
        }
    }

    void Update() {
        // 조건문이 언제 만족될지 모르기에 업데이트로 계속 확인
        triggeredMove();    
    }
}

