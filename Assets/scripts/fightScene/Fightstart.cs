using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 몬스터의 데이터 형식화
public struct monster
    {
        public string name;
        public string appearText;
        public string info;
        public string tip;
        public int atk;
        public int def;
    }

// 전투 씬 메인 클래스
public class Fight : MonoBehaviour
{
    public Text appearText; // 출현 문구 저장할 변수 선언

    void Start()
    {
        string monsterName = PlayerPrefs.GetString("monsterName"); // 전투 씬으로 넘어오기 전에 입력받은 몬스터의 이름을 가져옴 (change_to_fight 스크립트 참고)
        string[] monsterNames = new string[]{"sin", "cos", "tan", "sincos", "costan", "sintan", "boss"}; // 배열에 몬스터 종류 저장
        int monsterIndex = System.Array.IndexOf(monsterNames, monsterName); // 가져온 몬스터의 이름의 인덱스 값 저장
        monster_setting(monsterIndex); // 인덱스 값을 인수로 주어 몬스터 설정을 실행하도록 함.
    }

    void Update()
    {
        
    }

    // 각 몬스터의 정보를 저장하고, 인수에 들어온 값(= 몬스터 종류)에 따라 출현 문구 설정
    public void monster_setting(int input_value)
    {
        // 각 몬스터의 정보 저장
        monster sin;
        sin.name = "Sin 클롭스";
        sin.appearText = "Sin 클롭스가 나타났다!";
        sin.info = ".";
        sin.tip = "Sin 함수의 개형은 ...";
        sin.atk = 10;
        sin.def = 8;

        monster cos;
        cos.name = "Cos 클롭스";
        cos.appearText = "Cos 클롭스가 나타났다!";
        cos.info = ".";
        cos.tip = "Cos 함수의 개형은 ...";
        cos.atk = 12;
        cos.def = 10;

        monster tan;
        tan.name = "Tan 클롭스";
        tan.appearText = "Tan 클롭스가 나타났다!";
        tan.info = ".";
        tan.tip = "tan 함수의 개형은 ...";
        tan.atk = 15;
        tan.def = 12;

        monster sincos;
        sincos.name = "SinCos 클롭스";
        sincos.appearText = "SinCos 클롭스가 나타났다!";
        sincos.info = ".";
        sincos.tip = "앞서 공부한 내용을 떠올리자.";
        sincos.atk = 20;
        sincos.def = 18;

        monster costan;
        costan.name = "CosTan 클롭스";
        costan.appearText = "CosTan 클롭스가 나타났다!";
        costan.info = ".";
        costan.tip = "앞서 공부한 내용을 떠올리자.";
        costan.atk = 25;
        costan.def = 20;

        monster sintan;
        sintan.name = "SinTan 클롭스";
        sintan.appearText = "SinTan 클롭스가 나타났다!";
        sintan.info = ".";
        sintan.tip = "앞서 공부한 내용을 떠올리자.";
        sintan.atk = 30;
        sintan.def = 25;

        monster boss;
        boss.name = "보스";
        boss.appearText = "보스가 나타났다!";
        boss.info = ".";
        boss.tip = "그동안의 개념이 전부 사용된 보스 같다!";
        boss.atk = 100;
        boss.def = 80;
        
        // 몬스터 종류에 따라 출현 문구 설정
        monster[] monsterNameList = new monster[]{sin, cos, tan, sincos, costan, sintan, boss};
        appearText.text = monsterNameList[input_value].appearText; // sin.appearText처럼 요소에 직접 접근해도 되지만, 한 줄 한 줄 따로 적어줘야 하는 게 귀찮아서 배열을 만들고, 인덱스 값으로 접근함.
    }
}
