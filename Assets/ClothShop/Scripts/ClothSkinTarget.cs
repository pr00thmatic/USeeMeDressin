using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SpriteRenderer))]
public class ClothSkinTarget : MonoBehaviour {
  [Header("Configuration")]
  public ClothingTarget whatDresses;

  [Header("Information")]
  public SpriteRenderer parent;

  [Header("Initialization")]
  public SpriteRenderer displayTarget;

  void Reset () {
    System.Enum.TryParse(name, out whatDresses);
    displayTarget = GetComponent<SpriteRenderer>();
    parent = transform.parent.GetComponentInParent<SpriteRenderer>(true);
    displayTarget.sortingLayerName = parent.sortingLayerName;
    displayTarget.sortingOrder = parent.sortingOrder;
  }
}
