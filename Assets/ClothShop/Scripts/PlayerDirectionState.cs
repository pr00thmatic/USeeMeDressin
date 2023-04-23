using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerDirectionState : MonoBehaviour {
  [Header("Initialization")]
  public Animator animator;
  public PlayerAnimations manager;

  void Reset () {
    animator = GetComponent<Animator>();
    manager = GetComponentInParent<PlayerAnimations>();
  }

  void Update () {
    animator.SetFloat("speed", manager.motion.desiredVelocity.magnitude);
  }

  public void Activate () {
    if (!gameObject.activeSelf) gameObject.SetActive(true);
  }
}
