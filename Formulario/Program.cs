using Entidades;

namespace Formulario
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                FrmLogin frmLogin = new FrmLogin();

                frmLogin.StartPosition = FormStartPosition.CenterScreen;

                int cantidad_intentos = 0;

                try
                {
                    frmLogin.ShowDialog();

                    do
                    {
                        if (cantidad_intentos == 2 && frmLogin.UsuarioDelForm == null)
                        {
                            MessageBox.Show("Cantidad de intentos superada!!!", "ATENCI�N", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            break;
                        }
                        else if (frmLogin.UsuarioDelForm == null)
                        {
                            MessageBox.Show("Error en usuario y/o clave!!!", "CREDENCIALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            frmLogin.ShowDialog();
                        }

                        cantidad_intentos++;


                    } while (cantidad_intentos < 3 && frmLogin.DialogResult != DialogResult.Cancel);

                    //INDICO LA POSICION EN LA PANTALLA
                    if (frmLogin.UsuarioDelForm != null)
                    {
                        FrmMDI frm = new FrmMDI(frmLogin.UsuarioDelForm);
                        frm.StartPosition = FormStartPosition.CenterScreen;

                        //INICIO LA APLICACION
                        Application.Run(frm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("La aplicaci�n termin�.", "FIN APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }





            //    // To customize application configuration such as set high DPI settings or default font,
            //    // see https://aka.ms/applicationconfiguration.
            //    //ApplicationConfiguration.Initialize();
            //    //Application.Run(new FrmPrincipal());
        }
    }
}