using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        string expected =
            $"Product Inventory:{System.Environment.NewLine}" +
            $"{"product"} - Price: $1.20 - Quantity: 2";
        _inventory.AddProduct("product", 1.2, 2);
        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expected = $"Product Inventory:";

        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.30, 3);
        _inventory.AddProduct("Cheese", 9.90, 4);
        string expected =
            $"Product Inventory:{System.Environment.NewLine}" +
            $"Bread - Price: $2.30 - Quantity: 3{System.Environment.NewLine}" +
            $"Cheese - Price: $9.90 - Quantity: 4";

        //Act
        string result = _inventory.DisplayInventory();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //Arrange
        double expectedValue = 0.0;

        //Act
        double result = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //Arrange
        _inventory.AddProduct("Bread", 2.30, 3);
        _inventory.AddProduct("Cheese", 9.90, 4);
        double expectedValue = 2.30 * 3 + 9.90 * 4;

        //Act
        double result = _inventory.CalculateTotalValue();

        //Assert
        Assert.That(result, Is.EqualTo(expectedValue));
    }
}
