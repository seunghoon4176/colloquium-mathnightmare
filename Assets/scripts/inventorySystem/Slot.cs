using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    // SerializeField -> 인스펙터에서만 접근 가능하도록 할 때 사용.
    // public을 사용하면 인스펙터와 다른 스크립트가 모두 접근 가능함.
    // 스크립트에서는 접근을 못하지만 인스펙터에서는 접근 가능하게 할 때 SerializeField를 사용하며, 변수 앞에 대괄호로 적음.
    [SerializeField] Image image;

    private Item _item;
    public Item item {
        get { return _item; }
        set {
            _item = value;
            if (_item != null) {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            } else {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}