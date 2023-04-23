using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ClothDonationEntry : ClothForSaleEntry {
  public override void Buy () {
    GetComponentInParent<ItemsForSale>().Donate(this);
  }
}
}
