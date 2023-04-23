using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
public class PlayerSkins : MonoBehaviour {
  [Header("Initialization")]
  public Transform visualStatesParent;

  public void Dress (DressableData data) {
    foreach (Transform child in visualStatesParent) {
      child.GetComponent<VisualState>().Dress(data);
    }
  }
}
}
