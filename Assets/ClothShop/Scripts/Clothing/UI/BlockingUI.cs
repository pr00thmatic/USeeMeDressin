using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockingUI : MonoBehaviour {
  void OnEnable () {
    Controls.Motion.Disable();
    Controls.Interactions.Disable();
  }

  void OnDisable () {
    Controls.Motion.Enable();
    Controls.Interactions.Enable();
  }
}
