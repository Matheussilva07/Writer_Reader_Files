namespace Writer_Reader_Files;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        label1 = new Label();
        richTextBox1 = new RichTextBox();
        button2 = new Button();
        button3 = new Button();
        textBox1 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        comboBox1 = new ComboBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(119, 268);
        button1.Name = "button1";
        button1.Size = new Size(109, 38);
        button1.TabIndex = 0;
        button1.Text = "Select";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(105, 84);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(57, 19);
        radioButton1.TabIndex = 1;
        radioButton1.TabStop = true;
        radioButton1.Text = "Writer";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(176, 84);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(61, 19);
        radioButton2.TabIndex = 2;
        radioButton2.TabStop = true;
        radioButton2.Text = "Reader";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(103, 47);
        label1.Name = "label1";
        label1.Size = new Size(150, 18);
        label1.TabIndex = 3;
        label1.Text = "Writer or Reader?";
        // 
        // richTextBox1
        // 
        richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        richTextBox1.Location = new Point(356, -1);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(583, 548);
        richTextBox1.TabIndex = 4;
        richTextBox1.Text = "";
        // 
        // button2
        // 
        button2.Location = new Point(53, 496);
        button2.Name = "button2";
        button2.Size = new Size(109, 38);
        button2.TabIndex = 5;
        button2.Text = "Exit";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(176, 496);
        button3.Name = "button3";
        button3.Size = new Size(109, 38);
        button3.TabIndex = 6;
        button3.Text = "Clear Text";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(8, 215);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(330, 23);
        textBox1.TabIndex = 7;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(119, 197);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 8;
        label2.Text = "Path of the File:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(69, 134);
        label3.Name = "label3";
        label3.Size = new Size(66, 15);
        label3.TabIndex = 10;
        label3.Text = "Font Color:";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Vermelho", "Verde", "Amarelo", "Preto" });
        comboBox1.Location = new Point(141, 131);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 11;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(936, 546);
        Controls.Add(comboBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(richTextBox1);
        Controls.Add(label1);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Leitor de Arquivos";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private Label label1;
    private RichTextBox richTextBox1;
    private Button button2;
    private Button button3;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
    private ComboBox comboBox1;
}
