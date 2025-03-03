namespace tp3
{
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
            OUTPUT = new Button();
            INPUT = new Button();
            button = new Button();
            tb_input_nama = new TextBox();
            action_panel = new Panel();
            output_nama = new Label();
            masukkan_nama = new Label();
            action_panel.SuspendLayout();
            SuspendLayout();
            // 
            // OUTPUT
            // 
            OUTPUT.BackColor = Color.OrangeRed;
            OUTPUT.BackgroundImageLayout = ImageLayout.None;
            OUTPUT.FlatStyle = FlatStyle.Popup;
            OUTPUT.ForeColor = SystemColors.ButtonHighlight;
            OUTPUT.Location = new Point(32, 360);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(731, 51);
            OUTPUT.TabIndex = 0;
            OUTPUT.Text = "OUTPUT";
            OUTPUT.UseVisualStyleBackColor = false;
            OUTPUT.Click += OUTPUT_Click;
            // 
            // INPUT
            // 
            INPUT.BackColor = Color.OrangeRed;
            INPUT.BackgroundImageLayout = ImageLayout.None;
            INPUT.FlatStyle = FlatStyle.Popup;
            INPUT.ForeColor = SystemColors.ButtonHighlight;
            INPUT.Location = new Point(30, 276);
            INPUT.Name = "INPUT";
            INPUT.Size = new Size(516, 51);
            INPUT.TabIndex = 1;
            INPUT.Text = "INPUT";
            INPUT.UseVisualStyleBackColor = false;
            INPUT.Click += INPUT_Click;
            // 
            // button
            // 
            button.BackColor = Color.OrangeRed;
            button.BackgroundImageLayout = ImageLayout.None;
            button.FlatStyle = FlatStyle.Popup;
            button.ForeColor = SystemColors.ButtonHighlight;
            button.Location = new Point(575, 276);
            button.Name = "button";
            button.Size = new Size(186, 51);
            button.TabIndex = 2;
            button.Text = "button";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // tb_input_nama
            // 
            tb_input_nama.BackColor = Color.WhiteSmoke;
            tb_input_nama.BorderStyle = BorderStyle.FixedSingle;
            tb_input_nama.Location = new Point(226, 61);
            tb_input_nama.Name = "tb_input_nama";
            tb_input_nama.Size = new Size(338, 31);
            tb_input_nama.TabIndex = 3;
            tb_input_nama.TextChanged += textBox1_TextChanged;
            // 
            // action_panel
            // 
            action_panel.BackColor = SystemColors.ButtonHighlight;
            action_panel.Controls.Add(output_nama);
            action_panel.Controls.Add(masukkan_nama);
            action_panel.Controls.Add(tb_input_nama);
            action_panel.Location = new Point(104, 73);
            action_panel.Name = "action_panel";
            action_panel.Size = new Size(598, 150);
            action_panel.TabIndex = 4;
            action_panel.Paint += action_panel_Paint;
            // 
            // output_nama
            // 
            output_nama.AutoSize = true;
            output_nama.Location = new Point(280, 63);
            output_nama.Name = "output_nama";
            output_nama.Size = new Size(0, 25);
            output_nama.TabIndex = 5;
            // 
            // masukkan_nama
            // 
            masukkan_nama.AutoSize = true;
            masukkan_nama.Location = new Point(60, 63);
            masukkan_nama.Name = "masukkan_nama";
            masukkan_nama.Size = new Size(150, 25);
            masukkan_nama.TabIndex = 4;
            masukkan_nama.Text = "Masukkan nama: ";
            masukkan_nama.Click += masukkan_nama_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 466);
            Controls.Add(action_panel);
            Controls.Add(button);
            Controls.Add(INPUT);
            Controls.Add(OUTPUT);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            action_panel.ResumeLayout(false);
            action_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OUTPUT;
        private Button INPUT;
        private Button button;
        private TextBox tb_input_nama;
        private Panel action_panel;
        private Label masukkan_nama;
        private Label output_nama;
    }
}
