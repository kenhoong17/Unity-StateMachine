using System.Collections.Generic;
using UnityEngine;

namespace XTT
{
    public abstract class StateManager<T> : MonoBehaviour where T : ABaseState
    {
        protected T m_currentState = null;

        // ================================================================================

        #region Monobehaviour

        protected virtual void Awake()
        {
        }

        protected virtual void Start() { }
        protected virtual void OnEnable() { }
        protected virtual void OnDisable() { }
        protected virtual void Update() 
        {
            this.m_currentState?.UpdateState();
        }

        protected virtual void FixedUpdate() 
        {
            this.m_currentState?.FixedUpdateState();
        }

        protected virtual void LateUpdate() 
        {
            this.m_currentState?.LateUpdateState();
        }

        #endregion Monobehaviour

        // ================================================================================

        #region State-related functions

        protected void InitDefaultState( T defaultState )
        {
        }

        public void SwitchState( T newState ) 
        {
            this.m_currentState?.ExitState();

            this.m_currentState = newState;
            this.m_currentState.EnterState();
        }

        #endregion State-related functions

        // ================================================================================

    }
}
