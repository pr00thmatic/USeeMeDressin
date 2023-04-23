using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  [Header("Configuration")]
  public float speed = 8;

  [Header("Information")]
  public Vector2 desiredVelocity;
  public Vector2 viewDirection;

  [Header("Initialization")]
  public Rigidbody2D body;

  void FixedUpdate () {
    desiredVelocity = Controls.Motion.Walk.ReadValue<Vector2>() * speed;
    body.MovePosition((Vector2) transform.position + Time.fixedDeltaTime * desiredVelocity);
    UpdateViewDirection();
  }

  public void UpdateViewDirection () {
    if (desiredVelocity.magnitude < 0.1f) {
      viewDirection = Vector2.zero;
    } else if (Mathf.Abs(desiredVelocity.x) > Mathf.Abs(desiredVelocity.y)) {
      viewDirection = Mathf.Sign(desiredVelocity.x) * Vector2.right;
    } else {
      viewDirection = Mathf.Sign(desiredVelocity.y) * Vector2.up;
    }
  }
}
