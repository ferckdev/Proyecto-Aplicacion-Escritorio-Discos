using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;
using Dominio;


namespace Negocio

{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = " Server=MSI\\SQLEXPRESS; database=DISCOS_DB2; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, e.Descripcion Estilo, t.Descripcion TipoEdicion from DISCOS d, ESTILOS e, TIPOSEDICION t where d.IdEstilo = e.Id and d.IdTipoEdicion = t.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["Cantidadcanciones"];
                    aux.UrlimagenTapa = (string)lector["UrlimagenTapa"];
                    aux.Estilo = new Estilos();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Tipoedicion = new TiposEdicion();
                    aux.Tipoedicion.Descripcion = (string)lector["Tipoedicion"];


                    lista.Add(aux);

                }


            conexion.Close();
            return lista;
            }
            catch (Exception)
            {

                throw;
            }



        }
    public void agregar(Disco Nuevo)
    {

    }
    public void modificar(Disco modificar)
    {

    }

        
    }
}
