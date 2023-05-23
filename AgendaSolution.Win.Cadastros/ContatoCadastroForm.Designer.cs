namespace AgendaSolution.Win.Cadastros
{
    partial class ContatoCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            label1 = new Label();
            nomeTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            telTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(64, 24);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(562, 23);
            nomeTextBox.TabIndex = 1;
            nomeTextBox.TextChanged += nomeTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Tel.:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(374, 68);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(252, 23);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 71);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(470, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(551, 144);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(64, 68);
            telTextBox.Mask = "(99)99999-9999";
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(259, 23);
            telTextBox.TabIndex = 8;
            // 
            // ContatoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 198);
            Controls.Add(telTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nomeTextBox);
            Controls.Add(label1);
            MaximumSize = new Size(677, 237);
            MinimumSize = new Size(677, 237);
            Name = "ContatoCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContatoCadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeTextBox;
        private TextBox textBox2;
        private Label label2;
        private TextBox emailTextBox;
        private Label label3;
        private Button button1;
        private Button button2;
        private MaskedTextBox telTextBox;
    }
}