using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class ClothItem {
  public ClothSkinPiece[] skinPieces;
  public int sellPrice = 4;
  // this can be turned into a getter if the price is calculated by the buyPrice
  public int buyPrice = 5;
  public string name;
  public Sprite icon;
}
