using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{
    class SaleRepotingManager
    {
        SaleRepotingRepository _saleRepotingRepository = new SaleRepotingRepository();
        public List<SaleRepotingModel> SearchValue(SaleRepotingModel saleRepotingModel)
        {
            return _saleRepotingRepository.SearchValue(saleRepotingModel);
        }
    }
}
