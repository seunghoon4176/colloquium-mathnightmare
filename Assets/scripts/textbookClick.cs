using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textbookClick : MonoBehaviour
{
    public void enableClick() {
        PlayerPrefs.SetInt("clicked", 1);
    }

    public void disableClick() {
        PlayerPrefs.SetInt("clicked", 0);
    }
}
