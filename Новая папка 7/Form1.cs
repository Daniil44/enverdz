namespace WinFormsApp5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        timer1.Interval = 5000; // каждые 5 секунд
        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        Form scareForm = new Form();

        scareForm.WindowState = FormWindowState.Maximized;
        scareForm.FormBorderStyle = FormBorderStyle.None;
        scareForm.TopMost = true;
        scareForm.BackColor = Color.Red;


        Label text = new Label();

        text.Text = "БУУУ!!!";
        text.Dock = DockStyle.Fill;
        text.TextAlign = ContentAlignment.MiddleCenter;
        text.Font = new Font("Arial", 80, FontStyle.Bold);
        text.ForeColor = Color.White;
        text.BackColor = Color.Black;


        scareForm.Controls.Add(text);

        scareForm.Show();


        Timer closeTimer = new Timer();
        closeTimer.Interval = 2000; // закрыть через 2 секунды

        closeTimer.Tick += (s, a) =>
        {
            scareForm.Close();
            closeTimer.Stop();
        };

        closeTimer.Start();
    }
}