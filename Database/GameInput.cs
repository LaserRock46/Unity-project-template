//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Database/GameInput.inputactions
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

namespace Project.InputSystem
{
    public partial class @GameInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""6af306e2-0315-4759-988e-b1909da0b91e"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""2bbe83fd-6fb3-488c-bf87-3ef6810db864"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9950d7ef-9646-45f7-8308-d4a9ca6534ee"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""78821553-48fd-400d-8038-a1e161ae3b4b"",
            ""actions"": [
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""85b4580a-2c59-4f97-bcca-fe4ff9c31443"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""913715dd-2c14-47ae-804e-083515f18993"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_MouseDelta = m_Gameplay.FindAction("MouseDelta", throwIfNotFound: true);
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

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Newaction;
        public struct MenuActions
        {
            private @GameInput m_Wrapper;
            public MenuActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_MouseDelta;
        public struct GameplayActions
        {
            private @GameInput m_Wrapper;
            public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @MouseDelta => m_Wrapper.m_Gameplay_MouseDelta;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @MouseDelta.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouseDelta;
                    @MouseDelta.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouseDelta;
                    @MouseDelta.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouseDelta;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MouseDelta.started += instance.OnMouseDelta;
                    @MouseDelta.performed += instance.OnMouseDelta;
                    @MouseDelta.canceled += instance.OnMouseDelta;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        public interface IMenuActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface IGameplayActions
        {
            void OnMouseDelta(InputAction.CallbackContext context);
        }
    }
}
