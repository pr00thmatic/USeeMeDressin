using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Clothing {
[CustomEditor(typeof(TestDresser))]
public class TestDresserEditor : Editor {
  TestDresser Target { get => (TestDresser) target; }

  public override void OnInspectorGUI () {
    DrawDefaultInspector();
    if (GUILayout.Button("Test clothing")) {
      Target.Test();
    }
    if (GUILayout.Button("Remove clothing")) {
      Target.Undress();
    }
  }
}
}
