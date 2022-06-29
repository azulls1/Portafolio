
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
       public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Tiutulo="GitHub",
                    Descripcion="Proyecto hecho en angular, simulacion de una red social",
                    Link="https://github.com/azulls1/cliente-Master",
                    ImagenURL="/imagenes/GitHub2.png"
                },
                new Proyecto
                {
                    Tiutulo="GitHub",
                    Descripcion="Proyecto hecho en c#, consumo de APIS",
                    Link="https://github.com/azulls1/DatingApp",
                    ImagenURL="/imagenes/GitHub2.png"
                },
                new Proyecto
                {
                    Tiutulo="GitHub",
                    Descripcion="Proyecto hecho en ASP.NET, proyecto de portafolio",
                    Link="https://github.com/azulls1/client-master",
                    ImagenURL="/imagenes/GitHub2.png"
                },
                new Proyecto
                {
                    Tiutulo="GitHub",
                    Descripcion="Proyecto en curso en ASP.NET, proyecto de Manejo de Presupuestos-Base de datos",
                    Link="",
                    ImagenURL="/imagenes/GitHub2.png"
                },
            };
        }
    }
}
