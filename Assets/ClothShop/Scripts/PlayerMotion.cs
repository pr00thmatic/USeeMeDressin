using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  [Header("Configuration")]
  public float speed = 8;

  [Header("Information")]
  public Vector2 desiredDeltaMovement;
  public Vector2 orthogonalViewDirection;

  [Header("Initialization")]
  public Rigidbody2D body;

  void FixedUpdate () {
    desiredDeltaMovement = Controls.Motion.Walk.ReadValue<Vector2>() * Time.fixedDeltaTime * speed;
    body.MovePosition((Vector2) transform.position + desiredDeltaMovement);
    UpdateViewDirection();
  }

  public void UpdateViewDirection () {
    if (desiredDeltaMovement.magnitude < 0.1f) {
      orthogonalViewDirection = Vector2.zero;
    } else if (Mathf.Abs(desiredDeltaMovement.x) > Mathf.Abs(desiredDeltaMovement.y)) {
      orthogonalViewDirection = Mathf.Sign(desiredDeltaMovement.x) * Vector2.right;
    } else {
      orthogonalViewDirection = Mathf.Sign(desiredDeltaMovement.y) * Vector2.up;
    }
  }
}
