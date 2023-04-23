using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
public class TestDresser : MonoBehaviour {
  [Header("Initialization")]
  public ForSaleItem test;
  public PlayerSkins player;

  public void Test () {
    player.Dress(test.data);
  }

  public void Undress () {
    player.Remove();
  }
}
}
