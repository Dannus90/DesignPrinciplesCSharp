namespace Prototype.Cloneable.Interfaces;

public interface IPrototype<T>
{
    T DeepCopy();
}