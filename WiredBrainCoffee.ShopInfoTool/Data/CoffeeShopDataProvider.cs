using WiredBrainCoffee.ShopInfoTool.Model;

namespace WiredBrainCoffee.ShopInfoTool.Data;

public class CoffeeShopDataProvider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[] {
        new CoffeeShop("Frankfurt", 45),
        new CoffeeShop("Zurich", 39),
        new CoffeeShop("Rome", 25),
        new CoffeeShop("Lyon", 57)


        };
    }
}

