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
  public ClothDonationEntry donationEntryPrototype;
  public ListWithSelectables forSale;
  public ListWithSelectables toDonate;
  public Transform root;

  void OnEnable () {
    LoadEntries();
  }

  void OnDisable () {
    onClose?.Invoke();
  }

  public void Buy (ClothForSaleEntry bought) {
    client.GetComponentInParent<PlayerReferences>().skin.Dress(bought.data);
    Close();
  }

  public void Donate (ClothDonationEntry donated) {
    client.GetComponentInParent<PlayerReferences>().skin.Remove(donated.data);
    Close();
  }

  public void LoadEntries () {
    forSale.Clear();
    toDonate.Clear();

    ForSaleItem[] availableItems = Resources.LoadAll<ForSaleItem>(resourcesPath);
    foreach (ForSaleItem item in availableItems) {
      ClothForSaleEntry entry = Instantiate(entryPrototype).Display(item.data);
      entry.transform.SetParent(forSale.entriesParent);
    }

    PlayerSkins skin = client.GetComponentInParent<PlayerReferences>().skin;
    List<DressableData> wearing = skin.wearing;
    foreach (DressableData cloth in wearing) {
      ClothDonationEntry entry = Instantiate(donationEntryPrototype).Display(cloth) as ClothDonationEntry;
      entry.transform.SetParent(toDonate.entriesParent);
    }
  }

  // TODO: add animationz
  public void Close () {
    root.gameObject.SetActive(false);
  }
}
}
