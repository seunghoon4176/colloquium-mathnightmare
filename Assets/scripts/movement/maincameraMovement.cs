using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincameraMovement : MonoBehaviour
{
    public GameObject panel;

    public void CameraDown()
    {
        GameObject obj = GameObject.Find("Main Camera");  
        if (obj.transform.position.y < 5304) {
            obj.transform.position = new Vector2(obj.transform.position.x, obj.transform.position.y + 2650);
        }
    }

    public void CameraUp()
    {
        GameObject obj = GameObject.Find("Main Camera");  
        if (obj.transform.position.y > 6) {
            obj.transform.position = new Vector2(obj.transform.position.x, obj.transform.position.y - 2650);
        }
    }
}
