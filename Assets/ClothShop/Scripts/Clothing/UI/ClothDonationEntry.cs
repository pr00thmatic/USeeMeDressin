using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ClothDonationEntry : ClothForSaleEntry {
  public override ClothForSaleEntry Display (DressableData itemData) {
    base.Display(itemData);
    this.priceLabel.text = itemData.sellPrice.ToString();
    return this;
  }

  public override void Buy () {
    GetComponentInParent<ItemsForSale>().Donate(this);
  }
}
}
