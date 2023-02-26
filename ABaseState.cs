namespace XTT
{
    public abstract class ABaseState
    {
        protected StateManager<ABaseState> m_stateManager = null;

        public ABaseState Init( StateManager<ABaseState> stateManager )
        {
            this.m_stateManager = stateManager;
            return this;
        }

        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void FixedUpdateState();
        public abstract void LateUpdateState();
        public abstract void ExitState();
    }
}