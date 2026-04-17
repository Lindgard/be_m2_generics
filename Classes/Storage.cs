using be_m2_generics.Interfaces;

namespace be_m2_generics.Classes;


public class Storage<T>(StorageTypes storageTypes) : IStorageService<T>
{
    private List<T> _storage = new(); //? useful or pointless?

    //* _storage.AddItem(T item) / _storage.Push()
    //* _storage.GetAllItems(T item) //* RETURN IENUMERABLE<T>
    //* _storage.CountItems()
    //* _storage.RemoveItem() / _storage.Pop();

}