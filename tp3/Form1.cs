namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OUTPUT_Click(object sender, EventArgs e)
        {
            masukkan_nama.Visible = false;
            tb_input_nama.Visible = false;
            output_nama.Visible = true;
            button.Enabled = false;
            tb_input_nama.Clear();

        }

        private void INPUT_Click(object sender, EventArgs e)
        {
            masukkan_nama.Visible = true;
            tb_input_nama.Visible = true;
            output_nama.Visible = false;
            button.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            output_nama.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void action_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            button.Enabled = true;
            if (tb_input_nama.Text.Length <= 0)
            {
                button.Enabled = false;
                String nama = tb_input_nama.Text;
                output_nama.Text = "NAMA KOSONG";
            }
            else
            {
                button.Enabled = true;
                String nama = tb_input_nama.Text;
                output_nama.Text = "Halo " + nama;
                tb_input_nama.Clear();
            }

        }

        private void masukkan_nama_Click(object sender, EventArgs e)
        {
            masukkan_nama.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button.Visible = true;
            masukkan_nama.Visible = false;
            tb_input_nama.Visible = false;
            output_nama.Visible = false;
            action_panel.Visible = true; 
        }
    }
}
