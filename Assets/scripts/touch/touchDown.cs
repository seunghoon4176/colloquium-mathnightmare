using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touchDown : MonoBehaviour
{
    public string scene_name; // 문이 히트박스에 닿았을 때 위쪽 방향키 혹은 W를 누르면 씬이 넘어가도록 하기 위하여 에디터로부터 씬 이름을 받음.

    public int x; // 넘어온 씬에서의 위치를 지정해주지 않으면 기본값을 가짐. 그럼 경우에 따라 매우 부자연스럽기에 에디터로부터 값을 받음.
    public int y; // 에디터로부터 이동 후의 y좌표값을 입력받음.

    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    { 
        if (other.tag == "door") { // '문'이랑 접촉했으면 (닿으면 바로 실행함. 수동적인 문과 명확히 분리되는 태그임)
            PlayerPrefs.SetInt("playerInitX", x); // 사용자의 초기화 x좌표를 해당 스크립트에 연결한 값으로 설정
            PlayerPrefs.SetInt("playerInitY", y); // y좌표 설정
            SceneManager.LoadScene(scene_name); // 입력받은 씬으로 넘어가기

        } if (other.tag == "Monster") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "barrier") { // 장애물이랑 접촉했으면
            PlayerPrefs.SetInt("downMove", 0); // 아래쪽이 막혔음을 전달
        }
    }

    void OnTriggerExit2D(Collider2D other) { // 오브젝트와의 접촉에서 벗어나면 실행
        if (other.tag == "barrier") { // 벗어난 게 장애물이라면
            PlayerPrefs.SetInt("downMove", 1); // 아래쪽으로 이동 가능함을 전달
        }
    }
}
