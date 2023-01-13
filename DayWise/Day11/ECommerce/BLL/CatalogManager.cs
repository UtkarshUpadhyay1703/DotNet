namespace BLL;
using DAL;
using BOL;
public class CatalogManager
{
    // public List<Product> GetAllproducts(){
    //     List<Product> allProduct=DBManager.GetAllProducts();
    //     return allProduct;
    // }

    //We cannot write like above
        public List<Product> GetAllproducts(){
        List<Product> allProduct=new List<Product>();
        allProduct=DBManager.GetAllproducts();
        return allProduct;
    }
    public Product GetProductById(int id){
        // List<Product> allProduct=new List<Product>();
        List<Product> allProduct=DBManager.GetAllproducts();
        Product pro=allProduct.Find((prod)=>prod.ProductId==id);
            return pro;
    }
}
