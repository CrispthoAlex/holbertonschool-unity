// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayVR"",
            ""id"": ""38848a09-a51b-42cb-af46-b966b69b84a6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""c83d1683-2791-4b2b-b83c-7578a05ea9cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""255879a4-7259-4253-8d1d-3113f1de57f9"",
                    ""path"": ""<HID::Twin USB Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f30cebe7-57ed-4c87-97d0-8053a61e0d28"",
                    ""path"": ""<HID::Twin USB Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac6d31d4-e8e8-490d-a007-7833353bc40d"",
                    ""path"": ""<HID::Twin USB Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42ae45b2-ad2b-413c-aba4-2d588a98556d"",
                    ""path"": ""<HID::Twin USB Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayVR
        m_PlayVR = asset.FindActionMap("PlayVR", throwIfNotFound: true);
        m_PlayVR_Move = m_PlayVR.FindAction("Move", throwIfNotFound: true);
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

    // PlayVR
    private readonly InputActionMap m_PlayVR;
    private IPlayVRActions m_PlayVRActionsCallbackInterface;
    private readonly InputAction m_PlayVR_Move;
    public struct PlayVRActions
    {
        private @PlayerControls m_Wrapper;
        public PlayVRActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayVR_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayVR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayVRActions set) { return set.Get(); }
        public void SetCallbacks(IPlayVRActions instance)
        {
            if (m_Wrapper.m_PlayVRActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayVRActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayVRActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayVRActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayVRActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayVRActions @PlayVR => new PlayVRActions(this);
    public interface IPlayVRActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
