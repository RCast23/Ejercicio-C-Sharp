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
            List<Libro> librosDatos = new Datos.Repositories.LibroRepositorio().ObtenerLibros();
            List<LibrosDTO> listadoRetorno = new List<LibrosDTO>();
            foreach (var item in librosDatos)
            {
                var dto = new LibrosDTO();
                Negocio.Utils.parse(item,ref dto);
                //dto.idLibro = item.idLibro;
                //dto.Nombre = item.Nombre;
                //dto.Autor = item.Autor;
                //dto.FechaPublicacion = item.FechaPublicacion;
                //dto.idCategoria = item.idCategoria;
                listadoRetorno.Add(dto);
            }
            return listadoRetorno;
        }


        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> librosDatos = new Datos.Repositories.LibroRepositorio().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> listadoRetorno = new List<LibroConUnidadesDTO>();
            foreach (var item in librosDatos)
            {
                var dto = new LibroConUnidadesDTO();
                Negocio.Utils.parse(item, ref dto);
                //dto.Nombre = item.Nombre;
                //dto.Autor = item.Autor;
                //dto.numOcurrencias = item.numOcurrencias;
                listadoRetorno.Add(dto);
            }
            return listadoRetorno;
        }

        public List<CategoriaDTO> ObtenerCategorias()
        {
            List<Categoria> librosDatos = new Datos.Repositories.LibroRepositorio().ObtenerCategorias();
            List<CategoriaDTO> listadoRetorno = new List<CategoriaDTO>();
            foreach (var item in librosDatos)
            {
                var dto = new CategoriaDTO();
                Negocio.Utils.parse(item, ref dto);
                //dto.Nombre = item.Nombre;
                //dto.idCategoria = item.idCategoria;
                listadoRetorno.Add(dto);
            }
            return listadoRetorno;
        }
        public void AltaLibro(LibrosDTO libroAlta)
        {
            Libro libroBaseDatos = new Libro();
            Negocio.Utils.parse(libroAlta, ref libroBaseDatos);
            //libroBaseDatos.idCategoria = libroAlta.idCategoria;
            //libroBaseDatos.Nombre = libroAlta.Nombre;
            //libroBaseDatos.Autor = libroAlta.Autor;
            //libroBaseDatos.FechaPublicacion = libroAlta.FechaPublicacion;
            new Datos.Repositories.LibroRepositorio().AltaLibro(libroBaseDatos);
        }

        public void ModificarLibro(LibrosDTO libroModificado)
        {
            Libro libroBaseDatos = new Libro();
            Negocio.Utils.parse(libroModificado, ref libroBaseDatos);
            //libroBaseDatos.idLibro = libroModificado.idLibro;
            //libroBaseDatos.idCategoria = libroModificado.idCategoria;
            //libroBaseDatos.Nombre = libroModificado.Nombre;
            //libroBaseDatos.Autor = libroModificado.Autor;
            //libroBaseDatos.FechaPublicacion = libroModificado.FechaPublicacion;

            new Datos.Repositories.LibroRepositorio().ModificarLibro(libroBaseDatos);
        }

        public void EliminarLibro(LibrosDTO libroEliminar)
        {
            new Datos.Repositories.LibroRepositorio().EliminarLibro(libroEliminar.idLibro);
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new Datos.Repositories.LibroRepositorio().VerificarUnidades(idLibro);
        }
    }
}
