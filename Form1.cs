namespace act15_try2_
{
    public partial class Form1 : Form
    {
        int maxDay;
        static int luckyNumber;

        public int getLuckyNumber()
        {
            return luckyNumber;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void birthDay()
        {

            if (comboBox2.SelectedIndex == 1)
            {
                int year = Int32.Parse(comboBox1.Text);
                
                
                if (year % 400 == 0)
                    maxDay = 29;
                
                if (year % 100 == 0)
                    maxDay = 28;
                
                if (year % 4 == 0)
                    maxDay = 29;
                else
                    maxDay = 28;
            }
            else
                maxDay = 30;

            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                for (int i = 0; i < maxDay; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
                comboBox3.Text = maxDay.ToString();
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                
                luckyNumber = (comboBox1.SelectedIndex + comboBox2.SelectedIndex + comboBox3.SelectedIndex + comboBox4.SelectedIndex);
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            
        }
    }
}