using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VisualState : MonoBehaviour {
  // new clothSkinTargets shouldn't be added at runtime unless you modify this script
  // to update their skin targets each time they are added.
  public Dictionary<ClothingTarget, ClothSkinTarget> skinTargets;

  public void UpdateSkinTargets () {
    skinTargets = new Dictionary<ClothingTarget, ClothSkinTarget>();

    ClothSkinTarget[] foundTargets = GetComponentsInChildren<ClothSkinTarget>(true);
    foreach (ClothSkinTarget found in foundTargets) {
      skinTargets[found.whatDresses] = found;
    }
  }

  public void Dress (ClothItem item) {
    foreach (ClothSkinPiece skinPiece in item.skinPieces) {
      skinTargets[skinPiece.target].displayTarget.sprite = skinPiece.skin;
    }
  }
}
