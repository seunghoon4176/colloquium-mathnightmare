using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lecture : MonoBehaviour
{
    public GameObject LectureScreen;
    public GameObject Lecture1;
    public GameObject Lecture2;
    public GameObject Lecture3;
    public GameObject Lecture4;
    public GameObject Lecture5;
    public GameObject Lecture6;
    public GameObject Lecture7;
    public GameObject Lecture8;
    public GameObject Lecture9;
    public GameObject Lecture10;
    string scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetInt("clicked", 0);
        lectureclose();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("clicked") == 1){
            if (scene == "1. classroom"){
                lectureopen();
            }
        }else if (PlayerPrefs.GetInt("clicked") == 0){
            if (scene == "1. classroom"){
                lectureclose();
            }
        }
    }

    public void lecture1clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture2clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture3clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture4clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture5clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture6clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture7clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture8clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture9clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }
    public void lecture10clicked(){
        Application.OpenURL("https://www.youtube.com/?gl=KR&hl=ko");
    }

    public void lectureopen(){
        this.LectureScreen.transform.gameObject.SetActive(true);
    }
    public void lectureclose(){
        this.LectureScreen.transform.gameObject.SetActive(false);
    }
}

    

