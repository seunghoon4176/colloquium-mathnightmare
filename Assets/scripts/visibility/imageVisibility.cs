using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 교과서 페이지 투명화 / 불투명화
public class imageVisibility : MonoBehaviour
{  
    public GameObject lectures;
    public GameObject confirm;
    public GameObject skip;
    public GameObject change;
    public GameObject goImage;
    public GameObject closebutton;
    public GameObject problem;
    public GameObject answerbox;
    public GameObject player;

    // 맵 넘어갈 때, 게임 종료할 때 페이지를 닫지 않았어도 차후에 영향을 주지 않도록 프로그램 실행과 동시에 초기화
    void Awake() {
        PlayerPrefs.SetInt("clicked", 0);

        this.lectures.transform.gameObject.SetActive(false);
        this.confirm.transform.gameObject.SetActive(false); 
        this.skip.transform.gameObject.SetActive(false); 
        this.change.transform.gameObject.SetActive(false); 
        this.goImage.transform.gameObject.SetActive(false);
        this.closebutton.transform.gameObject.SetActive(false);
        this.problem.transform.gameObject.SetActive(false);
        this.answerbox.transform.gameObject.SetActive(false);
        this.player.transform.gameObject.SetActive(true);
        
    }
     
    void Start() {
    }
    
    

    void Update() {
        if (PlayerPrefs.GetInt("clicked") == 1) { // textbookClick 스크립트에서 저장한 정보를 가져와서, 교과서쪽 버튼을 클릭했다면 실행

            this.lectures.transform.gameObject.SetActive(true);
            this.confirm.transform.gameObject.SetActive(true); 
            this.skip.transform.gameObject.SetActive(true); 
            this.change.transform.gameObject.SetActive(true); 
            this.goImage.transform.gameObject.SetActive(true);
            this.closebutton.transform.gameObject.SetActive(true);
            this.problem.transform.gameObject.SetActive(true);
            this.answerbox.transform.gameObject.SetActive(true);
            this.player.transform.gameObject.SetActive(false);

        
        } else if (PlayerPrefs.GetInt("clicked") == 0) { // 페이지를 닫는 버튼을 클릭했다면 실행   

            this.lectures.transform.gameObject.SetActive(false);
            this.confirm.transform.gameObject.SetActive(false); 
            this.skip.transform.gameObject.SetActive(false); 
            this.change.transform.gameObject.SetActive(false); 
            this.goImage.transform.gameObject.SetActive(false);
            this.closebutton.transform.gameObject.SetActive(false);
            this.problem.transform.gameObject.SetActive(false);
            this.answerbox.transform.gameObject.SetActive(false);
            this.player.transform.gameObject.SetActive(true);


        //GameObject.Find("Canvas").transform.Find("director").gameObject.SetActive(true);
    }
}
}