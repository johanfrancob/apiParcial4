using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiParcial4.Clases
{
    public class clsOpeEmpleado
    {
        private bdGestionEntities oEFR = bdGestionEntities();
        public tblEmpleado tblEm { get; set; }


        public IQueryable EmpleadoxDepa(int nroDoc)
        {
            return from tE in oEFR.Set<tblEmpleado>()
                   join tD in oEFR.Set<tblDepartamento>()
                   on tE.idDepa equals tD.ID
                   orderby tE.nroDoc
                   where tE.nroDoc == nroDoc

                   select new
                   {
                       Editar = "<a class='btn btn-info btn-sm' href='#'><i class='fas fa-pencil-alt'></i> Editar</a>",
                       Código = tE.Codigo,
                       Nombre = tE.Nombre,
                       NroDocu = tE.nroDoc,
                       idDepa = tD.ID

                   };
        }

        public string Agregar()
        {
            var maxId = 0;
            try
            {
                maxId = oEFR.tblEmpleado.DefaultIfEmpty().Max(r => r == null ? 1 : r.CODIGO + 1);
                tblEm.Codigo = maxId;
                oEFR.tblArtistas.Add(tblEm);
                oEFR.SaveChanges();
                return "Registro grabado con exito:" + tblEm.Nombre + ",con nroDoc:" + tblEm.nroDoc + " y salario " + tblEm.Salario;
            }
            catch (Exception)
            {
                return "Error, hubo fallo al grabar registro" + tblEm.Nombre + ", con nroDoc:" + tblEm.nroDoc;

            }

        }

        public string Modificar()
        {
            try
            {
                tblEmpleado est = oEFR.tblEmpleado.FirstOrDefault(s => s.nroDoc == tblEm.nroDoc);
                //est.Codigo = tblArt.Codigo;
                est.Nombre = tblEm.Nombre;
                est.idTipoDoc = tblEm.idTipoDoc;
                est.nroDoc = tblEm.nroDoc;
                est.idDepartamento = tblEm.idDepa;
                oEFR.SaveChanges();
                return "se actualizo el registro de:" + est.nroDoc;
            }
            catch (Exception)
            {
                return "Error, hubo fallo al actualizar registro:" + tblEm.Codigo + ", reintente por favor";
            }
        }

    }
}