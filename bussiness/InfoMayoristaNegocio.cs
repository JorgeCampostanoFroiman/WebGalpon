﻿using domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class InfoMayoristaNegocio
    {
        public List<InfoMayorista> Listar()
        {
            List<InfoMayorista> lista = new List<InfoMayorista>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Titulo, Descripcion, Descripcion2, IdInfo from InfoMayorista");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    InfoMayorista aux = new InfoMayorista();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Descripcion2 = (string)datos.Lector["Descripcion2"];
                    aux.IdInfo = (int)datos.Lector["IdInfo"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void AgregarInfo(string titulo, string desc, string desc2)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into InfoMayorista(Titulo, Descripcion, Descripcion2) values('" + titulo + "','" + desc + "','" + desc2 + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarInfo(string titulo, string desc, string desc2, int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update InfoMayorista \r\n set Titulo = '" + titulo + "', Descripcion = '" +desc+ "'  , Descripcion2 = '" + desc2 + "'\r\nWhere IdInfo = "+id+"");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void EliminarInfo(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from InfoMayorista where IdInfo = "+codigo);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
