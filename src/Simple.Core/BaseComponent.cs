using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Core
{
    public abstract class BaseComponent : IComponent
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public Transform Transform { get; private set; } = new Transform();

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
