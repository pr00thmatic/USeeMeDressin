using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  [Header("Configuration")]
  public float speed = 8;

  [Header("Information")]
  public Vector2 desiredDeltaMovement;

  [Header("Initialization")]
  public Rigidbody2D body;

  void FixedUpdate () {
    desiredDeltaMovement = Controls.Motion.Walk.ReadValue<Vector2>() * Time.fixedDeltaTime * speed;
    body.MovePosition((Vector2) transform.position + desiredDeltaMovement);
  }
}
