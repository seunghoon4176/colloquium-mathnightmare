using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 세팅으로 향하는 스크립트는 순차적 규칙에 따르지 않기에 따로 놔둬야 해서 sceneChange로 병합되지 않음.
public class change_to_setting : MonoBehaviour
{
    public void ButtonClick() // 버튼 클릭 이벤트에 대한 함수를 만들어 준다.
    { 
        SceneManager.LoadScene("1-1. setting");
    }
}
