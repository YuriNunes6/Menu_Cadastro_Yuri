namespace Cadastro_Tarefas_Yuri
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.boxStatusTarefa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTarefas = new System.Windows.Forms.DataGridView();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeTarefa = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnConfirmar.Location = new System.Drawing.Point(809, 81);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 42);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Adicionar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // boxStatusTarefa
            // 
            this.boxStatusTarefa.FormattingEnabled = true;
            this.boxStatusTarefa.Items.AddRange(new object[] {
            "Concluída",
            "Em andamento",
            "Pendente"});
            this.boxStatusTarefa.Location = new System.Drawing.Point(575, 102);
            this.boxStatusTarefa.Name = "boxStatusTarefa";
            this.boxStatusTarefa.Size = new System.Drawing.Size(121, 21);
            this.boxStatusTarefa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(237, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Tarefa:";
            // 
            // dataGridViewTarefas
            // 
            this.dataGridViewTarefas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTarefas.Location = new System.Drawing.Point(32, 129);
            this.dataGridViewTarefas.Name = "dataGridViewTarefas";
            this.dataGridViewTarefas.Size = new System.Drawing.Size(852, 309);
            this.dataGridViewTarefas.TabIndex = 3;
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Location = new System.Drawing.Point(235, 103);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTarefa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(433, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data:";
            // 
            // dateTimeTarefa
            // 
            this.dateTimeTarefa.Location = new System.Drawing.Point(353, 103);
            this.dateTimeTarefa.Name = "dateTimeTarefa";
            this.dateTimeTarefa.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTarefa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(612, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(99, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(739, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadastro de Tarefas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaInicialToolStripMenuItem,
            this.cadastrarFuncionariosToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // telaInicialToolStripMenuItem
            // 
            this.telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            this.telaInicialToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.telaInicialToolStripMenuItem.Text = "Tela Inicial";
            this.telaInicialToolStripMenuItem.Click += new System.EventHandler(this.telaInicialToolStripMenuItem_Click_1);
            // 
            // cadastrarFuncionariosToolStripMenuItem
            // 
            this.cadastrarFuncionariosToolStripMenuItem.Name = "cadastrarFuncionariosToolStripMenuItem";
            this.cadastrarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cadastrarFuncionariosToolStripMenuItem.Text = "Cadastrar funcionários";
            this.cadastrarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionariosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeTarefa);
            this.Controls.Add(this.dataGridViewTarefas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxStatusTarefa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox boxStatusTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTarefas;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeTarefa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionariosToolStripMenuItem;
    }
}

