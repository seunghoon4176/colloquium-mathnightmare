using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 다른 씬 이동들과는 달리, 전투씬 이동에서는 monster 인수에 값을 넣어줘야 하므로 change_to_fight 스크립트를 따로 생성함.
public class change_to_fight : MonoBehaviour
{
    public void ButtonClick(string monster) // 몬스터와 닿으면 실행. 에디터에서 몬스터의 이름을 입력해주어야 함.
    { 
        PlayerPrefs.SetString("monsterName", monster); // 몬스터의 이름을 씬이 넘어가도 사용 가능하도록 함.
        SceneManager.LoadScene("4.fight"); // 전투씬으로 넘어감
    }
}
