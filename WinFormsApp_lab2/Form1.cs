namespace WinFormsApp_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp1, temp2, temp3, out_p;
            temp1 = int.Parse(GlobalVariables.Cost_1);
            //temp2 = int.Parse(GlobalVariables.Cost_2);
            temp3 = int.Parse(GlobalVariables.Cost_3);
            out_p = temp1 + /*temp2 +*/ temp3;
            GlobalVariables.Cost_4 = out_p.ToString();
            button2.Text = GlobalVariables.Cost_4;
        }
    }
}
