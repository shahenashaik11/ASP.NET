using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _28Nov.DAL
{
    public class ProductDAL
    {
        public string Name { get; set; }
        public static string ConnectionString { get; set; }
        public System.Data.DataSet GetProducts()
        {
            string Query = "select Id,Name from Products";
            SQLManager manager = new SQLManager();
            return manager.GetDataSet(Query);
        }
        public bool UpdateProduct(Product product)
        {
            bool isSuccess;
            List<ProcParameters> procParams = new List<ProcParameters>();
            procParams.Add(new ProcParameters("@ID", product.ID.ToString(), DbType.Int32, ParameterDirection.Input));
            procParams.Add(new ProcParameters("@Name", Name, DbType.String, ParameterDirection.Input));
            SQLManager manager = new SQLManager();
            isSuccess = manager.UpdateRecord("SelectParam", procParams);
            return isSuccess;
        }

        //internal void UpdateProduct(ProductDetails product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}