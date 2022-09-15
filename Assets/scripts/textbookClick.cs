using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 교과서 열고 닫는 버튼에 연결하는 스크립트
public class textbookClick : MonoBehaviour
{
    public GameObject Player;
    public void enableClick() { // 교과서와 같은 좌표를 갖는 버튼에 연결하는 함수
        PlayerPrefs.SetInt("clicked", 1); // 클릭 여부를 참으로 저장
        this.Player.transform.gameObject.SetActive(false);
    }

    public void disableClick() { // sinGraph 사진 파일을 닫는 버튼에 연결하는 함수
        PlayerPrefs.SetInt("clicked", 0); // 클릭 여부를 거짓으로 저장 (엄밀히 말하자면 페이지를 닫는 것)
        this.Player.transform.gameObject.SetActive(true);
    }
}
