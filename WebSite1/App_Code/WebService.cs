using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }



    /// <summary>
    /// andrés naranjo 2015-01-01 devuelve una lista de la entidad copia
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<copia> BuscarDatosCopia() {

        DataClassesDataContext bd = new DataClassesDataContext();

        return bd.copia.ToList();
        
    }
    
}
