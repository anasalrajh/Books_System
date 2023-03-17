using Books_System.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;


namespace Books_System.Controllers
{
    public class BookController : ApiController
    {
        private BooksEntities _repository = new BooksEntities();
    
        [HttpGet]
        [Route("GetBooks/{subCat}")]
        public IHttpActionResult GetBooks(int subCat)
        {
            var list = _repository.SelectBooks(subCat);
            string json_data = JsonConvert.SerializeObject(list);
            return Json(json_data);
        }
        [HttpGet]
        [Route("GetCategory")]
        public IHttpActionResult GetCategory()
        {
            var cat = _repository.tblCategories.ToList();
            List<tblCategory> getCat = new List<tblCategory>();
            foreach(var item in cat)
            {
                if (getCat.Where(x => x.Id == item.Id).Count() == 0)
                {
                    tblCategory obj = new tblCategory()
                    {
                        Id = item.Id,
                        CategoryName = item.CategoryName,
                        SubCat = _repository.tblSubCategories.Where(x => x.MainCat == item.Id).ToList()
                    };
                    getCat.Add(obj);
                }
            }
            string json_data = JsonConvert.SerializeObject(getCat);

            return Json(json_data);
        }

    }
}
