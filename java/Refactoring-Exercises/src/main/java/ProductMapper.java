public class ProductMapper {
    public ProductMapper() {
    }

    public ProductCatalog map(ProductCatalogInternal productCatalogInternal) {
        ProductCatalog result = new ProductCatalog();
        result.Product = mapProduct(productCatalogInternal.productInternal);
        return result;
    }

    Product mapProduct(ProductInternal productInternal) {
        return null;
    }
}