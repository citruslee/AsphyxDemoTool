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
using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.Windows;

namespace Asphyx.GUIItems
{
    /// <summary>
    /// Interaction logic for _3DView.xaml
    /// </summary>
    public partial class _3DView : UserControl
    {
        private readonly MiniCubeGame game;

        public _3DView()
        {
            InitializeComponent();
            game = new MiniCubeGame();
            game.Run(surface);
        }

    }
}
