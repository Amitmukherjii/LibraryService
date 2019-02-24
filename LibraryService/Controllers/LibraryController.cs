using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AggregateModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LibraryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        LoadCustomerDetailsAggregate loadAggregate = new LoadCustomerDetailsAggregate();
        // GET api/values
        [HttpGet]
        public ActionResult<LoadCustomerEvent> Get()
        {
           return loadAggregate.LoadCustomerDetails (1);

        //var serialized = JsonConvert.SerializeObject(
        //    { "id": "1", "name": "The Midnight Line", "author": "Child Lee", "description": "A Jack Reacher Novel", "picture": "", "type": "['Fiction']"};
        //    );
        //var x = { "One":"Value One","Two":"Value Two","Three":"Value Three"};

        //       [{"id": "1", "name": "'The Midnight Line'", "author: 'Child Lee'", "description: 'A Jack Reacher Novel'", "picture: ''", "type: ['Fiction']"},
        //     { "id": "2", "name": "'The Rooster Bar'", "author: 'John Grisham'", "description: 'A Novel', picture: '', type: ['Fiction']},
        //     { "id": "3", "name": "'Two Kinds of Truth'", "author: 'Connelly, Michael'", "description: 'A Novel', picture: '', type: ['Fiction']},
        //     { "id": "4", "name": "'Origin'", "author: 'Dan Brown'", "description: 'A Novel', picture: '', type: ['Fiction', 'gray']},
        //     { "id": "5", "name": "'Artemis'", "author: 'Weir, Andy'", "description: 'A Novel', picture: '', type: ['Fiction', 'blue']},
        //     { "id": "6", "name": "'Hardcore Twenty-four'","author: 'Evanovich, Janet'", "description: 'A Novel', picture: '', type: ['Fiction', 'blue']},
        //     { "id": "7", "name": "'Glass Houses'", "author: 'Penny, Louise'", "description: 'A Novel', picture: '', type: ['Fiction']},
        //     { "id": "8", "name": "'Little Fires Everywhere'", "author: 'Ng, Celeste'", "description: 'A Novel', picture: '', type: ['Fiction']},
        //     { "id": "9", "name": "'The Wendy Project'", "author: 'Osborne, Melissa Jane '", "description: 'Book 2017', picture: '', type: ['Fiction', 'blue', 'green']},
        //];
        //return new string[] { "value1", "value2" };
    }

        //public ActionResult<IEnumerable<string> >
    }
}