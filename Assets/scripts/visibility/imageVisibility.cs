using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 교과서 페이지 투명화 / 불투명화
public class imageVisibility : MonoBehaviour
{  
    // 맵 넘어갈 때, 게임 종료할 때 페이지를 닫지 않았어도 차후에 영향을 주지 않도록 프로그램 실행과 동시에 초기화
    void Awake() {
        PlayerPrefs.SetInt("clicked", 0);
    }

    void Update() {
        GameObject goImage = GameObject.Find("Canvas/textbookPage");
        GameObject closebutton = GameObject.Find("Canvas/textbookPage/imageCloser");
        GameObject problem = GameObject.Find("Canvas/textbookPage/imageCloser/problem"); // 이미지 찾아서 변수에 등록
        Color color = goImage.GetComponent<Image>().color; // 이미지의 색 추출
        
        if (PlayerPrefs.GetInt("clicked") == 1) { // textbookClick 스크립트에서 저장한 정보를 가져와서, 교과서쪽 버튼을 클릭했다면 실행
            color.a = 1f; // 불투명한 색으로 변경
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
            //problem.GetComponent<Image>().color = color;
            closebutton.GetComponent<Image>().color = color;
        } else if (PlayerPrefs.GetInt("clicked") == 0) { // 페이지를 닫는 버튼을 클릭했다면 실행
            color.a = 0f; // 투명화
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
            //problem.GetComponent<Image>().color = color;
            closebutton.GetComponent<Image>().color = color;
            //아니 저 클로즈버튼 개새끼가 앞으로 오질 않아
        }

    }
}