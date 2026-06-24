namespace be_m2_generics.Interfaces;

public interface IStorage<T>
{
    void AddItem(T item);
    void RemoveItem(T item);
    int CountItems();
    IEnumerable<T> GetAllItems();
}