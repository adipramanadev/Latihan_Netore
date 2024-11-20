namespace WindowsFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void Button1_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        MessageBox.Show($"Halo, {name}!", "Pesan");
    }

}
