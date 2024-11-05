using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiParcial4.Clases
{
    public class clsOpeDepartamento
    {
        private bdGestionEntities oEFR = bdGestionEntities();
        public tblDepartamento tblDepa { get; set; }

        public List<tblDepartamento> listarDepartamento()
        {
            return oEFR.tblDepartamentoes.OrderBy(x => x.Nombre).ToList();
        }
    }
}