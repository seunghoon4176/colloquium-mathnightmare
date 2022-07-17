using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_to_classroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick() //버튼 클릭 이벤트에 대한 함수를 만들어 준다.
    { 
        SceneManager.LoadScene("classroom");
    }
}
