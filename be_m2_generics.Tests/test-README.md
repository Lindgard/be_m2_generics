# be_m2_generics – Tests

## Running the tests

From the root folder of the project:

```bash
dotnet test
```

For more detailed output:

```bash
dotnet test --logger "console;verbosity=detailed"
```

---

## What is tested?

### A. Core functionality

| Test | Description |
| --- | --- |
| `NewStorage_CountShouldBeZero` | New storage starts with 0 elements |
| `AddItem_ShouldIncreaseCount` | `AddItem` increases count by 1 |
| `RemoveItem_ShouldDecreaseCount` | `RemoveItem` decreases count by 1 |
| `CountItems_ShouldReturnCorrectCount` | `CountItems` returns correct count |

### B. Data-driven tests (`[Theory]`)

| Test | Description |
| --- | --- |
| `AddItem_WithVariousDrinks_...` | Tests `AddItem` with various string values |
| `AddMultipleItems_CountShouldMatch...` | Tests that count matches the number of items added |
| `AddItem_WithIntegerType_...` | Tests that `Storage<int>` works the same way |

### C. Models

Tests that `Storage<T>` works correctly with domain objects:

- `Storage<Drink>` with `StorageTypes.DrinkCategory`
- `Storage<Food>` with `StorageTypes.FoodCategory`
- `Storage<Weapon>` with `StorageTypes.WeaponCategory`

### D. Interface Contract

Verifies that `Storage<T>` implements `IStorage<T>` for the types `string`, `int` and `Drink`.

### E. Edge Cases

| Test | Expected exception |
| --- | --- |
| `AddItem(null)` | `ArgumentNullException` |
| `RemoveItem` on non-existent element | `InvalidOperationException` |
| `RemoveItem` from empty storage | `InvalidOperationException` |
