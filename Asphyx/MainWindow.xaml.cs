using Asphyx.GUIItems;
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

namespace Asphyx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _3DView view = new _3DView();
            _3DView view2 = new _3DView();
            _3DView view3 = new _3DView();
            _3DView view4 = new _3DView();

            modeler3DViewGrid.Children.Add(view);
            modeler3DViewGrid.Children.Add(view2);
            modeler3DViewGrid.Children.Add(view3);
            modeler3DViewGrid.Children.Add(view4);

            //top
            Grid.SetRow(view, 0);
            Grid.SetColumn(view, 0);

            //left
            Grid.SetRow(view2, 0);
            Grid.SetColumn(view2, 1);

            //front
            Grid.SetRow(view3, 1);
            Grid.SetColumn(view3, 0);

            //3d view
            Grid.SetRow(view4, 1);
            Grid.SetColumn(view4, 1);
        }
    }
}
