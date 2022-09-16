using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScreen : MonoBehaviour
{
    public int Gold;
    public int LP;
    public int NowHP;
    public int MaxHP;
    public int ATK;
    public int DEF;
    public int SwordLevel;
    public int SpearLevel;
    public int nowweapon;
    //여기까지 상태, 이후는 상점의 글자들
    public Text mainShop;
    public Text nowGold;
    public Text nowLP;
    public Text nowSwordLevel;
    public Text nowSpearLevel;
    public Text ATKState;
    public Text DEFState;
    public Text HpState;

    private void Awake() {
        LP = PlayerPrefs.GetInt("LP");
        Gold = PlayerPrefs.GetInt("Gold");
        NowHP = PlayerPrefs.GetInt("NowHP");
        MaxHP = PlayerPrefs.GetInt("MaxHP");
        ATK = PlayerPrefs.GetInt("ATK");
        DEF = PlayerPrefs.GetInt("DEF");
        SwordLevel = PlayerPrefs.GetInt("SwordLevel");
        SpearLevel = PlayerPrefs.GetInt("SpearLevel");
        nowweapon = PlayerPrefs.GetInt("nowweapon");

        mainShop.text = "Welcome to the shop. buy what you want."; // 
        nowGold.text = "Your Gold : " + Gold + "G";
        nowLP.text = "Your LP :" + LP + "P";
        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void buyagain(){
        mainShop.text = "Let's buy awesome Things!";
    }

    void ReloadStats(){
        nowGold.text = "Your Gold : " + Gold + "G";
        nowLP.text = "Your LP :" + LP + "P";
        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
    }

    public void buySword(){
        if(Gold >= 500){
            PlayerPrefs.SetInt("Gold", Gold -= 500);
            PlayerPrefs.SetInt("SwordLevel", SwordLevel += 1);
            ReloadStats();
        }else{
            mainShop.text = "Failed to Reinforce SwordLevel.";
            Invoke("buyagain",2f);
        }
    }

    public void buySpear(){
        if(Gold >= 500){
            PlayerPrefs.SetInt("Gold", Gold -= 500);
            PlayerPrefs.SetInt("SpearLevel", SpearLevel += 1);
            ReloadStats();
        }else{
            mainShop.text = "Failed to Reinforce SpearLevel.";
            Invoke("buyagain",2f);
        }
    }

    public void buyATK(){
        if(LP >= 3){
            PlayerPrefs.SetInt("LP", LP -= 3);
            PlayerPrefs.SetInt("ATK", ATK += 1);
            ReloadStats();
        }else{
            mainShop.text = "Failed to Reinforce ATK";
            Invoke("buyagain",2f);
        }
    }

    public void buyDEF(){
        if(LP >= 3){
            PlayerPrefs.SetInt("LP", LP -= 3);
            PlayerPrefs.SetInt("DEF", DEF += 1);
            ReloadStats();
        }else{
            mainShop.text = "Failed to Reinforce DEF";
            Invoke("buyagain",2f);
        }
    }

    public void buyHP(){
        if(LP >= 3){
            PlayerPrefs.SetInt("LP", LP -= 3);
            PlayerPrefs.SetInt("MaxHP", MaxHP += 2);
            ReloadStats();
        }else{
            mainShop.text = "Failed to Reinforce MaxHP";
            Invoke("buyagain",2f);
        }
    }
}
