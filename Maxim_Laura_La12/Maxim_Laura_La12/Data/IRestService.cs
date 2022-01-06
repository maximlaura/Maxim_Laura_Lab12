using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Maxim_Laura_La12.Models;

namespace Maxim_Laura_La12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
