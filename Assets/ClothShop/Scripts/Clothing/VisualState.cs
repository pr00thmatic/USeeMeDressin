using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
public class VisualState : MonoBehaviour {
  [Header("Configuration")]
  public VisualSlot visualSlot;

  [Header("Information")]
  public SlotRenderer[] foundSlots;
  // new clothSkinTargets shouldn't be added at runtime unless you modify this script
  // to update their skin targets each time they are added.
  public Dictionary<Slot, SlotRenderer> slots;

  public void UpdateSkinTargets () {
    slots = new Dictionary<Slot, SlotRenderer>();

    foundSlots = GetComponentsInChildren<SlotRenderer>(true);
    foreach (SlotRenderer slot in foundSlots) {
      slots[slot.whatDresses] = slot;
    }
  }

  public void Dress (DressableData data) {
    if (slots == null) UpdateSkinTargets();
    foreach (ViewDefinition view in data.views) {
      if (view.visualSlot == visualSlot && slots.ContainsKey(view.target)) {
        slots[view.target].displayTarget.sprite = view.skin;
      }
    }
  }

  public void Remove (DressableData data) {
    if (slots == null) UpdateSkinTargets();
    foreach (ViewDefinition view in data.views) {
      if (view.visualSlot == visualSlot && slots.ContainsKey(view.target)) {
        slots[view.target].displayTarget.sprite = null;
      }
    }
  }

  public void Remove () {
    if (foundSlots == null) UpdateSkinTargets();
    foreach (SlotRenderer renderer in foundSlots) {
      renderer.displayTarget.sprite = null;
    }
  }
}
}
