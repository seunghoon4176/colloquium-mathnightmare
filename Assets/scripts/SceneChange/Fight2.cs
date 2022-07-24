using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// struct monster
//     {
//         public string name;
//         public string appear_text;
//         public string info;
//         public int atk;
//         public int def;
//     }

public class Fight2 : MonoBehaviour
{

    public Text use_Text;

    // Start is called before the first frame update
    void Start()
    {
        // monster sin;
        // sin.appear_text = "sin";
        // Debug.Log(sin.appear_text);

        use_Text.text = "Sin";
    }

    // Update is called once per frame
    void Update()
    {
        // Set_use_text();
    }

    // void Set_use_text()
    // {
    //     monster sin;
    //     sin.appear_text = "sin";
    //     Debug.Log(sin.appear_text);

    //     // use_Text.text = sin.appear_text;
    // }
}
