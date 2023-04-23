using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Clothing.UI;

namespace Clothing {
public class ShopCheckout : MonoBehaviour {
  [Header("Initialization")]
  public ItemsForSale shopUI;
  public Interactive interactive;

  void OnEnable () {
    interactive.onInteractionTriggered.AddListener(OpenShopUI);
  }

  void OnDisable () {
    interactive.onInteractionTriggered.RemoveListener(OpenShopUI);
  }

  public void OpenShopUI () {
    shopUI.gameObject.SetActive(true);
  }
}
}
