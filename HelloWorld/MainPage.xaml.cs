using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace HelloWorld
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Obtener configuración guardada
            ApplicationDataContainer configuraciones = ApplicationData.Current.RoamingSettings;
            if (configuraciones.Values["nombre"] as string != null)
            {
                string configNombre = configuraciones.Values["nombre"] as string;
                miTextBlock.Text = $"¡Hola {configNombre}!";
            }
        }

        private void BtnSaludame_Click(object sender, RoutedEventArgs e)
        {
            string nombre = miTextBox.Text;
            miTextBlock.Text = $"¡Hola {nombre}!";

            //Guardar configuración
            ApplicationDataContainer configuraciones = ApplicationData.Current.RoamingSettings;
            configuraciones.Values["nombre"] = nombre;
        }
    }
}
