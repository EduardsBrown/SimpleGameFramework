namespace Simple.Core
{
    public interface IComponent
    {
        Guid Id { get; }

        Transform Transform { get; }
        IComponent Parent { get; }
        bool Enabled { get; }

        List<IComponent> Children { get; }
    }
}
