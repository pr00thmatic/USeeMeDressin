using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class InventoryButton : MonoBehaviour {
  [Header("Initialization")]
  public GameObject inventoryUI;

  void OnEnable () {
    Controls.Interactions.OpenInventory.performed += OpenInventory;
  }

  void OnDisable () {
    Controls.Interactions.OpenInventory.performed -= OpenInventory;
  }

  public void OpenInventory (InputAction.CallbackContext ctx) {
    OpenInventory();
  }

  public void OpenInventory () {
    inventoryUI.SetActive(true);
  }
}
}
