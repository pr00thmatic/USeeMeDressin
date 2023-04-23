using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

namespace Clothing.UI {
public class ClothForSaleEntry : MonoBehaviour {
  [Header("Initialization")]
  public Image icon;
  public TextMeshProUGUI nameLabel;
  public TextMeshProUGUI priceLabel;
  public DressableData data;
  public Animator animator;

  public ClothForSaleEntry Display (DressableData itemData) {
    data = itemData;
    this.icon.sprite = itemData.icon;
    this.nameLabel.text = itemData.name;
    this.priceLabel.text = itemData.buyPrice.ToString();

    return this;
  }

  public void UpdateSelection () {
    GetComponentInParent<ItemsForSale>().UpdateSelection(this);
  }
}
}
