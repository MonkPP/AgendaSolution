namespace AgendaSolution.Win.Cadastros
{
    partial class ContatoConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContatoConsultaForm));
            resultadoGroupBox2 = new GroupBox();
            opcoesFiltroGroupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            alterarToolStripButton1 = new ToolStripButton();
            excluirToolStripButton2 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            nomeTextBox1 = new TextBox();
            consultaButton1 = new Button();
            novoButton2 = new Button();
            resultadoGroupBox2.SuspendLayout();
            opcoesFiltroGroupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // resultadoGroupBox2
            // 
            resultadoGroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultadoGroupBox2.Controls.Add(dataGridView1);
            resultadoGroupBox2.Controls.Add(toolStrip1);
            resultadoGroupBox2.Location = new Point(0, 130);
            resultadoGroupBox2.Name = "resultadoGroupBox2";
            resultadoGroupBox2.Size = new Size(599, 314);
            resultadoGroupBox2.TabIndex = 1;
            resultadoGroupBox2.TabStop = false;
            resultadoGroupBox2.Text = "Resultado";
            // 
            // opcoesFiltroGroupBox1
            // 
            opcoesFiltroGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            opcoesFiltroGroupBox1.Controls.Add(novoButton2);
            opcoesFiltroGroupBox1.Controls.Add(consultaButton1);
            opcoesFiltroGroupBox1.Controls.Add(nomeTextBox1);
            opcoesFiltroGroupBox1.Controls.Add(label1);
            opcoesFiltroGroupBox1.Location = new Point(0, 0);
            opcoesFiltroGroupBox1.Name = "opcoesFiltroGroupBox1";
            opcoesFiltroGroupBox1.Size = new Size(599, 124);
            opcoesFiltroGroupBox1.TabIndex = 0;
            opcoesFiltroGroupBox1.TabStop = false;
            opcoesFiltroGroupBox1.Text = "Opcções de Filtro";
            opcoesFiltroGroupBox1.Enter += groupBox1_Enter;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { alterarToolStripButton1, excluirToolStripButton2 });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(593, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // alterarToolStripButton1
            // 
            alterarToolStripButton1.Image = (Image)resources.GetObject("alterarToolStripButton1.Image");
            alterarToolStripButton1.ImageTransparentColor = Color.Magenta;
            alterarToolStripButton1.Name = "alterarToolStripButton1";
            alterarToolStripButton1.Size = new Size(62, 22);
            alterarToolStripButton1.Text = "Alterar";
            // 
            // excluirToolStripButton2
            // 
            excluirToolStripButton2.Image = (Image)resources.GetObject("excluirToolStripButton2.Image");
            excluirToolStripButton2.ImageTransparentColor = Color.Magenta;
            excluirToolStripButton2.Name = "excluirToolStripButton2";
            excluirToolStripButton2.Size = new Size(62, 22);
            excluirToolStripButton2.Text = "Excluir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(593, 267);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // nomeTextBox1
            // 
            nomeTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nomeTextBox1.Location = new Point(61, 47);
            nomeTextBox1.Name = "nomeTextBox1";
            nomeTextBox1.Size = new Size(367, 23);
            nomeTextBox1.TabIndex = 1;
            // 
            // consultaButton1
            // 
            consultaButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            consultaButton1.Location = new Point(434, 47);
            consultaButton1.Name = "consultaButton1";
            consultaButton1.Size = new Size(74, 23);
            consultaButton1.TabIndex = 2;
            consultaButton1.Text = "Consulta";
            consultaButton1.UseVisualStyleBackColor = true;
            // 
            // novoButton2
            // 
            novoButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            novoButton2.Location = new Point(515, 46);
            novoButton2.Name = "novoButton2";
            novoButton2.Size = new Size(74, 23);
            novoButton2.TabIndex = 3;
            novoButton2.Text = "Novo";
            novoButton2.UseVisualStyleBackColor = true;
            novoButton2.Click += novoButton2_Click;
            // 
            // ContatoConsultaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 441);
            Controls.Add(resultadoGroupBox2);
            Controls.Add(opcoesFiltroGroupBox1);
            MinimumSize = new Size(617, 480);
            Name = "ContatoConsultaForm";
            Text = "Consulta";
            resultadoGroupBox2.ResumeLayout(false);
            resultadoGroupBox2.PerformLayout();
            opcoesFiltroGroupBox1.ResumeLayout(false);
            opcoesFiltroGroupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox resultadoGroupBox2;
        private GroupBox opcoesFiltroGroupBox1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton alterarToolStripButton1;
        private ToolStripButton excluirToolStripButton2;
        private Button novoButton2;
        private Button consultaButton1;
        private TextBox nomeTextBox1;
        private Label label1;
    }
}