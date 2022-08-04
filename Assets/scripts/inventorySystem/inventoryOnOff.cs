using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryOnOff : MonoBehaviour
{
    bool alreadyInputed = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject invUI = GameObject.Find("Canvas/inventorySystem/Bag");
        invUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject invUI = GameObject.Find("Canvas/inventorySystem/Bag");
        
        if (Input.GetKeyDown(KeyCode.I)) {
            if (alreadyInputed == false) {
                invUI.SetActive(true);
                alreadyInputed = true;
            } else if (alreadyInputed == true) {
                invUI.SetActive(false);
                alreadyInputed = false;
            }
        }
    }
}
