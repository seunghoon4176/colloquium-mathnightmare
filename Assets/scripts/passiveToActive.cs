using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class passiveToActive : MonoBehaviour
{
    public string scene_name;

    void OnTriggerStay2D(Collider2D other) { // 오브젝트와 접촉하는 중이면 실행
        if (other.tag == "passiveDoor") { // 문이랑 접촉했으면
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
                SceneManager.LoadScene(scene_name); // 다음 씬으로 넘어가기
            }
        }
    }
}