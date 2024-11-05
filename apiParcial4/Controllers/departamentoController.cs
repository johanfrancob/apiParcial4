using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using apiParcial4.Clases;
using apiParcial4.Models;


namespace apiParcial4.Controllers
{
    [EnableCors(origins: "http://localhost:XXXXX", headers: "*", methods: "*")]

    public class departamentoController : ApiController
    {
        // GET api/<controller>
        public List<tblDepartamento> Get()
        {
            clsOpeDepartamento oX = new clsOpeDepartamento();
            return oX.listarDepartamento();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}