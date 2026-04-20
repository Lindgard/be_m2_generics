using be_m2_generics.Interfaces;
namespace be_m2_generics.Classes;


public class Storage<T> : IStorageService<T>
{
    private List<T> items = new();
    private StorageTypes storageType;

    public Storage(StorageTypes storageType)
    {
        this.storageType = storageType;
    }
    //TODO start AddItem method
    public void AddItem(T item)
    {
        items.Add(item);
    }

    //TODO RETURN IENUMERABLE<T> on GetallItems method
    public IEnumerable<T> GetAllItems()
    {
        return items;
    }

    public int CountItems()
    {
        return items.Count;
    }

    //* RemoveItem method 
    public void RemoveItem(T item)
    {
        items.Remove(item);
    }
}