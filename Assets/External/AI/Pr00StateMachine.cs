using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr00StateMachine : MonoBehaviour {
  public event System.Action<Pr00State> onStateChange;

  void OnEnable () {
    foreach (Transform child in transform) {
      Pr00State childState = child.GetComponent<Pr00State>();
      if (childState) {
        childState.onExit += HandleStateChange;
      }
    }
  }

  public T GetState<T> () where T: MonoBehaviour {
    foreach (Transform child in transform) {
      T childState = child.GetComponent<T>();
      if (childState) {
        return childState;
      }
    }
    return null;
  }

  public T SetState<T> () where T: MonoBehaviour {
    foreach (Transform child in transform) {
      T childState = child.GetComponent<T>();
      if (childState) {
        if (!childState.gameObject.activeInHierarchy) {
          childState.gameObject.SetActive(true);
        }
        gameObject.SetActive(true);
        return childState;
      }
    }
    return null;
  }

  public Pr00State SetState (Pr00State state) {
    foreach (Transform child in transform) {
      if (child.GetComponent<Pr00State>() == state) {
        child.gameObject.SetActive(true);
        return child.GetComponent<Pr00State>();
      }
    }

    return null;
  }

  public bool IsActive<T> () where T: MonoBehaviour {
    foreach (Transform child in transform) {
      if (child.GetComponent<T>()) {
        if (child.gameObject.activeSelf) return true;
        return false;
      }
    }

    return false;
  }

  public GameObject SetState (int index) {
    GameObject found = transform.GetChild(index).gameObject;
    found.SetActive(true);
    return found;
  }

  public void HandleStateChange (Pr00State state) {
    if (gameObject && gameObject.activeInHierarchy) {
      onStateChange?.Invoke(state);
    }
  }

  public Pr00State GetCurrentState () {
    foreach (Transform child in transform) {
      Pr00State state = child.GetComponent<Pr00State>();
      if (state.gameObject.activeSelf) return state;
    }
    return null;
  }
}
