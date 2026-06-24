namespace WinFormsApp5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        listView1.View = View.Details;
        listView1.FullRowSelect = true;

        listView1.Columns.Add("Имя", 100);
        listView1.Columns.Add("Возраст", 100);
        listView1.Columns.Add("Город", 100);

        listView1.Items.Add(
            new ListViewItem(new string[] { "Иван", "20", "Москва" }));

        listView1.Items.Add(
            new ListViewItem(new string[] { "Анна", "19", "Минск" }));

        listView1.Items.Add(
            new ListViewItem(new string[] { "Петр", "21", "Киев" }));
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count > 0)
        {
            ListViewItem item = listView1.SelectedItems[0];

            label1.Text = item.SubItems[0].Text;
            label2.Text = item.SubItems[1].Text;
            label3.Text = item.SubItems[2].Text;

            listView1.Items.Remove(item);
        }
        else
        {
            MessageBox.Show("Выберите строку!");
        }
    }
}