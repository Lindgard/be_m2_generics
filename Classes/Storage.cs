using be_m2_generics.Interfaces;
namespace be_m2_generics.Classes;


public class Storage<T> : IStorage<T>
{
    private List<T> items = new();
    private StorageTypes storageType;

    public Storage(StorageTypes storageType)
    {
        this.storageType = storageType;
    }
    public void AddItem(T item)
    {
        items.Add(item);
    }

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