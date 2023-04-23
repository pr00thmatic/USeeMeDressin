using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAnimations : MonoBehaviour {
  [Header("Information")]
  public float speed;

  [Header("Initialization")]
  public PlayerMotion motion;
  public PlayerDirectionState front;
  public PlayerDirectionState side;
  public PlayerDirectionState back;

  void Update () {
    UpdateDirectionState();
  }

  void UpdateDirectionState () {
    if (motion.viewDirection == Vector2.zero) return;

    if (Mathf.Abs(motion.viewDirection.y) > Mathf.Abs(motion.viewDirection.x)) {
      (motion.viewDirection.y > 0? back: front).Activate();
    } else {
      side.Activate();
      side.transform.localScale = new Vector2(Mathf.Sign(motion.viewDirection.x), 1);
    }
  }
}
