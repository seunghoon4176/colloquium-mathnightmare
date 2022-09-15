using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 교과서 페이지 투명화 / 불투명화
public class imageVisibility : MonoBehaviour
{  
    public GameObject parent;
    // 맵 넘어갈 때, 게임 종료할 때 페이지를 닫지 않았어도 차후에 영향을 주지 않도록 프로그램 실행과 동시에 초기화
    void Awake() {
        PlayerPrefs.SetInt("clicked", 0);
        this.parent.transform.gameObject.SetActive(false);
    }
     
    void Start() {
    }
    
    

    void Update() {
        if (PlayerPrefs.GetInt("clicked") == 1) { // textbookClick 스크립트에서 저장한 정보를 가져와서, 교과서쪽 버튼을 클릭했다면 실행
            this.parent.transform.gameObject.SetActive(true);
        
        } else if (PlayerPrefs.GetInt("clicked") == 0) { // 페이지를 닫는 버튼을 클릭했다면 실행   
            this.parent.transform.gameObject.SetActive(false);

    }
}
}