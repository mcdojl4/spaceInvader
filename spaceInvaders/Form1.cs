namespace spaceInvaders
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Controller controller;

        public Form1()
        {
            InitializeComponent();

            //Sets size of form
            Width = 1000;
            Height = 800;

            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            graphics = CreateGraphics();
            controller = new Controller(ClientSize, bufferGraphics);

            timer1.Enabled = true;
        }

        //Makes game run per tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            controller.Run();
            graphics.DrawImage(bufferImage, 0, 0);
        }

        //Uses keyboard for players to move
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    controller.MoveMothershipByKeys(Direction.LEFT);
                    break;
                case Keys.Right:
                    controller.MoveMothershipByKeys(Direction.RIGHT);
                    break;
                case Keys.Space:
                    controller.ShootBullet();
                    break;
                default:
                    break;
            }
        }
    }
}