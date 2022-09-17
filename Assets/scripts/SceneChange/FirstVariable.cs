using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstVariable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LetsStart(){
        PlayerPrefs.SetInt("Gold", 500);
        PlayerPrefs.SetInt("NowHP", 20);
        PlayerPrefs.SetInt("MaxHP", 20);
        PlayerPrefs.SetInt("ATK", 5);
        PlayerPrefs.SetInt("DEF", 5);
        PlayerPrefs.SetInt("LP", 10);
        PlayerPrefs.SetInt("SwordLevel", 0);
        PlayerPrefs.SetInt("SpearLevel", 0);
        PlayerPrefs.SetInt("Itemslot", 0);
    }
}
