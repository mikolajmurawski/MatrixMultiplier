namespace MatrixMultiplier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            if (int.TryParse(textbox_m1c.Text, out a) && int.TryParse(textbox_m2r.Text, out b) && int.TryParse(textbox_m1r.Text, out c) && int.TryParse(textbox_m2c.Text, out d) && a == b)
            {
                Form2 form2 = new Form2(c, a, b, d);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Enter intiger numbers and ensure, that the first matrix column number equals to the second matrix row number.", "Error");
            }
        }        
    }
}