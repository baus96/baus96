namespace TAKLA
{
    public partial class giri� : Form
    {
        public giri�()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;    
            giri�Timer.Start();
        }

        private void giri�Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1) 
            {
                this.Opacity += 0.01;
            }
            
            if (this.Opacity == 1)
            {
                giri�Timer.Stop();
                Thread.Sleep(2500);
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            
           
        }

        private void giri�_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}