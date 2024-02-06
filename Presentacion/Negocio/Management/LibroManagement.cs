using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;
using Datos.Repositories;
using Negocio.EntitiesDTO;

namespace Negocio.Management
{
    public class LibroManagement
    {
        public List<LibrosDTO> ObtenerLibros()
        {
            List<Libro> LibrosDatos = new Datos.Repositories.LibroRepositorio().ObtenerLibros();
            List<LibrosDTO> ListadoRetorno = new List<LibrosDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibrosDTO();
                dto.Nombre = item.Nombre;
                dto.Autor = item.Autor;
                dto.FechaPublicacion = item.FechaPublicacion;
                dto.idCategoria = item.idCategoria;
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }


        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repositories.LibroRepositorio().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibroConUnidadesDTO();
                dto.Nombre = item.Nombre;
                dto.Autor = item.Autor;
                dto.numOcurrencias = item.numOcurrencias;
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }
    }
}
