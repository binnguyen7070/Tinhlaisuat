namespace Tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double tiengui = Convert.ToDouble(txttiengui.Text);
            double laisuat = Convert.ToDouble(txtlaisuat.Text) / 100;
            double sonam = Convert.ToDouble(txtsonam.Text);

            double tienlai = tiengui * laisuat * sonam;
            double tongsotien = tiengui + tienlai;

            lbltongtien.Text = tongsotien.ToString();
            lbltienlai.Text = tienlai.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
