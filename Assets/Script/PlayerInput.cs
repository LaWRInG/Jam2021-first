// GENERATED AUTOMATICALLY FROM 'Assets/Script/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""fa836470-f937-4ab1-8457-0586ffb309ac"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""38192fd3-2519-47f2-b7eb-971589908311"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""dd27f3df-6560-467c-8cfe-e0953d366b2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""attackL"",
                    ""type"": ""Button"",
                    ""id"": ""4c225483-03db-4666-98fa-41ce8e56ce15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""attackR"",
                    ""type"": ""Button"",
                    ""id"": ""97e69c77-12f8-4f98-a982-ed6ac456bf9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77ec416a-6881-44ce-ae7a-ffd013407174"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7d684e0-4ac4-4bde-a5e0-b638727aa982"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attackL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78a85d41-ee89-4b37-b4fd-dbfc05c78233"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attackR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c2d9697c-f88e-4f43-b0f7-da3bb87529ce"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ac2b76e0-e875-411c-85cc-38b59bcd034c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""999f85f0-cd41-4047-9de5-08efb08c2001"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dc7df836-dbd8-4783-bacd-bc09d3ec973a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b2cd6b7-3a8f-4c9b-a737-c3be8ce7cc90"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Swicth"",
            ""id"": ""e826c36a-157c-4934-ae27-843b65c5344b"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""a561946a-71f6-4567-9ec1-7155acd96d7d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""bce14575-219d-4b75-b6cd-87fbc653db4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""attackL"",
                    ""type"": ""Button"",
                    ""id"": ""01d4665b-5128-47fa-b915-560fab49fafc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""attackR"",
                    ""type"": ""Button"",
                    ""id"": ""55b048d1-d25b-4161-91f1-f73e672c9b4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c611a7bb-6e62-4056-95ff-99c839bc14e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""65cbe113-80a8-46e5-b847-4490c6ba42c2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""861ee870-8615-4622-ade8-53dde174d4be"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""89524e84-99a1-47af-995d-1ddd4a2e9641"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""114575e7-56a0-49a4-bb67-5dad5435d5b6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a479b648-40d9-4eb6-a4aa-868b551abf76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attackR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca5a2087-442f-48e7-a6dd-75582abdd800"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attackL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67336d69-5916-4748-86d3-d38fffbee7ac"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_move = m_Normal.FindAction("move", throwIfNotFound: true);
        m_Normal_jump = m_Normal.FindAction("jump", throwIfNotFound: true);
        m_Normal_attackL = m_Normal.FindAction("attackL", throwIfNotFound: true);
        m_Normal_attackR = m_Normal.FindAction("attackR", throwIfNotFound: true);
        // Swicth
        m_Swicth = asset.FindActionMap("Swicth", throwIfNotFound: true);
        m_Swicth_move = m_Swicth.FindAction("move", throwIfNotFound: true);
        m_Swicth_jump = m_Swicth.FindAction("jump", throwIfNotFound: true);
        m_Swicth_attackL = m_Swicth.FindAction("attackL", throwIfNotFound: true);
        m_Swicth_attackR = m_Swicth.FindAction("attackR", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_move;
    private readonly InputAction m_Normal_jump;
    private readonly InputAction m_Normal_attackL;
    private readonly InputAction m_Normal_attackR;
    public struct NormalActions
    {
        private @PlayerInputAction m_Wrapper;
        public NormalActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Normal_move;
        public InputAction @jump => m_Wrapper.m_Normal_jump;
        public InputAction @attackL => m_Wrapper.m_Normal_attackL;
        public InputAction @attackR => m_Wrapper.m_Normal_attackR;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @attackL.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackL;
                @attackL.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackL;
                @attackL.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackL;
                @attackR.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackR;
                @attackR.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackR;
                @attackR.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttackR;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @attackL.started += instance.OnAttackL;
                @attackL.performed += instance.OnAttackL;
                @attackL.canceled += instance.OnAttackL;
                @attackR.started += instance.OnAttackR;
                @attackR.performed += instance.OnAttackR;
                @attackR.canceled += instance.OnAttackR;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);

    // Swicth
    private readonly InputActionMap m_Swicth;
    private ISwicthActions m_SwicthActionsCallbackInterface;
    private readonly InputAction m_Swicth_move;
    private readonly InputAction m_Swicth_jump;
    private readonly InputAction m_Swicth_attackL;
    private readonly InputAction m_Swicth_attackR;
    public struct SwicthActions
    {
        private @PlayerInputAction m_Wrapper;
        public SwicthActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Swicth_move;
        public InputAction @jump => m_Wrapper.m_Swicth_jump;
        public InputAction @attackL => m_Wrapper.m_Swicth_attackL;
        public InputAction @attackR => m_Wrapper.m_Swicth_attackR;
        public InputActionMap Get() { return m_Wrapper.m_Swicth; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SwicthActions set) { return set.Get(); }
        public void SetCallbacks(ISwicthActions instance)
        {
            if (m_Wrapper.m_SwicthActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_SwicthActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_SwicthActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_SwicthActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_SwicthActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_SwicthActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_SwicthActionsCallbackInterface.OnJump;
                @attackL.started -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackL;
                @attackL.performed -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackL;
                @attackL.canceled -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackL;
                @attackR.started -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackR;
                @attackR.performed -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackR;
                @attackR.canceled -= m_Wrapper.m_SwicthActionsCallbackInterface.OnAttackR;
            }
            m_Wrapper.m_SwicthActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @attackL.started += instance.OnAttackL;
                @attackL.performed += instance.OnAttackL;
                @attackL.canceled += instance.OnAttackL;
                @attackR.started += instance.OnAttackR;
                @attackR.performed += instance.OnAttackR;
                @attackR.canceled += instance.OnAttackR;
            }
        }
    }
    public SwicthActions @Swicth => new SwicthActions(this);
    public interface INormalActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttackL(InputAction.CallbackContext context);
        void OnAttackR(InputAction.CallbackContext context);
    }
    public interface ISwicthActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttackL(InputAction.CallbackContext context);
        void OnAttackR(InputAction.CallbackContext context);
    }
}
