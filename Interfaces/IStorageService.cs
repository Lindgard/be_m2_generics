namespace be_m2_generics.Interfaces;

public interface IStorageService<T>
{
    void AddItem(T item);
    void RemoveItem(T item);
    int CountItems(T item);
    void GetAllItems(T item);
}