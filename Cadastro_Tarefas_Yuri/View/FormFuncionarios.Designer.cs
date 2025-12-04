namespace Cadastro_Tarefas_Yuri.View
{
    partial class FormFuncionarios
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridViewTabelaFuncionario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaFuncionario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Location = new System.Drawing.Point(834, 97);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 37);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridViewTabelaFuncionario
            // 
            this.dataGridViewTabelaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaFuncionario.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewTabelaFuncionario.Name = "dataGridViewTabelaFuncionario";
            this.dataGridViewTabelaFuncionario.Size = new System.Drawing.Size(897, 203);
            this.dataGridViewTabelaFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(262, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(52, 113);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(124, 20);
            this.txtNomeFuncionario.TabIndex = 4;
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(269, 113);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(124, 20);
            this.txtEmailFuncionario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(543, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCargoFuncionario
            // 
            this.comboBoxCargoFuncionario.FormattingEnabled = true;
            this.comboBoxCargoFuncionario.Items.AddRange(new object[] {
            "Estagiário",
            "Assistente",
            "Analista",
            "Gerente",
            "Diretor"});
            this.comboBoxCargoFuncionario.Location = new System.Drawing.Point(508, 113);
            this.comboBoxCargoFuncionario.Name = "comboBoxCargoFuncionario";
            this.comboBoxCargoFuncionario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargoFuncionario.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(722, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matrícula";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(690, 114);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(124, 20);
            this.txtIDFuncionario.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaInicialToolStripMenuItem,
            this.cadastrarTarefasToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // telaInicialToolStripMenuItem
            // 
            this.telaInicialToolStripMenuItem.Name = "telaInicialToolStripMenuItem";
            this.telaInicialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telaInicialToolStripMenuItem.Text = "Tela Inicial";
            this.telaInicialToolStripMenuItem.Click += new System.EventHandler(this.telaInicialToolStripMenuItem_Click_1);
            // 
            // cadastrarTarefasToolStripMenuItem
            // 
            this.cadastrarTarefasToolStripMenuItem.Name = "cadastrarTarefasToolStripMenuItem";
            this.cadastrarTarefasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarTarefasToolStripMenuItem.Text = "Cadastrar tarefas";
            this.cadastrarTarefasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTarefasToolStripMenuItem_Click_1);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCargoFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTabelaFuncionario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaFuncionario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridViewTabelaFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCargoFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTarefasToolStripMenuItem;
    }
}