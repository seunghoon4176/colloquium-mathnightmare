using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 씬 이동을 총괄하는 스크립트. 기발한 아이디어를 통해 통합된 결과물.
public class sceneChange : MonoBehaviour
{
    public string scene_name; // 에디터에서 씬 이름 입력
    public void ButtonClick() // 버튼 클릭 이벤트에 대한 함수를 만들어 준다.
    { 
        SceneManager.LoadScene(scene_name); // 에디터에서 씬 이름 직접 적어서 하는 게 훨씬 확장성도 높고 효율적이라 이렇게 하기로 함.
    }
}
