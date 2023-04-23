using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ItemsForSale : MonoBehaviour {
  public event System.Action onClose;

  [Header("Configuration")]
  public string resourcesPath = "Cloth";

  [Header("Information")]
  public int selected = 0;
  public ClothForSaleEntry Selected { get => entriesParent.GetChild(selected).GetComponent<ClothForSaleEntry>(); }
  public Vector2 navigation;
  public float timestampIdle = 0;
  public int orientation = 0;
  public GameObject client;

  [Header("Initialization")]
  public ClothForSaleEntry entryPrototype;
  public Transform entriesParent;
  public Transform root;

  void OnEnable () {
    ReadEntriesFroResources();
    Selected.animator.SetBool("isSelected", true);
    Controls.Motion.Disable();
    Controls.Interactions.Disable();
  }

  void OnDisable () {
    onClose?.Invoke();
    Controls.Motion.Enable();
    Controls.Interactions.Enable();
  }

  public void Buy (ClothForSaleEntry bought) {
    client.GetComponentInParent<PlayerReferences>().skin.Dress(bought.data);
    Close();
  }

  public void UpdateSelection (ClothForSaleEntry newSelection) {
    Selected.animator.SetBool("isSelected", false);
    selected = newSelection.transform.GetSiblingIndex();
    Selected.animator.SetBool("isSelected", true);
  }

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

  // TODO: add animationz
  public void Close () {
    root.gameObject.SetActive(false);
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
