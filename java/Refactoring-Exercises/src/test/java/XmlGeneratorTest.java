class XmlGeneratorTest {

    @Test
    void mapToXml() {
        String productCatalogAsString = XmlGenerator.MapToXml(new ProductCatalogInternal());

        assertTrue(false);
    }

    @Test
    void map() {
        ProductCatalog productCatalogAsString = XmlGenerator.map(new ProductCatalogInternal());

        assertTrue(true);
    }

}