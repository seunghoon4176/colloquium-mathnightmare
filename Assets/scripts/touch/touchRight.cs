using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touchRight : MonoBehaviour
{
    public string scene_name;
    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    {        
        if (other.tag == "door") { // 문이랑 접촉했으면
            SceneManager.LoadScene(scene_name); // 에디터에서 입력한 씬으로 넘어가기
        } if (other.tag == "Monster") { // 몬스터랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기;
        } if (other.tag == "barrier") { // 장애물이랑 접촉했으면
            PlayerPrefs.SetInt("rightMove", 0); // 오른쪽이 막혔음을 전달
        } if (other.tag == "textbook") { // 교과서의 범위에 들어섰다면
            Debug.Log("hello");
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "textbook") { // 교과서의 범위에서 벗어났다면
            Debug.Log("bye");
        } if (other.tag == "barrier") { // 장애물에서 벗어났다면
            PlayerPrefs.SetInt("rightMove", 1); // 오른쪽으로 이동 가능함을 전달
        }
    }
}
