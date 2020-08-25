using NUnit.Framework;
using Refactoring_Test;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestMapToXML()
        {
            string productCatalogAsString =
                new XmlGenerator(new ProductCatalogMapper())
                    .MapAndXml(new ProductCatalogInternal());

            Assert.Pass();
        }



        [Test]
        public void TestMapProductCatalog()
        {
            var result = new ProductCatalogMapper().map(new ProductCatalogInternal());

            Assert.Pass();
        }

        [Test]
        public void TestMapProduct()
        {
            var result = new ProductCatalogMapper().map(new ProductInternal());

            Assert.Pass();
        }
    }
}