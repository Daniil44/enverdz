namespace WinFormsApp5;

public partial class Form1 : Form
{
    Image img;

    public Form1()
    {
        InitializeComponent();

        img = Image.FromFile("image.jpg");

        pictureBox1.Image = img;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        trackBar1.Minimum = 50;
        trackBar1.Maximum = 300;
        trackBar1.Value = 100;
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        int size = trackBar1.Value;

        pictureBox1.Width = size;
        pictureBox1.Height = size;
    }
}