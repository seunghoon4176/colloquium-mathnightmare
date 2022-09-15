using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScreen : MonoBehaviour
{
    public static int Gold = 100;
    public static int NowHP = 20;
    public static int MaxHP = 20;
    public static int LP = 0;
    public static int ATK = 0;
    public static int DEF = 0;
    public static int SwordLevel = 0;
    public static int SpearLevel = 0;
    public static string nowweapon = "hand";

    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
