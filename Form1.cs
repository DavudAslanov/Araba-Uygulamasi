namespace Araba_Uygulamasi
{
    public partial class Form1 : Form
    {
        bool isGasOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void breakPanel11_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void breakPanel10_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGasOpen)
            {
                car.Location = new Point(car.Location.X, car.Location.Y - 3);
            }
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(!isGasOpen)
            {
                car.Location=new Point(car.Location.X,car.Location.Y+3);
            }
        }
    }
}