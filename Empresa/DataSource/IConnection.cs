using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DataSource
{
    public interface IConnection
    {
        bool ExecultyNonQuery(string sql);
        DataTable List(string sql);
    }
}
