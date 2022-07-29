using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toInvisible : MonoBehaviour
{
    public Text ment;

    // Start is called before the first frame update
    void Start()
    {
        ment.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("1231");
        ment.text = "Press Enter to read";
    }

    void OnTriggerExit2D(Collider2D other)
    {
        ment.text = "";
    }
}
