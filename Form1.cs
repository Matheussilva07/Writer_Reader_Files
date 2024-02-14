namespace Writer_Reader_Files;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //A variável 'arquivo tem a função de receber o path do arquivo de texto onde será escrito.

        try
        {

            if (radioButton1.Checked == true)
            {
                string pathFile = textBox1.Text;

                using (StreamWriter writer = new StreamWriter(pathFile))
                {
                    writer.WriteLine(richTextBox1.Text);
                }
            }
            if (radioButton2.Checked == true)
            {
                string pathFile = textBox1.Text;

                using (StreamReader reader = new StreamReader(pathFile))
                {
                    string File;

                    File = reader.ReadLine();
                    richTextBox1.Text = File;
                }
            }
        }
        catch(Exception ex) 
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        richTextBox1.Clear();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex == 0)
        {
            richTextBox1.ForeColor = Color.Red;
        }
        if (comboBox1.SelectedIndex == 1)
        {
            richTextBox1.ForeColor = Color.Green;
        }
        if (comboBox1.SelectedIndex == 2)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }
        if (comboBox1.SelectedIndex == 3)
        {
            richTextBox1.ForeColor = Color.Black;
        }
    }

}
//Sintaxe para tratar exceções.

        //try
        //{
        //    VisitLink();
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Unable to open link that was clicked.");
        //}