using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ListWithSelectables : MonoBehaviour {
  [Header("Information")]
  public int selected = 0;
  public ClothForSaleEntry Selected { get => entriesParent.GetChild(selected).GetComponent<ClothForSaleEntry>(); }

  [Header("Initialization")]
  public Transform entriesParent;

  void OnEnable () {
    selected = 0;
  }

  public void UpdateSelection (ClothForSaleEntry newSelection) {
    Selected.animator.SetBool("isSelected", false);
    selected = newSelection.transform.GetSiblingIndex();
    Selected.animator.SetBool("isSelected", true);
  }

  public void Clear () {
    for (int i = entriesParent.childCount-1; i>=0; i--) {
      Destroy(entriesParent.GetChild(i).gameObject);
    }
  }

  // TODO: implement controls for navigating the menu with keyboard and gamepad
  // void Update () {
  //   navigation = Controls.Motion.MenuNavigation.ReadValue<Vector2>();

  //   if (Mathf.Sign(navigation.y) != orientation) {
  //     timestampIdle = Time.time;
  //     if (Mathf.Abs(navigation.y) > 0.2f) {
  //       selected = (entriesParent.childCount + (orientation + selected)) % entriesParent.childCount;
  //     }
  //   }
  // }

  // public void ScrollWithKeys () {
  // }
}
}
