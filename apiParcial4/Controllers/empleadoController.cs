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

    public class empleadoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IQueryable Get(int dato)
        {
            clsOpeEmpleado opeEm = new clsOpeEmpleado();
            return opeEm.EmpleadoxDepa(dato);

        }

        // POST api/<controller>
        public string Post([FromBody] tblEmpleado datIn)
        {

            clsOpeEmpleado oOpex = new clsOpeEmpleado();
            oOpex.tblEm = datIn;
            return oOpex.Agregar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] tblEmpleado datIn)
        {
            clsOpeEmpleado oOpex = new clsOpeEmpleado();
            oOpex.tblEm = datIn;
            return oOpex.Modificar();

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}