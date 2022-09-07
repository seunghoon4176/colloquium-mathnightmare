using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 교과서 페이지 투명화 / 불투명화
public class imageVisibility : MonoBehaviour
{  
    public Text lectures;
    public Text confirm;
    public Text skip;
    public Text change;

    // 맵 넘어갈 때, 게임 종료할 때 페이지를 닫지 않았어도 차후에 영향을 주지 않도록 프로그램 실행과 동시에 초기화
    void Awake() {
        PlayerPrefs.SetInt("clicked", 0);
        lectures.text = "";
        confirm.text = "";
        skip.text = "";
        change.text = "";

        // 요기는 이제 처음 실행하면 각  버튼을 x가 2000씩 옮겨진 코드를 넣어야 함.
        
    }
     
    
    

    void Update() {
        GameObject goImage = GameObject.Find("Canvas/textbookPage");
        GameObject closebutton = GameObject.Find("Canvas/textbookPage/imageCloser");
        GameObject problem = GameObject.Find("Canvas/textbookPage/problem"); // 이미지 찾아서 변수에 등록
        
        /*
        GameObject lectures = GameObject.Find("Canvas/textbookPage/WatchButton");
        GameObject confirm = GameObject.Find("Canvas/textbookPage/ConfirmButton");
        GameObject skip = GameObject.Find("Canvas/textbookPage/SkipButton");
        GameObject change = GameObject.Find("Canvas/textbookPage/ChangeProblem"); //요 문제풀이의 버튼들을 다 움직이려고 가져옴.
        */
        

        //밑에꺼는 추후 input박스 만들려고 냅둠 일단 보류
        //GameObject input = GameObject.Find("Canvas/textbookPage/AnswerInput/TextArea");
        
        Color color = goImage.GetComponent<Image>().color; // 이미지를 투명화시킴 
        
        if (PlayerPrefs.GetInt("clicked") == 1) { // textbookClick 스크립트에서 저장한 정보를 가져와서, 교과서쪽 버튼을 클릭했다면 실행
            color.a = 1f; // 불투명한 색으로 변경
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
            //problem.GetComponent<Image>().color = color;
            closebutton.GetComponent<Image>().color = color;
            //input.GetComponent<Image>().color = color;    
            
            
            lectures.text = "Watching lectures";
            confirm.text = "Confirm answer";
            skip.text = "Skip problem";
            change.text = "Change Problem";
            
    
        
        } else if (PlayerPrefs.GetInt("clicked") == 0) { // 페이지를 닫는 버튼을 클릭했다면 실행
            color.a = 0f; // 투명화
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
            //problem.GetComponent<Image>().color = color;
            closebutton.GetComponent<Image>().color = color;
            //input.GetComponent<Image>().color = color;    

            
            lectures.text = "";
            confirm.text = "";
            skip.text = "";
            change.text = ""; 

            //닫았다면 다시 위에 awake에 들어가 있을, 얘네를 2000씩 미는 코드를 넣어야 함.
        }

        GameObject.Find("Canvas").transform.Find("director").gameObject.SetActive(true);
    }
}