namespace HW;

public partial class Form1 : Form
{
    private HashSet<string> deletedItems = new HashSet<string>();

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string text = textBox1.Text.Trim();

        if (text == "")
        {
            MessageBox.Show("Введите текст!");
            return;
        }

        if (deletedItems.Contains(text))
        {
            MessageBox.Show("Этот элемент уже удалялся и не может быть добавлен снова!");
            return;
        }

        listBox1.Items.Add(text);
        textBox1.Clear();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem != null)
        {
            string item = listBox1.SelectedItem.ToString();

            deletedItems.Add(item); 
            listBox1.Items.Remove(item);
        }
    }
}