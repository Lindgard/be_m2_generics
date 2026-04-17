namespace be_m2_generics.Classes;


public class Storage<T>(StorageTypes storageTypes)
{
    private List<T> items = new();
    private StorageTypes storageType = storageTypes;

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