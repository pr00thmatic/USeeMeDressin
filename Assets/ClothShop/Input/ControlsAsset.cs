//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/ClothShop/Input/ControlsAsset.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ControlsAsset : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlsAsset()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlsAsset"",
    ""maps"": [
        {
            ""name"": ""Motion"",
            ""id"": ""afc4cb3b-d011-473f-9292-32b4c7c42794"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""7a1c3ca0-1e38-41e6-b7cc-7335ec4107f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c933d884-ec80-44cf-88bc-3e1ee10327b7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e902c1e1-0bcc-4221-9fbb-9015add8c899"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a32d546a-a4d8-40b6-98f1-7fac6b02142b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e5d0072-28a7-4267-8c9f-f8d43bbba4a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""73337f7a-e0bc-4d10-b18b-e3c756da28a7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a56a69dc-9f4f-43e5-8309-d832f05ae614"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interactions"",
            ""id"": ""ed1233f6-7975-4518-8e67-f6f9811aff30"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""8f07ed12-d186-4455-bb9c-329d6b283cce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f352484e-3157-4bd5-ad72-3e89614ffff5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9cdf302-ea51-4d7f-9b62-7f825af840f9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Motion
        m_Motion = asset.FindActionMap("Motion", throwIfNotFound: true);
        m_Motion_Walk = m_Motion.FindAction("Walk", throwIfNotFound: true);
        // Interactions
        m_Interactions = asset.FindActionMap("Interactions", throwIfNotFound: true);
        m_Interactions_Interact = m_Interactions.FindAction("Interact", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Motion
    private readonly InputActionMap m_Motion;
    private IMotionActions m_MotionActionsCallbackInterface;
    private readonly InputAction m_Motion_Walk;
    public struct MotionActions
    {
        private @ControlsAsset m_Wrapper;
        public MotionActions(@ControlsAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Motion_Walk;
        public InputActionMap Get() { return m_Wrapper.m_Motion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MotionActions set) { return set.Get(); }
        public void SetCallbacks(IMotionActions instance)
        {
            if (m_Wrapper.m_MotionActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MotionActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MotionActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MotionActionsCallbackInterface.OnWalk;
            }
            m_Wrapper.m_MotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
            }
        }
    }
    public MotionActions @Motion => new MotionActions(this);

    // Interactions
    private readonly InputActionMap m_Interactions;
    private IInteractionsActions m_InteractionsActionsCallbackInterface;
    private readonly InputAction m_Interactions_Interact;
    public struct InteractionsActions
    {
        private @ControlsAsset m_Wrapper;
        public InteractionsActions(@ControlsAsset wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interactions_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Interactions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionsActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionsActions instance)
        {
            if (m_Wrapper.m_InteractionsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InteractionsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_InteractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public InteractionsActions @Interactions => new InteractionsActions(this);
    public interface IMotionActions
    {
        void OnWalk(InputAction.CallbackContext context);
    }
    public interface IInteractionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
}
