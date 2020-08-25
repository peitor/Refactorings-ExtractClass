using System;

namespace Refactoring_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ProductCatalogMapper
    {
        public ProductCatalog map(ProductCatalogInternal productCatalogInternal)
        {
            ProductCatalog result = new ProductCatalog();
            result.Product = map(productCatalogInternal.productInternal);
            return result;
        }

        public Product map(ProductInternal productInternal)
        {
            return null;
        }
    }

    public class XmlGenerator
    {
        private ProductCatalogMapper _productCatalogMapper;

        public XmlGenerator(ProductCatalogMapper productCatalogMapper)
        {
            _productCatalogMapper = productCatalogMapper;
        }

        public string MapAndXml(ProductCatalogInternal productCatalogInternal)
        {
            var productCatalog = _productCatalogMapper.map(productCatalogInternal);

            return ToXml(productCatalog);
        }

        private string ToXml(ProductCatalog productCatalog)
        {
            return "<xml> <somebody>";
        }
    }



    // -------------------------------


    public class ProductInternal
    {
    }

    public class ProductCatalog
    {
        public Product Product { get; set; }
    }

    public class Product
    {
    }

    public class ProductCatalogInternal
    {
        public ProductInternal productInternal;
    }
}