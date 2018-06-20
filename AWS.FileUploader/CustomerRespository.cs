using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Common;

namespace AWS.FileUploader
{
    public sealed class CustomerRespository
    {
        public IEnumerable<string> GetCustomerDns()
        {
            return new string[] { "mybucket.com", "myother.com" };
        }
    }
}
