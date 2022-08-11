using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincameraMovement : MonoBehaviour
{
    public Transform target;

    public void CameraSetPosition()
    {
        Debug.Log("ㅇㅅㅇ");
        transform.position = new Vector2(target.position.x, target.position.y - 3000);
    }
}
