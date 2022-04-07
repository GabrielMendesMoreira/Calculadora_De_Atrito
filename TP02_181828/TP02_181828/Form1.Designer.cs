namespace TP02_181828
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.forcaA = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SAIR = new System.Windows.Forms.Button();
            this.LIMPAR = new System.Windows.Forms.Button();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.coeficiente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.deslocamentto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.angulo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ForcaF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Massa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::TP02_181828.Properties.Resources.engenharia;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.SAIR);
            this.panel6.Controls.Add(this.LIMPAR);
            this.panel6.Controls.Add(this.CALCULAR);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(796, 446);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Navy;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.forcaA);
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.label18);
            this.panel13.Location = new System.Drawing.Point(451, 21);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(321, 95);
            this.panel13.TabIndex = 14;
            // 
            // forcaA
            // 
            this.forcaA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.forcaA.Enabled = false;
            this.forcaA.Location = new System.Drawing.Point(9, 55);
            this.forcaA.Name = "forcaA";
            this.forcaA.Size = new System.Drawing.Size(124, 20);
            this.forcaA.TabIndex = 2;
            this.forcaA.TextChanged += new System.EventHandler(this.forcaA_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(148, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "N";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Navy;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(255, 31);
            this.label18.TabIndex = 0;
            this.label18.Text = "A força de atrito é:";
            // 
            // SAIR
            // 
            this.SAIR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIR.Location = new System.Drawing.Point(596, 372);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(159, 39);
            this.SAIR.TabIndex = 16;
            this.SAIR.Text = "SAIR";
            this.SAIR.UseVisualStyleBackColor = true;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // LIMPAR
            // 
            this.LIMPAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPAR.Location = new System.Drawing.Point(596, 306);
            this.LIMPAR.Name = "LIMPAR";
            this.LIMPAR.Size = new System.Drawing.Size(159, 39);
            this.LIMPAR.TabIndex = 15;
            this.LIMPAR.Text = "LIMPAR";
            this.LIMPAR.UseVisualStyleBackColor = true;
            this.LIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(596, 243);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(159, 39);
            this.CALCULAR.TabIndex = 14;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Navy;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.coeficiente);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Location = new System.Drawing.Point(26, 355);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(257, 68);
            this.panel11.TabIndex = 5;
            // 
            // coeficiente
            // 
            this.coeficiente.Location = new System.Drawing.Point(4, 39);
            this.coeficiente.Name = "coeficiente";
            this.coeficiente.Size = new System.Drawing.Size(100, 20);
            this.coeficiente.TabIndex = 13;
            this.coeficiente.TextChanged += new System.EventHandler(this.coeficiente_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(2, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "Insira coeficiente de atrito:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.deslocamentto);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(26, 268);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(226, 68);
            this.panel9.TabIndex = 5;
            // 
            // deslocamentto
            // 
            this.deslocamentto.Location = new System.Drawing.Point(5, 32);
            this.deslocamentto.Name = "deslocamentto";
            this.deslocamentto.Size = new System.Drawing.Size(100, 20);
            this.deslocamentto.TabIndex = 12;
            this.deslocamentto.TextChanged += new System.EventHandler(this.deslocamentto_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Insira o deslocamento:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Navy;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.angulo);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Location = new System.Drawing.Point(26, 184);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(174, 69);
            this.panel10.TabIndex = 5;
            // 
            // angulo
            // 
            this.angulo.Location = new System.Drawing.Point(5, 37);
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(100, 20);
            this.angulo.TabIndex = 11;
            this.angulo.TextChanged += new System.EventHandler(this.angulo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(108, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "º";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(-1, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Insira o ângulo Θ:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.ForcaF);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(26, 97);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 69);
            this.panel8.TabIndex = 3;
            // 
            // ForcaF
            // 
            this.ForcaF.Location = new System.Drawing.Point(5, 36);
            this.ForcaF.Name = "ForcaF";
            this.ForcaF.Size = new System.Drawing.Size(100, 20);
            this.ForcaF.TabIndex = 10;
            this.ForcaF.TextChanged += new System.EventHandler(this.ForcaF_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(115, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "N";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(2, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Insira a força F:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Navy;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.Massa);
            this.panel12.Controls.Add(this.label16);
            this.panel12.Controls.Add(this.label17);
            this.panel12.Location = new System.Drawing.Point(26, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(151, 69);
            this.panel12.TabIndex = 4;
            // 
            // Massa
            // 
            this.Massa.Location = new System.Drawing.Point(5, 36);
            this.Massa.Name = "Massa";
            this.Massa.Size = new System.Drawing.Size(100, 20);
            this.Massa.TabIndex = 9;
            this.Massa.TextChanged += new System.EventHandler(this.Massa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Insira a massa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(111, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CALCULADORA DE FORÇA DE ATRITO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox forcaA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.Button LIMPAR;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox coeficiente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox deslocamentto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox angulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox ForcaF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox Massa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
    }
}

