using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items; // 아이템형의 리스트, items 선언.

    [SerializeField] private Transform slotParent; // 에디터에서 직접 Bag를 담을 곳
    [SerializeField] private Slot[] slots;

    private void OnValidate() { // OnValidate: 유니티 에디터에서 바로 작동하는 함수임. 스크립트 실행이 전제되어야 하는 게 아님.
        // slots에 슬롯들 등록
        slots = slotParent.GetComponentsInChildren<Slot>();
    }

    void Awake() {
        // 스크립트 실행과 동시에 아래에 선언된 FreshSlot 함수 실행
        FreshSlot();
    }

    public void FreshSlot() {
        int i = 0;
        for (; i < items.Count && i < slots.Length; i++) {
            slots[i].item = items[i];
        }
        for (; i < slots.Length; i++) {
            slots[i].item = null;
        }
    }

    public void AddItem(Item _item) {
        if (items.Count < slots.Length) {
            items.Add(_item);
            FreshSlot();
        } else {
            print("슬롯이 가득 차 있습니다.");
        }
    }
}