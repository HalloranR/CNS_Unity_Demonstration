//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/New Folder/Cube Controls.inputactions
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

public partial class @CubeControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CubeControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Cube Controls"",
    ""maps"": [
        {
            ""name"": ""Cube Map"",
            ""id"": ""3a2e3ab5-9b51-44c7-b2f4-808dd70e9834"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bf901a5a-4ac3-4236-9511-0541e1c9027a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""097086fb-ec9c-46bf-b149-9d0757184f0f"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""42e372b6-e9e1-49b3-9e0a-37945c2e6d9c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0ab74945-56c2-4c2c-beec-ebc49c7d6f0b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a58cadad-781a-4ad4-bbeb-20f0ec3004e3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50b43f80-bba3-4a19-9168-9520df2f634f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""fdf4f7c8-9601-4893-af6d-63e47fdf20a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""51178a0d-2c37-4701-8ab1-0ba83fcc9200"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cube Map
        m_CubeMap = asset.FindActionMap("Cube Map", throwIfNotFound: true);
        m_CubeMap_Movement = m_CubeMap.FindAction("Movement", throwIfNotFound: true);
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

    // Cube Map
    private readonly InputActionMap m_CubeMap;
    private ICubeMapActions m_CubeMapActionsCallbackInterface;
    private readonly InputAction m_CubeMap_Movement;
    public struct CubeMapActions
    {
        private @CubeControls m_Wrapper;
        public CubeMapActions(@CubeControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CubeMap_Movement;
        public InputActionMap Get() { return m_Wrapper.m_CubeMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CubeMapActions set) { return set.Get(); }
        public void SetCallbacks(ICubeMapActions instance)
        {
            if (m_Wrapper.m_CubeMapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CubeMapActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_CubeMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public CubeMapActions @CubeMap => new CubeMapActions(this);
    public interface ICubeMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
