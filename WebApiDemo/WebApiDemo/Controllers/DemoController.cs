using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Repositories;
using WebApiDemo.DataModels;
using Newtonsoft.Json;

namespace WebApiDemo.Controllers
{
    public class DemoController : ApiController
    {
        DemoRepository _Repo;

        public DemoController() => _Repo = new DemoRepository();
        // GET: api/Demo
        public IEnumerable<EmpDataModel> Get()
        {
            return _Repo.Get();
        }

        // GET: api/Demo/5
        public EmpDataModel Get(int id)
        {
            var item = _Repo.Get(id);
            if (item == null)
                BadRequest("Item Not Found");
            return item;
        }

        // POST: api/Demo
        public void Post([FromBody]string value)
        {
            var item = JsonConvert.DeserializeObject<EmpDataModel>(value);

            _Repo.Post(item);
        }

        // PUT: api/Demo/5
        public void Put([FromBody]string value)
        {
            var item = JsonConvert.DeserializeObject<EmpDataModel>(value);

            _Repo.Put(item);
        }

        // DELETE: api/Demo/5
        public void Delete([FromBody]string value)
        {
            var item = JsonConvert.DeserializeObject<EmpDataModel>(value);

            _Repo.Delete(item);
        }
    }
}
