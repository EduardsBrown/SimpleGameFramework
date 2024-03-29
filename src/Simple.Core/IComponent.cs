﻿namespace Simple.Core
{
    public interface IComponent
    {
        Guid Id { get; }
        IComponent Parent { get; }
        bool Enabled { get; }

        List<IComponent> Children { get; }

        void Enable();
        void Disable();

        void Initialize();
        void Update();
    }
}
