using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touchLeft : MonoBehaviour
{
    public string scene_name;

    public int x;
    public int y;

    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    {
        if (other.tag == "door") { // 문이랑 접촉했으면
            PlayerPrefs.SetInt("playerInitX", x);
            PlayerPrefs.SetInt("playerInitY", y);  
            SceneManager.LoadScene(scene_name); // 다음 씬으로 넘어가기
        } if (other.tag == "Monster") { // 몬스터랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기;
        } if (other.tag == "barrier") { // 장애물이랑 접촉했으면
            PlayerPrefs.SetInt("leftMove", 0); // 왼쪽이 막혔음을 전달
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "barrier") { // 장애물에서 벗어났다면
            PlayerPrefs.SetInt("leftMove", 1); // 왼쪽으로 이동 가능함을 전달
        }
    }
}
