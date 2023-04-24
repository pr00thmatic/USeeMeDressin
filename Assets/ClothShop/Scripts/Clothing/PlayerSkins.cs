using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
public class PlayerSkins : MonoBehaviour {
  [Header("Initialization")]
  public Transform visualStatesParent;

  // in the future each SlotRenderer could have an array of SpriteRenderers so
  // it can wear several clothing pieces
  [Header("Information")]
  public List<DressableData> wearing = new List<DressableData>();

  public void Dress (DressableData data) {
    foreach (DressableData cloth in wearing) {
      if (cloth.bodySlot == data.bodySlot) {
        Remove(cloth);
        break;
      }
    }
    foreach (Transform child in visualStatesParent) {
      child.GetComponent<VisualState>().Dress(data);
    }

    wearing.Add(data);
  }

  public DressableData GetClothAt (BodySlot bodySlot) {
    foreach (DressableData cloth in wearing) {
      if (cloth.bodySlot == bodySlot) {
        return cloth;
      }
    }

    return new DressableData();
  }

  public void Remove (BodySlot bodySlot) {
    foreach (DressableData cloth in wearing) {
      if (cloth.bodySlot == bodySlot) {
        Remove(cloth);
        break;
      }
    }
  }

  public void Remove (DressableData data) {
    foreach (Transform child in visualStatesParent) {
      child.GetComponent<VisualState>().Remove(data);
    }

    wearing.Remove(data);
  }

  public void Remove () {
    foreach (Transform child in visualStatesParent) {
      child.GetComponent<VisualState>().Remove();
    }

    wearing.Clear();
  }
}
}
