using be_m2_generics.Interfaces;
using be_m2_generics.Classes;
using be_m2_generics.Models;
using Xunit;

namespace be_m2_generics.Tests;

public class GenericsTests
{
    [Fact]
    public void NewStorage_CountShouldBeZero()
    {
        //* Arrange & Act
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Assert
        Assert.Equal(0, storage.CountItems());
    }
    [Fact]
    public void AddItem_ShouldIncreaseCount()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act
        storage.AddItem("Coca Cola");

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    [Fact]
    public void RemoveItem_ShouldDecreaseCount()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);
        storage.AddItem("Coca Cola");

        //* Act
        storage.RemoveItem("Coca Cola");

        //* Assert
        Assert.Equal(0, storage.CountItems());
    }

    [Fact]
    public void CountItems_ShouldReturnCorrectCount()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);
        storage.AddItem("Coca Cola");
        storage.AddItem("Coffee");

        //* Act
        var count = storage.CountItems();

        //* Assert
        Assert.Equal(2, count);
    }

    // ======================================
    // [Theory] Data-driven tests
    // ======================================

    [Theory]
    [InlineData("Coca Cola")]
    [InlineData("Coffee")]
    [InlineData("Tea")]
    [InlineData("Water")]
    public void AddItem_WithVariousDrinks_ShouldIncreaseCountToOne(string drink)
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act
        storage.AddItem(drink);

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    [Theory]
    [InlineData(new[] { "Coca Cola" }, 1)]
    [InlineData(new[] { "Coca Cola", "Coffee" }, 2)]
    [InlineData(new[] { "Coca Cola", "Coffee", "Tea" }, 3)]
    [InlineData(new[] { "Coca Cola", "Coffee", "Tea", "Water" }, 4)]
    public void AddMultipleItems_CountShouldMatchNumberOfItems(string[] drinks, int expectedCount)
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act
        foreach (var drink in drinks)
        {
            storage.AddItem(drink);
        }

        //* Assert
        Assert.Equal(expectedCount, storage.CountItems());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(42)]
    [InlineData(-5)]
    [InlineData(0)]
    public void AddItem_WithIntegerType_ShouldIncreaseCount(int value)
    {
        //* Arrange
        var storage = new Storage<int>(StorageTypes.DrinkCategory);

        //* Act
        storage.AddItem(value);

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    // ======================================
    // A. Models - Drink, Food, Weapon
    // ======================================

    [Fact]
    public void AddItem_WithDrinkModel_ShouldIncreaseCount()
    {
        //* Arrange
        var storage = new Storage<Drink>(StorageTypes.DrinkCategory);
        var drink = new Drink { Name = "Coca Cola", Volume = 0.5, Category = "Soda" };

        //* Act
        storage.AddItem(drink);

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    [Fact]
    public void AddItem_WithFoodModel_ShouldIncreaseCount()
    {
        //* Arrange
        var storage = new Storage<Food>(StorageTypes.FoodCategory);
        var food = new Food { Name = "Pizza", Weight = 1.2, Category = "Italian" };

        //* Act
        storage.AddItem(food);

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    [Fact]
    public void AddItem_WithWeaponModel_ShouldIncreaseCount()
    {
        //* Arrange
        var storage = new Storage<Weapon>(StorageTypes.WeaponsCategory);
        var weapon = new Weapon { Name = "Sword", Weight = 4.5, Category = "Melee" };

        //* Act
        storage.AddItem(weapon);

        //* Assert
        Assert.Equal(1, storage.CountItems());
    }

    // ======================================
    // Interface-testing
    // ======================================

    [Fact]
    public void Storage_WithString_ShouldImplementIStorage()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act & Assert
        Assert.IsAssignableFrom<IStorage<string>>(storage);
    }

    [Fact]
    public void Storage_WithDouble_ShouldImplementIStorage()
    {
        //* Arrange
        var storage = new Storage<double>(StorageTypes.DrinkCategory);

        //* Act & Assert
        Assert.IsAssignableFrom<IStorage<double>>(storage);
    }

    [Fact]
    public void Storage_WithDrinkModel_ShouldImplementIStorage()
    {
        //* Arrange
        var storage = new Storage<Drink>(StorageTypes.DrinkCategory);

        //* Act & Assert
        Assert.IsAssignableFrom<IStorage<Drink>>(storage);
    }

    //=====================================
    // Edge Cases - null, duplicate, error handling
    //=====================================

    [Fact]
    public void AddItem_NullString_ShouldThrowArgumentNullException()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act & Assert
        Assert.Throws<ArgumentNullException>(() => storage.AddItem(null!));
    }

    [Fact]
    public void RemoveItem_NonExistentItem_ShouldThrowInvalidOperationException()
    {
        //* Arrange
        var storage = new Storage<string>(StorageTypes.DrinkCategory);

        //* Act & Assert
        Assert.Throws<InvalidOperationException>(() => storage.RemoveItem("NonExistentItem"));
    }
}
