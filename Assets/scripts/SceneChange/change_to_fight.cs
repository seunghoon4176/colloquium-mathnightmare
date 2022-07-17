using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_to_fight : MonoBehaviour
{
    private struct Sin
    {
        private string text;

        private Sin(string text)
        {
            this.text = "sin 몬스터가 나타났다!";
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick(string monster) //버튼 클릭 이벤트에 대한 함수를 만들어 준다.
    { 
        SceneManager.LoadScene("fight");
    }
}
