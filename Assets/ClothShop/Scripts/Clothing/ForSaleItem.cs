using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Clothing {
[CreateAssetMenu(fileName = "ForSaleItem", menuName = "Clothing/ForSaleItem")]
public class ForSaleItem : ScriptableObject {
  public DressableData data;
}
}
