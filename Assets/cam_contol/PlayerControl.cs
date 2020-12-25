// GENERATED AUTOMATICALLY FROM 'Assets/cam_contol/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""cam"",
            ""id"": ""f8762813-aefe-4bef-b16a-328b4c00b5c8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8ef58e97-9a37-4c38-9cc3-49a4a8de5daa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""bf4181a7-5c49-49d3-afba-5812a17ed400"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Front"",
                    ""type"": ""Button"",
                    ""id"": ""8b6e1efb-2c84-4aae-8ce8-02fe05e587cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""f2a393ec-eef4-44cf-95c3-a29aee1cc6e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67560e35-36f8-47fe-a7f0-74bb1bb36fb1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c966316-3191-46b8-b75f-8b8ea25fe828"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""480ee491-e301-4bf9-aa04-0255c2a728d4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Front"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de0672c9-3841-473e-acc4-140c01c09589"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // cam
        m_cam = asset.FindActionMap("cam", throwIfNotFound: true);
        m_cam_Move = m_cam.FindAction("Move", throwIfNotFound: true);
        m_cam_Look = m_cam.FindAction("Look", throwIfNotFound: true);
        m_cam_Front = m_cam.FindAction("Front", throwIfNotFound: true);
        m_cam_Back = m_cam.FindAction("Back", throwIfNotFound: true);
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

    // cam
    private readonly InputActionMap m_cam;
    private ICamActions m_CamActionsCallbackInterface;
    private readonly InputAction m_cam_Move;
    private readonly InputAction m_cam_Look;
    private readonly InputAction m_cam_Front;
    private readonly InputAction m_cam_Back;
    public struct CamActions
    {
        private @PlayerControl m_Wrapper;
        public CamActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_cam_Move;
        public InputAction @Look => m_Wrapper.m_cam_Look;
        public InputAction @Front => m_Wrapper.m_cam_Front;
        public InputAction @Back => m_Wrapper.m_cam_Back;
        public InputActionMap Get() { return m_Wrapper.m_cam; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamActions set) { return set.Get(); }
        public void SetCallbacks(ICamActions instance)
        {
            if (m_Wrapper.m_CamActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_CamActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnLook;
                @Front.started -= m_Wrapper.m_CamActionsCallbackInterface.OnFront;
                @Front.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnFront;
                @Front.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnFront;
                @Back.started -= m_Wrapper.m_CamActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_CamActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Front.started += instance.OnFront;
                @Front.performed += instance.OnFront;
                @Front.canceled += instance.OnFront;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public CamActions @cam => new CamActions(this);
    public interface ICamActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFront(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
