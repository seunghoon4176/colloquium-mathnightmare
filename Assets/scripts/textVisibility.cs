using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textVisibility : MonoBehaviour
{
    public Text ment;

    void Start() {
        ment.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            ment.text = "Click ↑";
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") {
            ment.text = "";
        }
    }
}
