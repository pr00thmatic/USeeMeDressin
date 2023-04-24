using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ClothingSlot : MonoBehaviour {
  [Header("Initialization")]
  public Image icon;
  public BodySlot bodySlot;
  // TODO: inventory owner shouldn't be hardcoded? if we wanna keep supporting local coop
  public PlayerSkins inventoryOwner;

  [Header("Information")]
  public DressableData clothData;

  void OnEnable () {
    UpdateSlot();
  }

  public void Delete () {
    if (clothData.icon == null) return;
    inventoryOwner.Remove(bodySlot);
    UpdateSlot();
  }

  public void UpdateSlot () {
    clothData = inventoryOwner.GetClothAt(bodySlot);
    icon.sprite = clothData.icon;
    icon.color = clothData.icon? Color.white: new Color(1,1,1, 0);
  }
}
}
