using Proyecto.Data.Seguridad;
using Proyecto.Models.Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Gestor_de_gastor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Usuario  user = new Usuario();
            ListaUsuario listaUsers = new ListaUsuario();
        }

       


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DataUsuario datauser = new DataUsuario();
           var resultado = datauser.getLogin(txtCorreo.Text, txtPassword.Text);
            if(resultado.NombreUsuario != null) 
            {

                Principal pcl = new Principal();
                pcl.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Error no existe el usuario");
            }
            
           

        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
