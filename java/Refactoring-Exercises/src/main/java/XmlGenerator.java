public class XmlGenerator
{
    private final ProductMapper productMapper = new ProductMapper();

    public  String MapToXml(ProductCatalogInternal productCatalogInternal)
    {
        ProductCatalog productCatalog = productMapper.map(productCatalogInternal);

        return ToXmlVoodoStuff(productCatalog);
    }

    private String ToXmlVoodoStuff(ProductCatalog productCatalog)
    {
        return "";
    }


}

