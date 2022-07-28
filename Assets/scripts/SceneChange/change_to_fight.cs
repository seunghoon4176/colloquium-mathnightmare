using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// fight으로 넘어갈 때 monster 인수에 값을 넣어줘야 하므로, change_to_fight을 남겨두어 간편하게 인수를 넣을 수 있도록 함.
public class change_to_fight : MonoBehaviour
{
    public void ButtonClick(string monster) // 버튼(몬스터의 사진)을 클릭하면 실행. 함수 연결 과정에서 몬스터의 이름을 입력해주어야 함.
    { 
        PlayerPrefs.SetString("monsterName", monster); // 몬스터의 이름을 씬이 넘어가도 사용 가능하도록 함. (일반적으로는 씬이 넘어갈 때 이전의 내용을 다 삭제해서 사용하지 못함)
        SceneManager.LoadScene("5. fight");
    }
}
