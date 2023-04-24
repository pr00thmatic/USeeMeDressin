using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class CloseButton : MonoBehaviour {
  [Header("Initialization")]
  public GameObject menu;

  void OnEnable () {
    Controls.MenuActions.CloseMenu.performed += CloseMenu;
  }

  void OnDisable () {
    Controls.MenuActions.CloseMenu.performed += CloseMenu;
  }

  public void CloseMenu (InputAction.CallbackContext ctx) {
    CloseMenu();
  }

  public void CloseMenu () {
    menu.SetActive(false);
  }

}
