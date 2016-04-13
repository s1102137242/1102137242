using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增 
        /// </summary>
        public void InsertOrder(Models.Order Order)
        {

        }

        /// <summary>
        /// 刪除
        /// </summary>
        public void DeleteOrderById(string Id)
        {

        }

        /// <summary>
        /// 更新
        /// </summary>
        public void UpdateOrder(Models.Order Order)
        {

        }

        /// <summary>
        /// 取得
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustomerID = "GSS";

            return result;
        }

        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }

    }
}