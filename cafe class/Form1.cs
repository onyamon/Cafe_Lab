namespace cafe_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CoffeeMachine machine = new CoffeeMachine();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//black coffee
            if (machine.makeBlackCoffee())


            {
                pic.Image = Properties.Resources.black;
            }
            else
            {
                MessageBox.Show("���������������ԡ��");
                pic.Visible = false;// ����ʴ��ٻ�Ҿ
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //chocolate
            if (machine.makechocolate())
            {
                pic.Image = Properties.Resources.chocolate;

            }
            else
            {
                MessageBox.Show("���������������ԡ��");
                pic.Visible = false;// ����ʴ��ٻ�Ҿ
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //latte
            if (machine.makeLatte())
            {
                pic.Image = Properties.Resources.Hot_Latte;

            }
            else
            {
                MessageBox.Show("���������������ԡ��");
                pic.Visible = false;// ����ʴ��ٻ�Ҿ
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mocka
            if (machine.makemocha())
            {
                pic.Image = Properties.Resources.mocha;

            }
            else
            {
                MessageBox.Show("���������������ԡ��");
                pic.Visible = false;// ����ʴ��ٻ�Ҿ
            }
        }
    }
}
