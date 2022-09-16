using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 몬스터의 데이터 형식화
public struct monster
    {
        public string name;
        public string appearText;
        public int atk;
        public int def;
        public int hp;
    }

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
    public int damage;

    public Text appearText; // 출현 문구 저장할 변수 선언
    public Text nowSwordLevel;
    public Text nowSpearLevel;
    public Text ATKState;
    public Text DEFState;
    public Text HpState;
    public Text nowGold;

    public string Turn;
    public string Act;

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

    void ReloadStats(){
        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
        nowGold.text = Gold + "G";


    }

    void Start()
    {
        string monsterName = PlayerPrefs.GetString("monsterName"); // 전투 씬으로 넘어오기 전에 입력받은 몬스터의 이름을 가져옴 (change_to_fight 스크립트 참고)
        string[] monsterNames = new string[]{"sin", "cos", "tan", "sincos", "costan", "sintan", "boss"}; // 배열에 몬스터 종류 저장
        monsterIndex = System.Array.IndexOf(monsterNames, monsterName); // 가져온 몬스터의 이름의 인덱스 값 저장
        monster_setting(monsterIndex); // 인덱스 값을 인수로 주어 몬스터 설정을 실행하도록 함.
        PlayerTurn();
    }

    void PlayerTurn(){
        appearText.text = "플레이어의 턴. 옆에서 행동을 선택해주십시오.";
        Turn = "Player";
        Act = "none";
    }

    void Playeratack(){
        Act = "Atack";
        Turn = "Monster";
        MonsterAtacked();
    }

    void MonsterAtacked(){
        damage = ATK - monsterName.def;
        appearText.text = "사용자의 공격!" + damage + "데미지를 입혔다!";
    }

    void MonsterAtack(){
        
    }

    // 각 몬스터의 정보를 저장하고, 인수에 들어온 값(= 몬스터 종류)에 따라 출현 문구 설정
    void monster_setting(int input_value)
    {
        // 각 몬스터의 정보 저장
        monster sin;
        sin.name = "Sin 클롭스";
        sin.appearText = "Sin 클롭스가 나타났다!";
        sin.atk = 10;
        sin.def = 8;
        sin.hp = 20;

        monster cos;
        cos.name = "Cos 클롭스";
        cos.appearText = "Cos 클롭스가 나타났다!";
        cos.atk = 12;
        cos.def = 10;
        cos.hp = 20;

        monster tan;
        tan.name = "Tan 클롭스";
        tan.appearText = "Tan 클롭스가 나타났다!";
        tan.atk = 15;
        tan.def = 12;
        tan.hp = 20;

        monster sincos;
        sincos.name = "SinCos 클롭스";
        sincos.appearText = "SinCos 클롭스가 나타났다!";
        sincos.atk = 20;
        sincos.def = 18;
        sincos.hp = 100;

        monster costan;
        costan.name = "CosTan 클롭스";
        costan.appearText = "CosTan 클롭스가 나타났다!";
        costan.atk = 25;
        costan.def = 20;
        costan.hp = 100;

        monster sintan;
        sintan.name = "SinTan 클롭스";
        sintan.appearText = "SinTan 클롭스가 나타났다!";
        sintan.atk = 30;
        sintan.def = 25;
        sintan.hp = 100;

        monster boss;
        boss.name = "보스";
        boss.appearText = "보스가 나타났다!";
        boss.atk = 100;
        boss.def = 80;
        boss.hp = 500;
        
        // 몬스터 종류에 따라 출현 문구 설정
        monster[] monsterNameList = new monster[]{sin, cos, tan, sincos, costan, sintan, boss};
        appearText.text = monsterNameList[input_value].appearText; // sin.appearText처럼 요소에 직접 접근해도 되지만, 한 줄 한 줄 따로 적어줘야 하는 게 귀찮아서 배열을 만들고, 인덱스 값으로 접근함.
    }
}
