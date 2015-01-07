using System.Web.Http;
using System.Web.Mvc;
using MvvmSeed.Models;

namespace MvvmSeed.Controllers
{
    public class ExampleApiController : ApiController
    {
        // GET: Api/ExampleApi/
        public Movie Get()
        {
            return new Movie
            {
                Id = 1,
                Title = "Star War",
                Director = "Lucas"
            };
        }

        // GET: Api/ExampleApi/5
        public Movie Get(int id)
        {
            return new Movie
            {
                Id = id,
                Title = "Future Program",
                Director = "Luke Zeng"
            };
        }

        // GET: Api/ExampleApi/5
        public JsonResult Post(int id, string abc)
        {
            return new JsonResult
            {
                Data = new
                {
                    id,
                    extra = abc
                }
            };
        }
    }
}
