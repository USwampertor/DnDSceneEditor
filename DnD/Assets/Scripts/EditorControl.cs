// GENERATED AUTOMATICALLY FROM 'Assets/EditorControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @EditorControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @EditorControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EditorControl"",
    ""maps"": [
        {
            ""name"": ""EditorMapCamera"",
            ""id"": ""dec71066-3568-4ab2-8a35-6ce1621f7a28"",
            ""actions"": [
                {
                    ""name"": ""Truck"",
                    ""type"": ""Value"",
                    ""id"": ""b800b224-900a-4880-920f-138e64f0a68d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boom"",
                    ""type"": ""Value"",
                    ""id"": ""5eef9ff7-2065-4a9b-917e-d8c0f1c376e6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dolly"",
                    ""type"": ""Value"",
                    ""id"": ""1e58680e-7be4-4f87-95f1-413e8766f7c4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartMovement"",
                    ""type"": ""Button"",
                    ""id"": ""ecbb53f6-e8ac-4f0d-8f18-fce1ae3e0e82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""6b51aa29-f3cd-4b44-a068-e956e7e9de79"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b2b5c60-97ae-43ff-ad0a-806b884987ac"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""StartMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fc1d461-3291-4566-8ac5-4f367bf35ac4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""d9df4d52-e94b-46ae-8bd4-bae3d8554cb0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Truck"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a89024de-6e66-4c30-b02f-dafa10366e28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Truck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8a3da5b3-a7fe-4f4a-9715-e763f260f165"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Truck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""a51060a2-3ece-423c-a37f-4821be787377"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7bb08733-a5d5-407d-b15f-20508dce6764"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Boom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ebb7d27e-d59c-4ab0-abe1-3fa337339373"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Boom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""ac644edb-1206-4c2f-99d1-a2e430c9488c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dolly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ad9ae10f-b0ee-4512-b802-7149dcf774ed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Dolly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9babdd14-d5a9-4d0f-95c4-fcc206c92785"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""Dolly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""EditorMapActions"",
            ""id"": ""edaec9f9-d7f1-489e-9692-88fa34c655b0"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""b5e61bfe-c659-4797-95f2-39b0d46f010a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMovement"",
                    ""type"": ""Value"",
                    ""id"": ""9248a8ab-18eb-4a3b-8b04-4fb4cc4bc536"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b9a1cc7-974b-4311-a23a-996145bab654"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba52d761-291e-4afd-8612-d3724521aab3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard/Mouse"",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard/Mouse"",
            ""bindingGroup"": ""KeyBoard/Mouse"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // EditorMapCamera
        m_EditorMapCamera = asset.FindActionMap("EditorMapCamera", throwIfNotFound: true);
        m_EditorMapCamera_Truck = m_EditorMapCamera.FindAction("Truck", throwIfNotFound: true);
        m_EditorMapCamera_Boom = m_EditorMapCamera.FindAction("Boom", throwIfNotFound: true);
        m_EditorMapCamera_Dolly = m_EditorMapCamera.FindAction("Dolly", throwIfNotFound: true);
        m_EditorMapCamera_StartMovement = m_EditorMapCamera.FindAction("StartMovement", throwIfNotFound: true);
        m_EditorMapCamera_Rotation = m_EditorMapCamera.FindAction("Rotation", throwIfNotFound: true);
        // EditorMapActions
        m_EditorMapActions = asset.FindActionMap("EditorMapActions", throwIfNotFound: true);
        m_EditorMapActions_LeftClick = m_EditorMapActions.FindAction("LeftClick", throwIfNotFound: true);
        m_EditorMapActions_MouseMovement = m_EditorMapActions.FindAction("MouseMovement", throwIfNotFound: true);
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

    // EditorMapCamera
    private readonly InputActionMap m_EditorMapCamera;
    private IEditorMapCameraActions m_EditorMapCameraActionsCallbackInterface;
    private readonly InputAction m_EditorMapCamera_Truck;
    private readonly InputAction m_EditorMapCamera_Boom;
    private readonly InputAction m_EditorMapCamera_Dolly;
    private readonly InputAction m_EditorMapCamera_StartMovement;
    private readonly InputAction m_EditorMapCamera_Rotation;
    public struct EditorMapCameraActions
    {
        private @EditorControl m_Wrapper;
        public EditorMapCameraActions(@EditorControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Truck => m_Wrapper.m_EditorMapCamera_Truck;
        public InputAction @Boom => m_Wrapper.m_EditorMapCamera_Boom;
        public InputAction @Dolly => m_Wrapper.m_EditorMapCamera_Dolly;
        public InputAction @StartMovement => m_Wrapper.m_EditorMapCamera_StartMovement;
        public InputAction @Rotation => m_Wrapper.m_EditorMapCamera_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_EditorMapCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorMapCameraActions set) { return set.Get(); }
        public void SetCallbacks(IEditorMapCameraActions instance)
        {
            if (m_Wrapper.m_EditorMapCameraActionsCallbackInterface != null)
            {
                @Truck.started -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnTruck;
                @Truck.performed -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnTruck;
                @Truck.canceled -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnTruck;
                @Boom.started -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnBoom;
                @Boom.performed -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnBoom;
                @Boom.canceled -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnBoom;
                @Dolly.started -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnDolly;
                @Dolly.performed -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnDolly;
                @Dolly.canceled -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnDolly;
                @StartMovement.started -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnStartMovement;
                @StartMovement.performed -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnStartMovement;
                @StartMovement.canceled -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnStartMovement;
                @Rotation.started -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_EditorMapCameraActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_EditorMapCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Truck.started += instance.OnTruck;
                @Truck.performed += instance.OnTruck;
                @Truck.canceled += instance.OnTruck;
                @Boom.started += instance.OnBoom;
                @Boom.performed += instance.OnBoom;
                @Boom.canceled += instance.OnBoom;
                @Dolly.started += instance.OnDolly;
                @Dolly.performed += instance.OnDolly;
                @Dolly.canceled += instance.OnDolly;
                @StartMovement.started += instance.OnStartMovement;
                @StartMovement.performed += instance.OnStartMovement;
                @StartMovement.canceled += instance.OnStartMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public EditorMapCameraActions @EditorMapCamera => new EditorMapCameraActions(this);

    // EditorMapActions
    private readonly InputActionMap m_EditorMapActions;
    private IEditorMapActionsActions m_EditorMapActionsActionsCallbackInterface;
    private readonly InputAction m_EditorMapActions_LeftClick;
    private readonly InputAction m_EditorMapActions_MouseMovement;
    public struct EditorMapActionsActions
    {
        private @EditorControl m_Wrapper;
        public EditorMapActionsActions(@EditorControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_EditorMapActions_LeftClick;
        public InputAction @MouseMovement => m_Wrapper.m_EditorMapActions_MouseMovement;
        public InputActionMap Get() { return m_Wrapper.m_EditorMapActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorMapActionsActions set) { return set.Get(); }
        public void SetCallbacks(IEditorMapActionsActions instance)
        {
            if (m_Wrapper.m_EditorMapActionsActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnLeftClick;
                @MouseMovement.started -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.performed -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.canceled -= m_Wrapper.m_EditorMapActionsActionsCallbackInterface.OnMouseMovement;
            }
            m_Wrapper.m_EditorMapActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @MouseMovement.started += instance.OnMouseMovement;
                @MouseMovement.performed += instance.OnMouseMovement;
                @MouseMovement.canceled += instance.OnMouseMovement;
            }
        }
    }
    public EditorMapActionsActions @EditorMapActions => new EditorMapActionsActions(this);
    private int m_KeyBoardMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardMouseScheme
    {
        get
        {
            if (m_KeyBoardMouseSchemeIndex == -1) m_KeyBoardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard/Mouse");
            return asset.controlSchemes[m_KeyBoardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IEditorMapCameraActions
    {
        void OnTruck(InputAction.CallbackContext context);
        void OnBoom(InputAction.CallbackContext context);
        void OnDolly(InputAction.CallbackContext context);
        void OnStartMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IEditorMapActionsActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnMouseMovement(InputAction.CallbackContext context);
    }
}
