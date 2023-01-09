namespace Bll;
using Bol;
using DAL;


public class CatalogManager
{

    public List<Product> GetallProducts(){

        List<Product>allproduct=new List<Product>();
        allproduct=BDManager.GetallProducts();

        return allproduct;
    }


    public Product GetProduct(int id){

        List <Product> allProduct=GetallProducts();

        Product FoundProduct=allProduct.Find((Product)=>Product.productId==id);
        retrun foundProduct;
    }

}
