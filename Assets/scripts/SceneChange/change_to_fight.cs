using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_to_fight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick(string monster) // 버튼(몬스터의 사진)을 클릭하면 실행. 함수 연결 과정에서 몬스터의 이름을 입력해주어야 함.
    { 
        PlayerPrefs.SetString("monsterName", monster); // 몬스터의 이름을 씬이 넘어가도 사용 가능하도록 함. (일반적으로는 씬이 넘어갈 때 이전의 내용을 다 삭제해서 사용하지 못함)
        SceneManager.LoadScene("5. fight");
    }
}
