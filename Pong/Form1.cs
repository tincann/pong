using System.Threading;
using System.Windows.Forms;
using Pong.Game;

namespace Pong.Visualisation
{
    public partial class Form1 : Form
    {
        private readonly GameRunner _game;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            _game = new GameRunner(ClientSize.Width, ClientSize.Height);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var drawer = new EntityDrawer(e.Graphics);
            _game.Tick(drawer);

            Thread.Sleep(1000 / 60);
            Invalidate();
        }
    }
}
