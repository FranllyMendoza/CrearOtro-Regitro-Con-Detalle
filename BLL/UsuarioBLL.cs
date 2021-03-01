using CrearOtro_Regitro_Con_Detalle.DAL;
using CrearOtro_Regitro_Con_Detalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtro_Regitro_Con_Detalle.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Usuario usuarios)
        {
            if (!Existe(usuarios.UsuarioId))
                return Insertar(usuarios);
            else
                return Modificar(usuarios);
        }

        private static bool Insertar(Usuario usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuario.Add(usuarios);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Usuario usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuarios).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var usuarios = contexto.Usuario.Find(id);

                if (usuarios != null)
                {
                    contexto.Usuario.Remove(usuarios);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Usuario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuario usuarios;

            try
            {
                usuarios = contexto.Usuario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return usuarios;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuario.Any(e => e.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool ExisteAlias(string pronombre, int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuario.Any(e => e.Alias == pronombre);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontrado)
            {
                Usuario usuarios = Buscar(id);

                if (usuarios == null)
                    return true;

                if (usuarios.Alias == pronombre)
                    encontrado = false;
            }

            return encontrado;
        }

        public static bool ExisteRol(string roles, int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuario.Any(e => e.Rol == roles);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontrado)
            {
                Usuario usuarios = Buscar(id);

                if (usuarios == null)
                    return true;

                if (usuarios.Rol == roles)
                    encontrado = false;
            }

            return encontrado;
        }

        private static List<Usuario> GetList(Expression<Func<Usuario, bool>> criterio)
        {
            List<Usuario> lista = new List<Usuario>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Usuario.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
