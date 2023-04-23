using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
public class VisualState : MonoBehaviour {
  // new clothSkinTargets shouldn't be added at runtime unless you modify this script
  // to update their skin targets each time they are added.
  public Dictionary<Slot, SlotRenderer> slots;

  public void UpdateSkinTargets () {
    slots = new Dictionary<Slot, SlotRenderer>();

    SlotRenderer[] foundSlots = GetComponentsInChildren<SlotRenderer>(true);
    foreach (SlotRenderer slot in foundSlots) {
      slots[slot.whatDresses] = slot;
    }
  }

  public void Dress (DressableData data) {
    foreach (ViewDefinition view in data.views) {
      slots[view.target].displayTarget.sprite = view.skin;
    }
  }
}
}
