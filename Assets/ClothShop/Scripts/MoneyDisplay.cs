using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class MoneyDisplay : MonoBehaviour {
  [Header("Initialization")]
  public Animator animator;
  public TextMeshProUGUI moneyLabel;

  void OnEnable () {
    TemporalMoneyManager.onChange += HandleMoneyChange;
    TemporalMoneyManager.onNotEnoughMoney += HandleBroke;
    moneyLabel.text = TemporalMoneyManager.Money.ToString();
  }

  void OnDisable () {
    TemporalMoneyManager.onChange -= HandleMoneyChange;
    TemporalMoneyManager.onNotEnoughMoney -= HandleBroke;
  }

  public void HandleMoneyChange (int money) {
    animator.SetTrigger("change");
    moneyLabel.text = money.ToString();
  }

  public void HandleBroke () {
    animator.SetTrigger("broke");
  }
}
