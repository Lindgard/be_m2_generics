using be_m2_generics.Interfaces;

namespace be_m2_generics.Classes;


public class Storage<T>(StorageTypes storageTypes) : IStorageService<T>
{
    private List<T> _storage = new();


}