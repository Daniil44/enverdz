namespace WinFormsApp5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        progressBar1.Maximum = 100;
        progressBar2.Maximum = 100;
        progressBar3.Maximum = 100;

        progressBar1.Value = 100;
        progressBar2.Value = 100;
        progressBar3.Value = 100;

        timer1.Interval = 1000;
        timer1.Start();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (progressBar1.Value <= 90)
            progressBar1.Value += 10;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (progressBar2.Value <= 90)
            progressBar2.Value += 10;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (progressBar3.Value <= 90)
            progressBar3.Value += 10;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        progressBar1.Value--;
        progressBar2.Value--;
        progressBar3.Value--;

        if (progressBar1.Value == 0 ||
            progressBar2.Value == 0 ||
            progressBar3.Value == 0)
        {
            timer1.Stop();

            MessageBox.Show("Питомец умер!");

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}