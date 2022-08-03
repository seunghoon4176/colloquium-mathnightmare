using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 지금은 교과서 오브젝트에만 적용한 스크립트로, 가까이 다가가면 텍스트가 보이는 시스템을 마련함.
// 멘트 부분을 에디터에서 입력받아 적용하면 확장성을 더 높일 수 있을 듯하고, 지금 당장에도 거의 모든 경우에 대해 사용 가능할 듯함.
public class textVisibility : MonoBehaviour
{
    public Text ment; // 입력받으려는 건 아님. 텍스트 오브젝트를 연결할 곳임.

    void Start() {
        ment.text = ""; // 우선 시작하면 텍스트를 비워둠.
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") { // 플레이어랑 닿으면
            ment.text = "Click ↑"; // 텍스트를 적음
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") { // 플레이어가 나가면
            ment.text = ""; // 텍스트를 비움
        }
    }
}
