using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ItemsForSale : MonoBehaviour {
  [Header("Configuration")]
  public string resourcesPath = "Cloth";

  [Header("Information")]
  public int selected = 0;
  public ClothForSaleEntry Selected { get => entriesParent.GetChild(selected).GetComponent<ClothForSaleEntry>(); }
  public Vector2 navigation;
  public float timestampIdle = 0;
  public int orientation = 0;

  [Header("Initialization")]
  public ClothForSaleEntry entryPrototype;
  public Transform entriesParent;

  void OnEnable () {
    ReadEntriesFroResources();
    Selected.animator.SetBool("isSelected", true);
  }

  public void UpdateSelection (ClothForSaleEntry newSelection) {
    Selected.animator.SetBool("isSelected", false);
    selected = newSelection.transform.GetSiblingIndex();
    Selected.animator.SetBool("isSelected", true);
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

  public void ReadEntriesFroResources () {
    Clear();
    ForSaleItem[] availableItems = Resources.LoadAll<ForSaleItem>(resourcesPath);
    foreach (ForSaleItem item in availableItems) {
      ClothForSaleEntry entry = Instantiate(entryPrototype).Display(item.data);
      entry.transform.SetParent(entriesParent);
    }
  }

  public void Clear () {
    for (int i = entriesParent.childCount-1; i>=0; i--) {
      Destroy(entriesParent.GetChild(i).gameObject);
    }
  }

  // public void ScrollWithKeys () {
  // }
}
}
