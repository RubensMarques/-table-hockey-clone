//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player actions"",
            ""id"": ""e74731c6-4b3a-497e-90ac-f47336d858c1"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""134a6978-90b3-4049-8e86-ed6b8d9847dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""xMove"",
                    ""type"": ""Value"",
                    ""id"": ""50b48ba5-fec6-480d-b719-962407ef25ac"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""yMove"",
                    ""type"": ""Value"",
                    ""id"": ""ec7ae65d-3904-462b-93d3-cbbf683ecddd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70ec20c4-bc1d-4187-9f89-3f599947d2a1"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""xGamepad"",
                    ""id"": ""d892f88d-c452-4dde-bb44-47d3ce8d1dba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""xMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""178b82c0-22e0-4bff-a0e6-646913cd2926"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""xMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""92e39ff5-9da6-4ed1-b526-19e0532eda5d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""xMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""yGamepad"",
                    ""id"": ""6840e1dc-fa71-42a5-a29e-17893654d0a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""yMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""48b195ca-0375-4409-88f1-a6db9fc1e4c6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""yMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ee110651-d061-4e6d-8c50-a78d02c46ed5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""yMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player actions
        m_Playeractions = asset.FindActionMap("Player actions", throwIfNotFound: true);
        m_Playeractions_jump = m_Playeractions.FindAction("jump", throwIfNotFound: true);
        m_Playeractions_xMove = m_Playeractions.FindAction("xMove", throwIfNotFound: true);
        m_Playeractions_yMove = m_Playeractions.FindAction("yMove", throwIfNotFound: true);
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

    // Player actions
    private readonly InputActionMap m_Playeractions;
    private IPlayeractionsActions m_PlayeractionsActionsCallbackInterface;
    private readonly InputAction m_Playeractions_jump;
    private readonly InputAction m_Playeractions_xMove;
    private readonly InputAction m_Playeractions_yMove;
    public struct PlayeractionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayeractionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Playeractions_jump;
        public InputAction @xMove => m_Wrapper.m_Playeractions_xMove;
        public InputAction @yMove => m_Wrapper.m_Playeractions_yMove;
        public InputActionMap Get() { return m_Wrapper.m_Playeractions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayeractionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayeractionsActions instance)
        {
            if (m_Wrapper.m_PlayeractionsActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnJump;
                @xMove.started -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnXMove;
                @xMove.performed -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnXMove;
                @xMove.canceled -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnXMove;
                @yMove.started -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnYMove;
                @yMove.performed -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnYMove;
                @yMove.canceled -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnYMove;
            }
            m_Wrapper.m_PlayeractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @xMove.started += instance.OnXMove;
                @xMove.performed += instance.OnXMove;
                @xMove.canceled += instance.OnXMove;
                @yMove.started += instance.OnYMove;
                @yMove.performed += instance.OnYMove;
                @yMove.canceled += instance.OnYMove;
            }
        }
    }
    public PlayeractionsActions @Playeractions => new PlayeractionsActions(this);
    public interface IPlayeractionsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnXMove(InputAction.CallbackContext context);
        void OnYMove(InputAction.CallbackContext context);
    }
}
