using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DapperProductRepository : IProductInterface
    {
        private readonly IDbConnection _conn;

        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Products> GetAllProducts()
        {
            {
                return _conn.Query <Products>("SELECT * FROM products;");
            }
        }
    }
}
