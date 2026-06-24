namespace WinFormsApp5;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        timer1 = new System.Windows.Forms.Timer(components);
        listView1 = new System.Windows.Forms.ListView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Location = new System.Drawing.Point(109, 96);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(121, 97);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(434, 96);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(434, 133);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 2;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(434, 170);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 3;
        label3.Text = "label3";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(109, 243);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 4;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(listView1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.Timer timer1;

    #endregion
}