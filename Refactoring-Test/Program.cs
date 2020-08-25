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

    public class XmlGenerator
    {
        public static string MapToXml(ProductCatalogInternal productCatalogInternal)
        {
            var productCatalog = map(productCatalogInternal);

            return ToXmlVoodoStuff(productCatalog);
        }

        private static string ToXmlVoodoStuff(ProductCatalog productCatalog)
        {
            return "";
        }


        public static ProductCatalog map(ProductCatalogInternal productCatalogInternal)
        {
            ProductCatalog result = new ProductCatalog();
            result.Product = mapProduct(productCatalogInternal.productInternal);
            return result;
        }

        private static Product mapProduct(ProductInternal productInternal)
        {
            return null;
        }
    }

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