using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageVisibility : MonoBehaviour
{  
    void Update() {
        GameObject goImage = GameObject.Find("Canvas/Image");
        Color color = goImage.GetComponent<Image>().color;
        if (PlayerPrefs.GetInt("clicked") == 1) {
                color.a = 1f;
                goImage.GetComponent<Image>().color = color;
        } else if (PlayerPrefs.GetInt("clicked") == 0) {
                color.a = 0f;
                goImage.GetComponent<Image>().color = color;
        }
        
    }
}