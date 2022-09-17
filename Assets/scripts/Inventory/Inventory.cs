using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{   
    public GameObject InventoryParents;
    public int inventory;

    public int NowHP;
    public int MaxHP;
    public int ATK;
    public int DEF;
    public int SwordLevel;
    public int SpearLevel;
    public int Gold;

    public Text appearText; 
    public Text nowSwordLevel;
    public Text nowSpearLevel;
    public Text ATKState;
    public Text DEFState;
    public Text HpState;
    public Text nowGold;

    public int Itemslot;
    public Image hand; //기존에 존제하는 이미지
    public Sprite handimage;

    public Sprite Sword1;
    public Sprite Sword2;
    public Sprite Sword3;
    public Sprite Sword4;
    public Sprite Sword5;

    public Sprite Spear1;
    public Sprite Spear2;
    public Sprite Spear3;
    public Sprite Spear4;
    public Sprite Spear5;

    // Start is called before the first frame update
    void Start()
    {
        inventory = 0;
        this.InventoryParents.transform.gameObject.SetActive(false);

        NowHP = PlayerPrefs.GetInt("NowHP");
        MaxHP = PlayerPrefs.GetInt("MaxHP");
        ATK = PlayerPrefs.GetInt("ATK");
        DEF = PlayerPrefs.GetInt("DEF");
        SwordLevel = PlayerPrefs.GetInt("SwordLevel");
        SpearLevel = PlayerPrefs.GetInt("SpearLevel");
        Gold = PlayerPrefs.GetInt("Gold");

        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
        nowGold.text = Gold + "G";

        Itemslot = PlayerPrefs.GetInt("Itemslot");
        LoadItemSlot();
        appearText.text = "정보창입니다!";
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            if (inventory == 0) {
                this.InventoryParents.transform.gameObject.SetActive(true);
                inventory = 1;
            } else if (inventory == 1) {
                this.InventoryParents.transform.gameObject.SetActive(false);
                inventory = 0;
            }
        }
    }

    void ReloadStats(){
        nowSwordLevel.text = "Sword Lv :" + SwordLevel;
        nowSpearLevel.text = "Spear Lv :" + SpearLevel;
        ATKState.text = "My ATK :" + ATK;
        DEFState.text = "My DEF :" + DEF;
        HpState.text = NowHP + "/" + MaxHP;
        nowGold.text = Gold + "G";
    }

    public void LoadItemSlot(){
        if (Itemslot == 0){
            hand.sprite = handimage;
            //손
        }
        if (Itemslot == 1){
            if(SwordLevel == 0){
                hand.sprite = handimage;
            }
            if(SwordLevel == 1){
                hand.sprite = Sword1;
            }
            if(SwordLevel == 2){
                hand.sprite = Sword2;
            }
            if(SwordLevel == 3){
                hand.sprite = Sword3;
            }
            if(SwordLevel == 4){
                hand.sprite = Sword4;
            }
            if(SwordLevel == 5){
                hand.sprite = Sword5;
            }
            
            //칼
        }
        if (Itemslot == 2){
            if(SpearLevel == 0){
                hand.sprite = handimage;
            }
            if(SpearLevel == 1){
                hand.sprite = Spear1;
            }
            if(SpearLevel == 2){
                hand.sprite = Spear2;
            }
            if(SpearLevel == 3){
                hand.sprite = Spear3;
            }
            if(SpearLevel == 4){
                hand.sprite = Spear4;
            }
            if(SpearLevel == 5){
                hand.sprite = Spear5;
            }   
        }
    }

    public void HealButton(){
        NowHP = MaxHP;
        PlayerPrefs.SetInt("NowHP",MaxHP);
        ReloadStats();
        appearText.text = "회복되었습니다!";
    }

    public void PlayerChangeWeapon(){
        appearText.text = "무기가 변경되었습니다. 무기가 없다면 아무 일도 일어나지 않습니다.";
        Itemslot += 1;
        PlayerPrefs.SetInt("Itemslot", Itemslot);
        LoadItemSlot();
    }
}
