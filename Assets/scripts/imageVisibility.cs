using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 교과서 페이지 투명화 / 불투명화
public class imageVisibility : MonoBehaviour
{  
    void Update() {
        GameObject goImage = GameObject.Find("Canvas/Image"); // 이미지 찾아서 변수에 등록
        Color color = goImage.GetComponent<Image>().color; // 이미지의 색 추출
        
        if (PlayerPrefs.GetInt("clicked") == 1) { // textbookClick 스크립트에서 저장한 정보를 가져와서, 교과서쪽 버튼을 클릭했다면 실행
            color.a = 1f; // 불투명한 색으로 변경
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
        } else if (PlayerPrefs.GetInt("clicked") == 0) { // 페이지를 닫는 버튼을 클릭했다면 실행
            color.a = 0f; // 투명화
            goImage.GetComponent<Image>().color = color; // 오브젝트에 반영
        }
        
    }
}