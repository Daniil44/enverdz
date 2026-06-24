namespace WinFormsApp5;

public partial class Form1 : Form
{
    Random rnd = new Random();

    int playerScore = 0;
    int computerScore;

    public Form1()
    {
        InitializeComponent();

        computerScore = rnd.Next(15, 22);

        label1.Text = "Игрок: 0";
        label2.Text = "Компьютер: ?";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int card = rnd.Next(2, 12);

        playerScore += card;

        label1.Text = "Игрок: " + playerScore;

        if (playerScore > 21)
        {
            MessageBox.Show("Перебор! Вы проиграли.");
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        label2.Text = "Компьютер: " + computerScore;

        if (playerScore > 21)
        {
            MessageBox.Show("Вы проиграли!");
        }
        else if (playerScore > computerScore)
        {
            MessageBox.Show("Вы выиграли!");
        }
        else if (playerScore < computerScore)
        {
            MessageBox.Show("Компьютер выиграл!");
        }
        else
        {
            MessageBox.Show("Ничья!");
        }

        button1.Enabled = false;
        button2.Enabled = false;
    }
}