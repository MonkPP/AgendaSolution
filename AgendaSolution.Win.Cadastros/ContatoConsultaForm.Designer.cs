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
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            alterarToolStripButton1 = new ToolStripButton();
            excluirToolStripButton2 = new ToolStripButton();
            opcoesFiltroGroupBox1 = new GroupBox();
            novoButton2 = new Button();
            consultarButton1 = new Button();
            nomeTextBox1 = new TextBox();
            label1 = new Label();
            resultadoGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            opcoesFiltroGroupBox1.SuspendLayout();
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
            alterarToolStripButton1.Click += alterarToolStripButton1_Click;
            // 
            // excluirToolStripButton2
            // 
            excluirToolStripButton2.Image = (Image)resources.GetObject("excluirToolStripButton2.Image");
            excluirToolStripButton2.ImageTransparentColor = Color.Magenta;
            excluirToolStripButton2.Name = "excluirToolStripButton2";
            excluirToolStripButton2.Size = new Size(62, 22);
            excluirToolStripButton2.Text = "Excluir";
            // 
            // opcoesFiltroGroupBox1
            // 
            opcoesFiltroGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            opcoesFiltroGroupBox1.Controls.Add(novoButton2);
            opcoesFiltroGroupBox1.Controls.Add(consultarButton1);
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
            // consultarButton1
            // 
            consultarButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            consultarButton1.Location = new Point(434, 47);
            consultarButton1.Name = "consultarButton1";
            consultarButton1.Size = new Size(74, 23);
            consultarButton1.TabIndex = 2;
            consultarButton1.Text = "Consultar";
            consultarButton1.UseVisualStyleBackColor = true;
            consultarButton1.Click += consultaButton1_Click;
            // 
            // nomeTextBox1
            // 
            nomeTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nomeTextBox1.Location = new Point(61, 47);
            nomeTextBox1.Name = "nomeTextBox1";
            nomeTextBox1.Size = new Size(367, 23);
            nomeTextBox1.TabIndex = 1;
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
            Load += ContatoConsultaForm_Load;
            resultadoGroupBox2.ResumeLayout(false);
            resultadoGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            opcoesFiltroGroupBox1.ResumeLayout(false);
            opcoesFiltroGroupBox1.PerformLayout();
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
        private Button consultarButton1;
        private TextBox nomeTextBox1;
        private Label label1;
    }
}