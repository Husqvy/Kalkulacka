namespace Kalkulacka_forms
{
    public partial class Kalkulaèka : Form
    {
        Decimal resultValue = 0;
        String Operace = "";
        bool isOperace = false;
        public Kalkulaèka()
        {
            InitializeComponent();
        }

        private void Kalkulaèka_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
               private void Button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperace))
                textBox1.Clear();


            isOperace = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;
            }else

            textBox1.Text = textBox1.Text + button.Text;

        }

        private void Operace_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button13.PerformClick();

                Operace = button.Text;
                isOperace = true;
                priklad.Text = resultValue + " " + Operace;

            }
            else
            {
                Operace = button.Text;
                resultValue = Decimal.Parse(textBox1.Text);
                isOperace = true;
                priklad.Text = resultValue + " " + Operace;
            }
        }


       private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
        }
       
        private void button13_Click(object sender, EventArgs e)
        {
            switch (Operace)
            {
                case "+":
                    textBox1.Text = (resultValue + Decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Decimal.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Decimal.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Decimal.Parse((string)textBox1.Text);
            priklad.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1 .Text = "0";
            resultValue = 0;
        }
    }
}
