using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace Clothing.UI {
public class ItemsForSale : MonoBehaviour {
  public event System.Action onClose;

  [Header("Configuration")]
  public string resourcesPath = "Cloth";

  [Header("Information")]
  public Vector2 navigation;
  public float timestampIdle = 0;
  public int orientation = 0;
  public GameObject client;

  [Header("Initialization")]
  public ClothForSaleEntry entryPrototype;
  public ListWithSelectables forSale;
  public ListWithSelectables toDonate;
  public Transform root;

  void OnEnable () {
    ReadEntriesFroResources();
    Controls.Motion.Disable();
    Controls.Interactions.Disable();
  }

  void OnDisable () {
    onClose?.Invoke();
    Controls.Motion.Enable();
    Controls.Interactions.Enable();
  }

  public void Buy (ClothForSaleEntry bought) {
    client.GetComponentInParent<PlayerReferences>().skin.Dress(bought.data);
    Close();
  }

  public void Donate (ClothDonationEntry donated) {
    client.GetComponentInParent<PlayerReferences>().skin.Remove(donated.data);
  }

  public void ReadEntriesFroResources () {
    forSale.Clear();
    toDonate.Clear();

    ForSaleItem[] availableItems = Resources.LoadAll<ForSaleItem>(resourcesPath);
    foreach (ForSaleItem item in availableItems) {
      ClothForSaleEntry entry = Instantiate(entryPrototype).Display(item.data);
      entry.transform.SetParent(forSale.entriesParent);
    }
  }

  // TODO: add animationz
  public void Close () {
    root.gameObject.SetActive(false);
  }
}
}
