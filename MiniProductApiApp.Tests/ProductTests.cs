namespace MiniProductApiApp.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_Should_Have_Valid_Properties()
        {
            // Arrange
            var product = new MiniProductApiApp.Models.Product
            {
                Id = 1,
                Name = "Test Product",
                Price = 9.99m
            };
            // Act & Assert
            Assert.Equal(1, product.Id);
            Assert.Equal("Test Product", product.Name);
            Assert.Equal(9.99m, product.Price);
        }

        [Fact]
        public void Product_Should_Be_Created_With_Default_Values()
        {
            // Arrange
            var product = new MiniProductApiApp.Models.Product();
            // Act & Assert
            Assert.Equal(0, product.Id);
            Assert.Null(product.Name);
            Assert.Equal(0m, product.Price);
        }
    }
}
