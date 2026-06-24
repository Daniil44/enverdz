namespace WinFormsApp3;

public partial class Form1 : Form
{
    private Color[] colors =
    {
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Yellow,
        Color.Orange,
        Color.Purple,
        Color.Pink,
        Color.Brown,
        Color.Black,
        Color.Cyan
    };

    private int colorIndex = 0;

    public Form1()
    {
        InitializeComponent();

        timer1.Interval = 1000; 
        timer1.Start();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label1.ForeColor = colors[colorIndex];
        colorIndex = (colorIndex + 1) % colors.Length;
    }
}