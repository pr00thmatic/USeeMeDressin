using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInteractor : MonoBehaviour {
  [Header("Configuration")]
  public LayerMask interactionsAllowed;

  [Header("Information")]
  public RaycastHit2D hit;
  public Interactive focused;

  [Header("Initialization")]
  public Transform target;
  public PlayerMotion motion;

  void OnEnable () {
    // Controls.Interactions.Interact += HandleInteraction;
  }

  void Update () {
    if (motion.orthogonalViewDirection != Vector2.zero) target.parent.up = motion.orthogonalViewDirection;

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
}
