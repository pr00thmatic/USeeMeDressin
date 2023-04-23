using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
[System.Serializable]
public class DressableData {
  public ViewDefinition[] views;
  public int sellPrice = 4;
  // this can be turned into a getter if the price is calculated by the buyPrice
  public int buyPrice = 5;
  public string name;
  public Sprite icon;
}
}
