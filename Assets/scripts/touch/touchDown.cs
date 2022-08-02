using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touchDown : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    {
        string[] sceneList = new string[]{"3. classroom", "4. corridor", "5. fight"}; // 오브젝트와의 접촉이 이루어지는 곳부터 배열에 저장 (사용할 논리는 sceneChange 스크립트에서와 같음)
        Scene scene = SceneManager.GetActiveScene(); // 현재 씬 이름 가져오기
        
        if (other.tag == "door") { // 문이랑 접촉했으면
            SceneManager.LoadScene(sceneList[System.Array.IndexOf(sceneList, scene.name) + 1]); // 다음 씬으로 넘어가기
        } if (other.tag == "Monster") { // 몬스터랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        } if (other.tag == "barrier") { // 장애물이랑 접촉했으면
            PlayerPrefs.SetInt("downMove", 0); // 아래쪽이 막혔음을 전달
        } if (other.tag == "textbook") { // 교과서의 범위에 들어섰다면
            Debug.Log("hello");
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "textbook") { // 교과서의 범위에서 벗어났다면
            Debug.Log("bye");
        } if (other.tag == "barrier") { // 장애물에서 벗어났다면
            PlayerPrefs.SetInt("downMove", 1); // 아래쪽으로 이동 가능함을 전달
        }
    }
}
