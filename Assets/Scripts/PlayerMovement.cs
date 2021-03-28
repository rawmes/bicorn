// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d69c480c-c658-4db4-97db-2f1d63ea28d6"",
            ""actions"": [
                {
                    ""name"": ""walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4262762c-684e-46ec-aec4-f7d001116876"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eb043f52-4032-4418-9dd7-194b41a1875d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfae4fd1-ff84-4d42-8f50-0f4eeb85e749"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c9c851f5-5c35-4d11-9a6c-34cf92bf3979"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""scroll/Y"",
                    ""type"": ""PassThrough"",
                    ""id"": ""061d9d91-ffa1-433d-ab80-8e1ec3377414"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b6f30321-5b1d-4567-b299-1ae0b98f4b67"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7777ad8c-5863-44ab-b5a0-83a1bacf149c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7a4e2ff4-0d97-4f6c-8aeb-5e956c76bf81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""85930eaf-0db4-43a8-8f81-230fd98b8297"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19724e48-6a89-4d15-b794-629cbc7c2147"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""119c9ce0-9a37-4eb2-994c-8d1cd83cabb6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15b51594-2bd7-41bb-b9d6-84731d4ebc77"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57e72352-7e5f-4785-bd38-53a856c041b7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa6036bf-2fbc-4445-beae-2ae0ebf6f2b5"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""scroll/Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UserInterface"",
            ""id"": ""6504fc9b-0311-43d2-b0d5-cb7227527f44"",
            ""actions"": [
                {
                    ""name"": ""cursorLock"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ecd8f3d6-2e0f-4152-a94d-44f4cdddc03f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38f38383-398a-4d5b-94f6-cbd01e40b8c6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""inclusive"",
                    ""action"": ""cursorLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""inclusive"",
            ""bindingGroup"": ""inclusive"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_walk = m_Movement.FindAction("walk", throwIfNotFound: true);
        m_Movement_look = m_Movement.FindAction("look", throwIfNotFound: true);
        m_Movement_jump = m_Movement.FindAction("jump", throwIfNotFound: true);
        m_Movement_run = m_Movement.FindAction("run", throwIfNotFound: true);
        m_Movement_scrollY = m_Movement.FindAction("scroll/Y", throwIfNotFound: true);
        // UserInterface
        m_UserInterface = asset.FindActionMap("UserInterface", throwIfNotFound: true);
        m_UserInterface_cursorLock = m_UserInterface.FindAction("cursorLock", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_walk;
    private readonly InputAction m_Movement_look;
    private readonly InputAction m_Movement_jump;
    private readonly InputAction m_Movement_run;
    private readonly InputAction m_Movement_scrollY;
    public struct MovementActions
    {
        private @PlayerMovement m_Wrapper;
        public MovementActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @walk => m_Wrapper.m_Movement_walk;
        public InputAction @look => m_Wrapper.m_Movement_look;
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputAction @run => m_Wrapper.m_Movement_run;
        public InputAction @scrollY => m_Wrapper.m_Movement_scrollY;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                @look.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @run.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @run.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @run.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @scrollY.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnScrollY;
                @scrollY.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnScrollY;
                @scrollY.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnScrollY;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @walk.started += instance.OnWalk;
                @walk.performed += instance.OnWalk;
                @walk.canceled += instance.OnWalk;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @run.started += instance.OnRun;
                @run.performed += instance.OnRun;
                @run.canceled += instance.OnRun;
                @scrollY.started += instance.OnScrollY;
                @scrollY.performed += instance.OnScrollY;
                @scrollY.canceled += instance.OnScrollY;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // UserInterface
    private readonly InputActionMap m_UserInterface;
    private IUserInterfaceActions m_UserInterfaceActionsCallbackInterface;
    private readonly InputAction m_UserInterface_cursorLock;
    public struct UserInterfaceActions
    {
        private @PlayerMovement m_Wrapper;
        public UserInterfaceActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @cursorLock => m_Wrapper.m_UserInterface_cursorLock;
        public InputActionMap Get() { return m_Wrapper.m_UserInterface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserInterfaceActions set) { return set.Get(); }
        public void SetCallbacks(IUserInterfaceActions instance)
        {
            if (m_Wrapper.m_UserInterfaceActionsCallbackInterface != null)
            {
                @cursorLock.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCursorLock;
                @cursorLock.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCursorLock;
                @cursorLock.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCursorLock;
            }
            m_Wrapper.m_UserInterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @cursorLock.started += instance.OnCursorLock;
                @cursorLock.performed += instance.OnCursorLock;
                @cursorLock.canceled += instance.OnCursorLock;
            }
        }
    }
    public UserInterfaceActions @UserInterface => new UserInterfaceActions(this);
    private int m_inclusiveSchemeIndex = -1;
    public InputControlScheme inclusiveScheme
    {
        get
        {
            if (m_inclusiveSchemeIndex == -1) m_inclusiveSchemeIndex = asset.FindControlSchemeIndex("inclusive");
            return asset.controlSchemes[m_inclusiveSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnScrollY(InputAction.CallbackContext context);
    }
    public interface IUserInterfaceActions
    {
        void OnCursorLock(InputAction.CallbackContext context);
    }
}
