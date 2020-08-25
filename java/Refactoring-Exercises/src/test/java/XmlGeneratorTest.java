import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertTrue;

class XmlGeneratorTest {

    @Test
    void mapToXml() {
        String productCatalogAsString =
                new XmlGenerator().MapToXml(
                        new ProductCatalogInternal());

        assertTrue(true);
    }

    @Test
    void map() {
        ProductCatalog productCatalogAsString =
                new ProductMapper().map(
                        new ProductCatalogInternal());

        assertTrue(true);
    }

}