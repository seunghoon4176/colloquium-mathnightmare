using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 씬 이동을 총괄하는 스크립트. 기발한 아이디어를 통해 통합된 결과물.
public class sceneChange : MonoBehaviour
{
    public void ButtonClick() // 버튼 클릭 이벤트에 대한 함수를 만들어 준다.
    { 
        string[] sceneList = new string[]{"1-1. setting", "1. title", "2. prolog", "3. classroom", "4. corridor"}; // 씬 이름 목록 생성
        Scene scene = SceneManager.GetActiveScene(); // 현재 씬 이름의 인덱스 값 가져오기
        SceneManager.LoadScene(sceneList[System.Array.IndexOf(sceneList, scene.name) + 1]);

        /* 일반적으로 씬의 순서대로 이동하기 때문에 (첫 번째 씬에서 두 번째 씬으로, 두 번째 씬에서 세 번째 씬으로, ... 이런 식으로)
        순서대로 나열한 배열에서 현재 씬의 인덱스 값에 1을 더한 인덱스 값으로 인덱싱을 하면 다음 씬 이름이 나오는 것을 이용하여
        씬 이동을 따로따로 하지 않아도 되도록 함. */
    }
}
