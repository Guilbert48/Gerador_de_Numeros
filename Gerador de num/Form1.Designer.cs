namespace Gerador_de_num
{
    partial class Gerador
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxQtd = new TextBox();
            textBoxRes = new TextBox();
            btnGerar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(218, 67);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 0;
            label1.Text = "Gere seu número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 174);
            label2.Name = "label2";
            label2.Size = new Size(303, 33);
            label2.TabIndex = 1;
            label2.Text = "Quantidade de números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 307);
            label3.Name = "label3";
            label3.Size = new Size(140, 37);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // textBoxQtd
            // 
            textBoxQtd.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxQtd.Location = new Point(108, 210);
            textBoxQtd.Name = "textBoxQtd";
            textBoxQtd.Size = new Size(79, 43);
            textBoxQtd.TabIndex = 3;
            textBoxQtd.TextChanged += textBox1_TextChanged;
            // 
            // textBoxRes
            // 
            textBoxRes.Enabled = false;
            textBoxRes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRes.Location = new Point(103, 347);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(458, 43);
            textBoxRes.TabIndex = 4;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.SeaGreen;
            btnGerar.FlatStyle = FlatStyle.Popup;
            btnGerar.ForeColor = SystemColors.ControlLightLight;
            btnGerar.Location = new Point(108, 462);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(211, 68);
            btnGerar.TabIndex = 5;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkGoldenrod;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.Location = new Point(355, 462);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(211, 68);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Gerador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(650, 614);
            Controls.Add(btnLimpar);
            Controls.Add(btnGerar);
            Controls.Add(textBoxRes);
            Controls.Add(textBoxQtd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gerador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxQtd;
        private TextBox textBoxRes;
        private Button btnGerar;
        private Button btnLimpar;
    }
}
