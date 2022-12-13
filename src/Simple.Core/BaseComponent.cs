namespace Simple.Core
{
    public abstract class BaseComponent : IComponent
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public IComponent Parent { get; private set; }

        public bool Enabled { get; private set; } = true;

        public List<IComponent> Children { get; } = new List<IComponent>();

        public void Enable()
        {
            Enabled = true;
        }

        public void Disable()
        {
            Enabled = false;
        }

        public abstract void Initialize();
        public abstract void Update();
    }
}
