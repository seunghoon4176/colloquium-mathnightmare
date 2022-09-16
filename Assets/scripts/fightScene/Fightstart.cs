using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// 전투 씬 메인 클래스
public class Fightstart : MonoBehaviour
{
    public int NowHP;
    public int MaxHP;
    public int ATK;
    public int DEF;
    public int SwordLevel;
    public int SpearLevel;
    public int nowweapon;
    public int monsterIndex;
    public int Gold;
    //요기까진 수치들 가져오기

    public Text appearText; 
    public Text nowSwordLevel;
    public Text nowSpearLevel;
    public Text ATKState;
    public Text DEFState;
    public Text HpState;
    public Text nowGold;
    //요기까진 텍스트 연동 

    public GameObject atack;
    public GameObject talk;
    public GameObject run;
    public GameObject set;
    public int runpercent;
    //전투 시스템에 필요한 것들

    public string monsterName;
    public int atk;
    public int def;
    public int hp;
    public int damage;
    public Text MonsterHP;
    //몬스터꺼

    void Awake(){
        NowHP = PlayerPrefs.GetInt("NowHP");
        MaxHP = PlayerPrefs.GetInt("MaxHP");
        ATK = PlayerPrefs.GetInt("ATK");
        DEF = PlayerPrefs.GetInt("DEF");
        SwordLevel = PlayerPrefs.GetInt("SwordLevel");
        SpearLevel = PlayerPrefs.GetInt("SpearLevel");
        nowweapon = PlayerPrefs.GetInt("nowweapon");
        Gold = PlayerPrefs.GetInt("Gold");

        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
        nowGold.text = Gold + "G";
    }

    void Start()
    {
        monsterName = PlayerPrefs.GetString("monsterNames"); // 전투 씬으로 넘어오기 전에 입력받은 몬스터의 이름을 가져옴 (change_to_fight 스크립트 참고)
        Debug.Log(monsterName);
        if (monsterName == "sin"){
            atk = 10;
            def = 3;
            hp = 10;
        }
        if (monsterName == "cos"){
            atk = 5;
            def = 2;
            hp = 10;
        }
        if (monsterName == "tan"){
            atk = 3;
            def = 3;
            hp = 15;
        }
        if (monsterName == "sincos"){
            atk = 40;
            def = 8;
            hp = 100;
        }
        if (monsterName == "sintan"){
            atk = 20;
            def = 8;
            hp = 100;
        }
        if (monsterName == "costan"){
            atk = 15;
            def = 8;
            hp = 200;
        }
        if (monsterName == "boss"){
            atk = 66;
            def = 66;
            hp = 666;
        }
        MonsterHP.text = "Enemi Monster's HP:" + hp;
        PlayerTurn();
    }

    //요 안에 4가지 버튼을 담는다. 
    public void Playeratack(){
        MonsterTurn();
        damage = ATK - def;
        appearText.text = "사용자의 공격!" + damage + "데미지를 입혔다!";
        hp -= damage;
        MonsterHP.text = "Enemi Monster's HP:" + hp;
        if (hp <= 0){
            appearText.text = "몬스터를  처치했다! 100골드를 획득했다!";
            Invoke("CloseBattle",2f);
            Gold += 100;
        }else{
            Invoke("Monsteratack",2f);
        }
    }

    public void PlayerTalk(){
        MonsterTurn();
        if (runpercent >= 90){
            appearText.text = "괴물과 소통했습니다! 괴물이 그저 물러갔습니다! 50 골드 획득!";
            Gold += 50;
            Invoke("CloseBattle",2f);
        }else{
            appearText.text = "대화가 실패했습니다!";
            Invoke("Monsteratack",2f);
        }
    }

    public void PlayerRUN(){
        MonsterTurn();
        runpercent = Random.Range(0,101);
        if (runpercent >= 50){
            appearText.text = "무사히 도망쳤습니다!";
            Invoke("CloseBattle",2f);
        }else{
            appearText.text = "도망이 실패했습니다!";
            Invoke("Monsteratack",2f);
        }
    }
    
    public void PlayerSetting(){
        MonsterTurn();
        appearText.text = "과목과 단원이 더 있지 않습니다.";
        Invoke("Monsteratack",2f);
    }
    //끝.

    public void Monsteratack(){
        MonsterTurn();
        damage = atk - DEF;
        appearText.text = "몬스터의 공격!" + damage + "데미지를 입었다!";
        NowHP -= damage;
        ReloadStats();
        if (NowHP <= 0){
            appearText.text = "몬스터에게 당했다!";
            Invoke("CloseBattle",2f);
        }else{
            Invoke("PlayerTurn",2f);
        }
    }

    void CloseBattle(){
        SceneManager.LoadScene("1. classroom");
    }

    void MonsterTurn(){
        this.atack.transform.gameObject.SetActive(false);
        this.talk.transform.gameObject.SetActive(false);
        this.run.transform.gameObject.SetActive(false);
        this.set.transform.gameObject.SetActive(false);
    }

    void PlayerTurn(){
        appearText.text = "플레이어의 턴. 옆에서 행동을 선택해주십시오.";
        this.atack.transform.gameObject.SetActive(true);
        this.talk.transform.gameObject.SetActive(true);
        this.run.transform.gameObject.SetActive(true);
        this.set.transform.gameObject.SetActive(true);
    }

    void ReloadStats(){
        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
        nowGold.text = Gold + "G";
    }
}
