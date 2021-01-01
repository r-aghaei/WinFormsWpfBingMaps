using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWpfBingMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.userControl11.myMap.AnimationLevel = AnimationLevel.Full;
            this.userControl11.myMap.Loaded += MyMap_Loaded;
        }
        private void MyMap_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var location = new Location(47.604, -122.329);
            this.userControl11.myMap.SetView(location, 12);
        }
    }
}
