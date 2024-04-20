using StationaryDataLayer;
using Models;
namespace StationaryBusiness
{
    public class StationaryLogic
    {
        public List<StationaryModel> RCMP()
        {
            StationaryProducts products = new StationaryProducts();
            return products.RCMP();
        }
    }
}
