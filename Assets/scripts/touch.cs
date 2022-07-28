using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touch : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    {
        string[] sceneList = new string[]{"3. classroom", "4. corridor", "5. fight"}; // 오브젝트와의 접촉이 이루어지는 곳부터 배열에 저장 (사용할 논리는 sceneChange 스크립트에서와 같음)
        Scene scene = SceneManager.GetActiveScene(); // 현재 씬 이름 가져오기
        
        if (scene.name != "4. corridor") { // 현재 씬이 복도가 아니라면 (복도는 전투씬 직전 씬이기 때문에, 씬을 넘어갈 때 몬스터의 이름을 인수로 전달해주어야 하므로 따로 분리한다.)
            SceneManager.LoadScene(sceneList[System.Array.IndexOf(sceneList, scene.name) + 1]); // 다음 씬으로 넘어가기
        } else { // 현재 씬이 복도라면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        }
    }
}
