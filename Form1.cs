namespace Racing_Project
{
    public partial class Form1 : Form
    {
        int vy = 1;
        int vx = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlHut1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tmrBeschl_Tick(object sender, EventArgs e)
        {
            pnl.Top = pnl.Top + vy;
            panel1.Top = panel1.Top + vy;
            panel4.Top = panel4.Top + vy;
            panel7.Top = panel7.Top + vy;

            //if (vy < 100)
            //{
            //    vy++;
            //}

            label1.Text = "vy: " + vy.ToString() + ", vx: " + vx.ToString();
        }
        private void tmrLinks_Tick(object sender, EventArgs e)
        {

            pnlCar.Left = pnlCar.Left - vx;

            if (vx < 100)
            {
                vx++;
            }

        }


        private void Steuerung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                vy++;
                tmrBeschl.Enabled = true;
                TmrVerz.Enabled = false;
            }

            if (e.KeyCode == Keys.L)
            {
                tmrLinks.Enabled = true;
            }
        }

        private void Steuerung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                //tmrBeschl.Enabled = false;
                //TmrVerz.Enabled = true;
            }

            if (e.KeyCode == Keys.L)
            {
                tmrLinks.Enabled = false;
                vx = 1;

            }

        }

        private void TmrVerz_Tick(object sender, EventArgs e)
        {
            pnl.Top = pnl.Top + vy;
            panel1.Top = panel1.Top + vy;
            panel4.Top = panel4.Top + vy;
            panel7.Top = panel7.Top + vy;

            vy--;

            if (vy==0)
            {
                TmrVerz.Enabled = false;
            }
        }
    }
}
