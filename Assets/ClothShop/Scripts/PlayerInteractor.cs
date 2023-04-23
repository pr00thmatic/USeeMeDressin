using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerInteractor : MonoBehaviour {
  [Header("Configuration")]
  public LayerMask interactionsAllowed;

  [Header("Information")]
  public Interactive focused;
  public RaycastHit2D hit;

  [Header("Initialization")]
  public Transform target;
  public PlayerMotion motion;

  void OnEnable () {
    Controls.Interactions.Interact.performed += HandleInteraction;
  }

  void OnDisable () {
    Controls.Interactions.Interact.performed -= HandleInteraction;
  }

  void Update () {
    if (motion.viewDirection != Vector2.zero) target.parent.up = motion.viewDirection;

    // updates interactions focus
    hit = Physics2D.Raycast(transform.position, target.up,
                            target.localPosition.magnitude, interactionsAllowed);

    if (!hit.collider) {
      if (focused) focused.Unfocus();
      focused = null;
      return;
    }

    Interactive found = hit.collider.GetComponent<Interactive>();
    if (focused != found) found.Focus();
    focused = found;
  }

  public void HandleInteraction (InputAction.CallbackContext ctx) {
    if (!focused) return;
    focused.Interact();
  }
}
