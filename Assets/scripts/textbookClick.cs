using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 교과서 열고 닫는 버튼에 연결하는 스크립트
public class textbookClick : MonoBehaviour
{
    string scene;
    public GameObject Player;
    public GameObject ShopScreen;
    public GameObject NPC;

    void Start(){
        scene = SceneManager.GetActiveScene().name;
        shopclose();
    }

    public void enableClick() { // 교과서와 같은 좌표를 갖는 버튼에 연결하는 함수
        PlayerPrefs.SetInt("clicked", 1); // 클릭 여부를 참으로 저장
        this.Player.transform.gameObject.SetActive(false);
        if (scene == "3. shop"){
                shopopen();
            }
    }

    public void disableClick() { // sinGraph 사진 파일을 닫는 버튼에 연결하는 함수
        PlayerPrefs.SetInt("clicked", 0); // 클릭 여부를 거짓으로 저장 (엄밀히 말하자면 페이지를 닫는 것)
        this.Player.transform.gameObject.SetActive(true);
        if (scene == "3. shop"){
                shopclose();
            }
    }

    public void shopopen(){
        this.ShopScreen.transform.gameObject.SetActive(true);
        this.NPC.transform.gameObject.SetActive(false);
    }

    public void shopclose(){
        this.ShopScreen.transform.gameObject.SetActive(false);
        this.NPC.transform.gameObject.SetActive(true);
    }

}
