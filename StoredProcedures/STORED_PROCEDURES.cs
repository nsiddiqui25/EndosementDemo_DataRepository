using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataRepository.StoredProcedures
{
    public static class STORED_PROCEDURES
    {
        public static int GetIdentity(string tableName, DbContext cntx)
        {
            SqlParameter[] @params =
                {
                    new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
                    new SqlParameter("@db_name", tableName),
                };
            cntx.Database.ExecuteSqlRaw("exec @returnVal=getIdentity @db_name", @params);
            return (int)@params[0].Value; ;
        }

        public static String GetSnPLoginInfo(DbContext cntx, string location)
        {
            string info = string.Empty;
            DbConnection connection = cntx.Database.GetDbConnection();
            using (connection)
            {
                DbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetGeoCodeInfo";
                DbParameter parameter = cmd.CreateParameter();
                parameter.ParameterName = "@Location";
                parameter.Value = location;
                cmd.Parameters.Add(parameter);
                connection.Open();
               
                DbDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //Console.WriteLine("{0}\t{1}", dataReader.GetString(0),
                        //    dataReader.GetString(1));
                        info = dataReader.GetString(0) + ":" + dataReader.GetString(1);
                    }
                }
                else
                {
                    //Console.WriteLine("No rows found.");
                }
                dataReader.Close();
                return info;
            }
            
        }
    }
}
