public class XmlGenerator
{
    public static String MapToXml(ProductCatalogInternal productCatalogInternal)
    {
        ProductCatalog productCatalog = map(productCatalogInternal);

        return ToXmlVoodoStuff(productCatalog);
    }

    private static String ToXmlVoodoStuff(ProductCatalog productCatalog)
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

