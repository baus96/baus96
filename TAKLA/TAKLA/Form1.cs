namespace TAKLA
{
    public partial class giriþ : Form
    {
        public giriþ()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;    
            giriþTimer.Start();
        }

        private void giriþTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1) 
            {
                this.Opacity += 0.01;
            }
            
            if (this.Opacity == 1)
            {
                giriþTimer.Stop();
                Thread.Sleep(2500);
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            
           
        }

        private void giriþ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}