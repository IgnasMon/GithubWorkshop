namespace WeLearntoUseGithubTheGayWay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(Input1.Text);
            double input2 = Convert.ToDouble(Input2.Text);
            double answer = input1 * input2;
            Answer_text.Text = answer.ToString();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(Input1.Text);
            double input2 = Convert.ToDouble(Input2.Text);
            double answer = input1 / input2;
            Answer_text.Text = answer.ToString();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(Input1.Text);
            double input2 = Convert.ToDouble(Input2.Text);
            double answer = input1 - input2;
            Answer_text.Text = answer.ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(Input1.Text);
            double input2 = Convert.ToDouble(Input2.Text);
            double answer = input1 + input2;
            Answer_text.Text = answer.ToString();
        }
    }
}