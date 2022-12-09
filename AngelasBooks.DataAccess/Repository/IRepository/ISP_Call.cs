using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngelasBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        // E.g. First column of first row in the result set
        T Single<T>(string procedureName, DynamicParameters param = null);
        // Execute something to the database but not retrieve anything
        void Execute(string procedureName, DynamicParameters param = null);
        // Retrieves the complete row or record
        T OneRecord<T>(string procedureName, DynamicParameters param = null);
        // Gett all of the rows
        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);
        // Stored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
