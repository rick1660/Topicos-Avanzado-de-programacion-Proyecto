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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Gestor_de_gastor
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void BtmPopupSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            BtnOpen.Visibility = Visibility.Collapsed;
            BtnClose.Visibility = Visibility.Visible;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            BtnOpen.Visibility = Visibility.Visible;
            BtnClose.Visibility = Visibility.Collapsed;
        }
       
        
        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnGastos_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new IngresoGastos();
        }

        private void BtnIngresos_Click(object sender, RoutedEventArgs e)
        {
           // Main.Content = new IngresoPresupuesto();
        }

        private void BtnBD_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BalanceDiario();
        }

        private void BtnBS_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Balance_Semanal();
        }

        private void BtnBM_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BalanceMensual();
        }

        private void BtnBC_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Balance_de_cuenta();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new IngresoGastos();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Content = new BalanceDiario();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }

        private void dtTicker(object sender, EventArgs e)
        {
            lblHora.Content = DateTime.Now.ToString();
        }
    }
}
