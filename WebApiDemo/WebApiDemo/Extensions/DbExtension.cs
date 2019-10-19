using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Dapper;

namespace WebApiDemo.Extensions
{
    internal static class DbExtension
    {
        /// <summary>
        /// return affect rowcount with Executed query string
        /// </summary>
        /// <param name="openConn">db connection objet</param>
        /// <param name="sCommand">Query string</param>
        /// <param name="oParams">Anonymous parameter</param>
        /// <returns>Return affect rowcount</returns>
        public static int ExecuteNonQuery(this IDbConnection openConn, string sCommand, object oParams)
        {
            Debug.WriteLine("[Debug] : Debug Start");

            if (!openConn.TryConnect())
            {
                Debug.WriteLine("[Error] : Conn Fail");
                return -1;
            }
            try
            {
                Debug.WriteLine($"[Debug] : {sCommand}");
                var result = openConn.Execute(sCommand, oParams);
                Debug.WriteLine("[Debug] : Debug End");
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[Error] : {ex.Message}");
                throw;
            }
            finally
            {
                openConn.Close();
            }
        }

        /// <summary>
        /// return list of data with Executed query string
        /// </summary>
        /// <param name="openConn">db connection objet</param>
        /// <param name="sCommand">Query string</param>
        /// <param name="oParams">Anonymous parameter</param>
        /// <returns>list of data</returns>
        public static IEnumerable<T> ExecuteSQL<T>(this IDbConnection openConn, string sCommand, object oParams) where T:class
        {
            Debug.WriteLine("[Debug] : Debug Start");

            if (!openConn.TryConnect())
            {
                Debug.WriteLine("[Error] : Conn Fail");
                return null;
            }
            try
            {
                Debug.WriteLine($"[Debug] : {sCommand}");
                var result = openConn.Query<T>(sCommand, oParams);
                Debug.WriteLine("[Debug] : Debug End");
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[Error] : {ex.Message}");
                throw;
            }
            finally
            {
                openConn.Close();
            }
        }

    }
}