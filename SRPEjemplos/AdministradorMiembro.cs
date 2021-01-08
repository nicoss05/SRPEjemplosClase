using System;

namespace SRPEjemplos
{
    public class AdministradorMiembro
    {
        public void Aumentar(String nombre, String apellido, String cedula)
        {
            try
            {
                System.IO.File.AppendAllText("\\datos\\data.txt",
                    string.Format("nombre:{0},apellido:{1},cedula{2}", nombre, apellido, cedula));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Fail(ex.Message);
            }
        }

        public void Eliminar(string cedula)
        {
            //aqui va el codigo
        }
    }
}