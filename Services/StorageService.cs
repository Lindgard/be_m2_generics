using be_m2_generics.Classes;
using be_m2_generics.Interfaces;

namespace be_m2_generics.Services;

public class StorageService<T> : IStorageService<T>
{
    Storage<T> storage;
    public void AddItem(T item)
    {
        throw new NotImplementedException();
    }

    public int CountItems(T item)
    {
        throw new NotImplementedException();
    }

    public void GetAllItems(T item)
    {
        throw new NotImplementedException();
    }

    public void RemoveItem(T item)
    {
        throw new NotImplementedException();
    }
}