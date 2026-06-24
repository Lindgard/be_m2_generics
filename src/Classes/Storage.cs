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
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

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
        if (item == null)
        {
            throw new ArgumentException("Item cannot be null.", nameof(item));
        }
        if (!items.Contains(item))
        {
            throw new InvalidOperationException("Item does not exist in the storage.");
        }
        items.Remove(item);
    }
}