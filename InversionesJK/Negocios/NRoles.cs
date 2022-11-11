﻿using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NRol
    {
        #region Agregar
        public int Agregar(ERoles obj, int Usuario)
        {
            try
            {
                DRol db = new DRol();
                return db.Agregar(obj, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AgregarPermisos(List<EPermisos> obj, int Idrol)
        {
            try
            {
                DPermisos db = new DPermisos();
                return db.Agregar(obj, Idrol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(ERoles obj, int Idusuario)
        {
            try
            {
                DRol db = new DRol();
                return db.Modificar(obj, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int Idusuario)
        {
            try
            {
                DRol db = new DRol();
                return db.Eliminar(ID, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar Unico
        public List<ERoles> Mostrar()
        {
            try
            {
                DRol db = new DRol();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EPermisos> llenar_Permisos(int ID)
        {
            try
            {
                DPermisos db = new DPermisos();
                return db.Mostrar(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EPermisos> llenar_Permisos(int ID, string Modulo)
        {
            try
            {
                DPermisos db = new DPermisos();
                return db.Mostrar(ID, Modulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
