using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class Interactive : MonoBehaviour {
  public UnityEvent onFocus;
  public UnityEvent onUnfocus;
  public UnityEvent onInteractionTriggered;

  [Header("Configuration")]
  public bool isInteractive = true;

  [Header("Information")]
  public bool isFocused = false;

  void OnEnable () {
    onUnfocus.Invoke();
  }

  public void Focus () {
    if (isFocused || !isInteractive) return;

    isFocused = true;
    onFocus.Invoke();
  }

  public void Unfocus () {
    if (!isFocused) return;

    isFocused = false;
    onUnfocus.Invoke();
  }

  public void Interact () {
    if (isInteractive) return;
    onInteractionTriggered?.Invoke();
  }
}
