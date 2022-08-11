using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 페이드 아웃 스크립트
public class Init_Splash : MonoBehaviour

{
    GameObject SplashObj; // 패널 오브젝트
    Image image; // 패널 이미지

    [SerializeField] float delay; // 에디터에서 딜레이 조절 가능하도록 선언

    // private bool checkbool = false; // 투명도 조절 논리형 변수 

    void Awake()
    {
        SplashObj = this.gameObject; // 스크립트 참조된 오브젝트를 패널 오브젝트에 대입
        image = SplashObj.GetComponent<Image>(); // 패널 오브젝트에 이미지 참조
    }

    public void panelAwake()
    {
        Color color = image.color;
        color.a = 1f;
        image.color = color;
        Update();
        // StartCoroutine("MainSplash"); // 코루틴. 패널 투명도 조절
    }

    void Update()
    {
        // StartCoroutine("MainSplash"); // 코루틴. 패널 투명도 조절
        // if (checkbool) // 만약 checkbool이 참이면
        // {
        //     Destroy(this.gameObject); // 패널 파괴, 삭제
        // }

        Color color = image.color; // color에 패널 이미지 참조

        if (image.color.a > 0) {
            for (int i = 100; i >= 0; i--) // for문 100번 반복 0보다 작을 때까지
            {
                color.a -= Time.deltaTime * delay; // 이미지 알파 값을 타임 델타 값 * 0.01
                image.color = color; // 패널 이미지 컬러에 바뀐 알파값 참조

                // if (image.color.a <= 0) // 만약 패널 이미지 알파 값이 0보다 작으면
                // {
                //     checkbool = true; // checkbool 참 
                // }
            }
        }
    } 

    // IEnumerator MainSplash()
    // {
    //     // Color color = image.color; // color에 패널 이미지 참조

    //     // for (int i = 100; i >= 0; i--) // for문 100번 반복 0보다 작을 때까지
    //     // {
    //     //     color.a -= Time.deltaTime * delay; // 이미지 알파 값을 타임 델타 값 * 0.01
    //     //     image.color = color; // 패널 이미지 컬러에 바뀐 알파값 참조

    //     //     // if (image.color.a <= 0) // 만약 패널 이미지 알파 값이 0보다 작으면
    //     //     // {
    //     //     //     checkbool = true; // checkbool 참 
    //     //     // }
    //     // }
    //     yield return null; // 코루틴 종료
    // }
}