using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class TemporalMoneyManager {
  public static event System.Action onNotEnoughMoney;
  public static event System.Action<int> onChange;

  public static int Money { get => money; set => money = Mathf.Max(0, value); }
  static int money = 100;

  public static bool CanSpend (int amount) {
    bool enough = amount <= Money;
    if (!enough) onNotEnoughMoney?.Invoke();
    return enough;
  }

  public static void Spend (int amount) {
    Money -= amount;
    onChange?.Invoke(Money);
  }

  public static void AddMoney (int amount) {
    Money += amount;
    onChange?.Invoke(Money);
  }
}
