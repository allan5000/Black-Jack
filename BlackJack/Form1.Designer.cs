
namespace BlackJack
{
    partial class Form_jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_jogo));
            this.btn_jogar_1 = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Pontos_A = new System.Windows.Forms.Label();
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.btn_parar_1 = new System.Windows.Forms.Button();
            this.btn_parar_2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar_2 = new System.Windows.Forms.Button();
            this.lbl_Pontos_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_jogador2 = new System.Windows.Forms.Label();
            this.label_Jogador1 = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.Nick = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jogar_1
            // 
            this.btn_jogar_1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_jogar_1.Location = new System.Drawing.Point(26, 452);
            this.btn_jogar_1.Name = "btn_jogar_1";
            this.btn_jogar_1.Size = new System.Drawing.Size(110, 29);
            this.btn_jogar_1.TabIndex = 0;
            this.btn_jogar_1.Text = "Jogar";
            this.btn_jogar_1.UseVisualStyleBackColor = true;
            this.btn_jogar_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reiniciar.Location = new System.Drawing.Point(300, 478);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(110, 28);
            this.btn_reiniciar.TabIndex = 1;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Pontos_A
            // 
            this.lbl_Pontos_A.AutoSize = true;
            this.lbl_Pontos_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pontos_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_A.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Pontos_A.Location = new System.Drawing.Point(129, 55);
            this.lbl_Pontos_A.Name = "lbl_Pontos_A";
            this.lbl_Pontos_A.Size = new System.Drawing.Size(25, 25);
            this.lbl_Pontos_A.TabIndex = 3;
            this.lbl_Pontos_A.Text = "0";
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.AutoSize = true;
            this.lbl_legenda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legenda.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_legenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_legenda.Location = new System.Drawing.Point(327, 19);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(57, 28);
            this.lbl_legenda.TabIndex = 4;
            this.lbl_legenda.Text = "Placar:";
            // 
            // btn_parar_1
            // 
            this.btn_parar_1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_parar_1.Location = new System.Drawing.Point(162, 452);
            this.btn_parar_1.Name = "btn_parar_1";
            this.btn_parar_1.Size = new System.Drawing.Size(110, 29);
            this.btn_parar_1.TabIndex = 5;
            this.btn_parar_1.Text = "Parar";
            this.btn_parar_1.UseVisualStyleBackColor = true;
            this.btn_parar_1.Click += new System.EventHandler(this.btn_parar_1_Click);
            // 
            // btn_parar_2
            // 
            this.btn_parar_2.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_parar_2.Location = new System.Drawing.Point(579, 452);
            this.btn_parar_2.Name = "btn_parar_2";
            this.btn_parar_2.Size = new System.Drawing.Size(110, 29);
            this.btn_parar_2.TabIndex = 8;
            this.btn_parar_2.Text = "Parar";
            this.btn_parar_2.UseVisualStyleBackColor = true;
            this.btn_parar_2.Click += new System.EventHandler(this.btn_parar_2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(443, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 353);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar_2
            // 
            this.btn_jogar_2.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_jogar_2.Location = new System.Drawing.Point(443, 452);
            this.btn_jogar_2.Name = "btn_jogar_2";
            this.btn_jogar_2.Size = new System.Drawing.Size(110, 29);
            this.btn_jogar_2.TabIndex = 6;
            this.btn_jogar_2.Text = "Jogar";
            this.btn_jogar_2.UseVisualStyleBackColor = true;
            this.btn_jogar_2.Click += new System.EventHandler(this.btn_jogar_2_Click);
            // 
            // lbl_Pontos_B
            // 
            this.lbl_Pontos_B.AutoSize = true;
            this.lbl_Pontos_B.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pontos_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_B.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Pontos_B.Location = new System.Drawing.Point(547, 55);
            this.lbl_Pontos_B.Name = "lbl_Pontos_B";
            this.lbl_Pontos_B.Size = new System.Drawing.Size(25, 25);
            this.lbl_Pontos_B.TabIndex = 9;
            this.lbl_Pontos_B.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(349, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // label_jogador2
            // 
            this.label_jogador2.AutoSize = true;
            this.label_jogador2.BackColor = System.Drawing.Color.Transparent;
            this.label_jogador2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_jogador2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_jogador2.Location = new System.Drawing.Point(533, 22);
            this.label_jogador2.Name = "label_jogador2";
            this.label_jogador2.Size = new System.Drawing.Size(70, 24);
            this.label_jogador2.TabIndex = 12;
            this.label_jogador2.Text = "Jogador 2";
            this.label_jogador2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Jogador1
            // 
            this.label_Jogador1.AutoSize = true;
            this.label_Jogador1.BackColor = System.Drawing.Color.Transparent;
            this.label_Jogador1.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_Jogador1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Jogador1.Location = new System.Drawing.Point(112, 22);
            this.label_Jogador1.Name = "label_Jogador1";
            this.label_Jogador1.Size = new System.Drawing.Size(70, 24);
            this.label_Jogador1.TabIndex = 13;
            this.label_Jogador1.Text = "Jogador 1";
            this.label_Jogador1.Click += new System.EventHandler(this.Jogador1_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastro.Location = new System.Drawing.Point(285, 121);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(143, 29);
            this.btn_cadastro.TabIndex = 14;
            this.btn_cadastro.Text = "Cadastro dos jogadores";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Nick
            // 
            this.Nick.Location = new System.Drawing.Point(303, 165);
            this.Nick.Name = "Nick";
            this.Nick.PlaceholderText = "Digite seu nick";
            this.Nick.Size = new System.Drawing.Size(107, 23);
            this.Nick.TabIndex = 15;
            this.Nick.Visible = false;
            this.Nick.TextChanged += new System.EventHandler(this.textBox1_nome_TextChanged);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrar.Location = new System.Drawing.Point(318, 203);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 29);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Visible = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Resultado.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resultado.Location = new System.Drawing.Point(303, 272);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(21, 19);
            this.Resultado.TabIndex = 17;
            this.Resultado.Text = "ㅤ";
            // 
            // Form_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 541);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.label_Jogador1);
            this.Controls.Add(this.label_jogador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pontos_B);
            this.Controls.Add(this.btn_parar_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_jogar_2);
            this.Controls.Add(this.btn_parar_1);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.lbl_Pontos_A);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_jogar_1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_jogo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form_jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jogar_1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Pontos_A;
        private System.Windows.Forms.Label lbl_legenda;
        private System.Windows.Forms.Button btn_parar_1;
        private System.Windows.Forms.Button btn_parar_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar_2;
        private System.Windows.Forms.Label lbl_Pontos_B;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label_jogador2;
#pragma warning disable CS0169 // O campo "Form_jogo.Jogador1" nunca é usado
        private System.Windows.Forms.Label Jogador1;
#pragma warning restore CS0169 // O campo "Form_jogo.Jogador1" nunca é usado
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label_Jogador1;
        private System.Windows.Forms.Label Resultado;
    }
}

