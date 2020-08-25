using NUnit.Framework;
using Refactoring_Test;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestMapToXML()
        {
            string productCatalogAsString = XmlGenerator.MapToXml(new ProductCatalogInternal());

            Assert.Pass();
        }

        [Test]
        public void TestMapProduct()
        {
            var productCatalogAsString = XmlGenerator.map(new ProductCatalogInternal());

            Assert.Pass();
        }
    }
}