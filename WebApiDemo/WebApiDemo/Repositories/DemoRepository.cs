using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApiDemo.DataModels;
using WebApiDemo.Extensions;

namespace WebApiDemo.Repositories
{
    public class DemoRepository : BaseRepository<EmpDataModel>
    {
        public override void Delete(EmpDataModel item)
        {
            connection.ExecuteNonQuery("DELETE FROM CENTER.SYS_EMP WHERE ID = @ID", new { item.ID });
        }

        public override IEnumerable<EmpDataModel> Find(Expression<Func<EmpDataModel, bool>> query)
        {
            //Error Testing
            throw new NotImplementedException();
        }

        public override IEnumerable<EmpDataModel> Get()
        {
            return connection.ExecuteSQL<EmpDataModel>("DELETE FROM CENTER.SYS_EMP", null);
        }

        public override EmpDataModel Get(int id)
        {
            return connection.ExecuteSQL<EmpDataModel>("DELETE FROM CENTER.SYS_EMP WHERE ID = @ID", new { id }).FirstOrDefault();
        }

        public override void Post(EmpDataModel item)
        {
            string sInsert = @"INSERT INTO CENTER.SYS_EMP
	                                  (NO , NAME , PHONE , REMARK)
	                           VALUES (@NO, @NAME, @PHONE, @REMARK)";

            connection.ExecuteNonQuery(sInsert, item);
        }

        public override void Put(EmpDataModel item)
        {
            string sUpdate = @"UPDATE CENTER.SYS_EMP
                                  SET NO     = @NO,
                                      NAME   = @NAME,
                                      PHONE  = @PHONE,
                                      REMARK = @REMARK
                                WHERE ID = @ID";

            connection.ExecuteNonQuery(sUpdate, item);
        }
    }
}