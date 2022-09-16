using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 오브젝트와의 접촉을 처리하는 스크립트.
public class touchUp : MonoBehaviour
{
    public string scene_name;

    public int x;
    public int y;

    void OnTriggerEnter2D(Collider2D other) // 오브젝트와 접촉하면 실행
    {
        if (other.tag == "door") { // 문이랑 접촉했으면
            PlayerPrefs.SetInt("playerInitX", x);
            PlayerPrefs.SetInt("playerInitY", y);  
            SceneManager.LoadScene(scene_name); // 다음 씬으로 넘어가기
        } if (other.tag == "barrier") { // 장애물이랑 접촉했으면
            PlayerPrefs.SetInt("upMove", 0); // 위쪽이 막혔음을 전달
        } if (other.tag == "sin") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sin"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "cos") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("cos"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "tan") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("tan"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "sincos") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sincos"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "costan") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("costan"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "sintan") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("sintan"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        } if (other.tag == "boss") { // '몬스터'랑 접촉했으면
            GameObject.Find("scriptTemp").GetComponent<change_to_fight>().ButtonClick("boss"); // "sin"을 인수로 전달하여 전투씬에 입장하기
        
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "barrier") { // 장애물에서 벗어났다면
            PlayerPrefs.SetInt("upMove", 1); // 위쪽으로 이동 가능함을 전달
        }
    }
}
