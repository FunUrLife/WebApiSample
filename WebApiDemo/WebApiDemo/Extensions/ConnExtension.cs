using System;
using System.Data;

namespace WebApiDemo.Extensions
{
    internal static class ConnExtension
    {
        internal static bool TryConnect(this IDbConnection conn)
        {
            if (conn == null)
                throw new ArgumentNullException("IDbConnection Is Null");

            if (conn.State != ConnectionState.Open)
                conn.Open();
            return conn.State == ConnectionState.Open;
        }
    }
}