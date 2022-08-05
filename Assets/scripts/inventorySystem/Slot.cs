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

    // Item 클래스를 _item에 실체화함. (아이템 이름과 이미지를 변수로 가짐)
    private Item _item;

    // 프로퍼티로 item 읽기/쓰기 접근
    // 프로퍼티 사용 이유는, 데이터를 수정할 수는 없지만 참조할 수는 있도록 하고 싶을 때 get만 정의해준다던가,
    // set의 범위를 지정하여 아무 값이나 대입할 수 없도록 제한한다던가, ...
    // 이처럼 읽기와 쓰기에 능동적인 제한을 걸 때 사용한다고 볼 수 있다.
    // 프로퍼티의 정의는 값 대입과 동시에 일어날 수도 있지만, 기본형은 그렇지 않다.
    // 호출되었을 때, 값이 대입되었을 때 어떻게 처리할 것인가를 프로퍼티의 정의에서 진행하는 것이다.
    public Item item {
        get { return _item; } // item을 호출하면 _item을 보냄
        set { // item에 값을 주면 _item에 item으로 받은 값을 대입하고, 그 값이 null인지 확인하여 맞다면 투명화, 아니라면 불투명화함.
            // 다시 말해, 아이템이 존재하면 표시하고 존재하지 않으면 표시하지 않는다.
            _item = value;
            if (_item != null) {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            } else {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

    // 결과적으로 item에는 null 혹은 다른 무언가가 대입되며, 이는 투명화와 불투명화를 결정하는 것으로 보임.
}