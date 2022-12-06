
namespace SemaForms
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
            this.components = new System.ComponentModel.Container();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.grpAuto = new System.Windows.Forms.GroupBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.btnCiclo = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tmrCiclo = new System.Windows.Forms.Timer(this.components);
            this.grpManual = new System.Windows.Forms.GroupBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.btnVerm = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.radRua2 = new System.Windows.Forms.RadioButton();
            this.radRua1 = new System.Windows.Forms.RadioButton();
            this.lblEstadoByte = new System.Windows.Forms.Label();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            this.grpAuto.SuspendLayout();
            this.grpManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRua2
            // 
            this.picRua2.Image = global::SemaForms.Properties.Resources.Semaforo;
            this.picRua2.Location = new System.Drawing.Point(12, 73);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(173, 309);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRua2.TabIndex = 0;
            this.picRua2.TabStop = false;
            // 
            // picRua1
            // 
            this.picRua1.Image = global::SemaForms.Properties.Resources.Semaforo;
            this.picRua1.Location = new System.Drawing.Point(499, 73);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(173, 309);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRua1.TabIndex = 1;
            this.picRua1.TabStop = false;
            // 
            // grpAuto
            // 
            this.grpAuto.Controls.Add(this.label1);
            this.grpAuto.Controls.Add(this.txtTick);
            this.grpAuto.Controls.Add(this.lblAuto);
            this.grpAuto.Controls.Add(this.btnCiclo);
            this.grpAuto.Location = new System.Drawing.Point(240, 304);
            this.grpAuto.Name = "grpAuto";
            this.grpAuto.Size = new System.Drawing.Size(200, 134);
            this.grpAuto.TabIndex = 10;
            this.grpAuto.TabStop = false;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto.Location = new System.Drawing.Point(24, 18);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(156, 25);
            this.lblAuto.TabIndex = 9;
            this.lblAuto.Text = "Ciclo Automático";
            // 
            // btnCiclo
            // 
            this.btnCiclo.Location = new System.Drawing.Point(52, 83);
            this.btnCiclo.Name = "btnCiclo";
            this.btnCiclo.Size = new System.Drawing.Size(100, 40);
            this.btnCiclo.TabIndex = 8;
            this.btnCiclo.Text = "Iniciar";
            this.btnCiclo.UseVisualStyleBackColor = true;
            this.btnCiclo.Click += new System.EventHandler(this.btnCiclo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(324, 271);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(25, 15);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "120";
            // 
            // tmrCiclo
            // 
            this.tmrCiclo.Interval = 2000;
            this.tmrCiclo.Tick += new System.EventHandler(this.tmrCiclo_Tick);
            // 
            // grpManual
            // 
            this.grpManual.Controls.Add(this.lblManual);
            this.grpManual.Controls.Add(this.btnVerm);
            this.grpManual.Controls.Add(this.btnAmarelo);
            this.grpManual.Controls.Add(this.btnVerde);
            this.grpManual.Controls.Add(this.radRua2);
            this.grpManual.Controls.Add(this.radRua1);
            this.grpManual.Location = new System.Drawing.Point(240, 12);
            this.grpManual.Name = "grpManual";
            this.grpManual.Size = new System.Drawing.Size(200, 250);
            this.grpManual.TabIndex = 12;
            this.grpManual.TabStop = false;
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManual.Location = new System.Drawing.Point(23, 12);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(154, 25);
            this.lblManual.TabIndex = 15;
            this.lblManual.Text = "Controle Manual";
            // 
            // btnVerm
            // 
            this.btnVerm.Location = new System.Drawing.Point(50, 79);
            this.btnVerm.Name = "btnVerm";
            this.btnVerm.Size = new System.Drawing.Size(100, 40);
            this.btnVerm.TabIndex = 14;
            this.btnVerm.Text = "Vermelho";
            this.btnVerm.UseVisualStyleBackColor = true;
            this.btnVerm.Click += new System.EventHandler(this.btnVerm_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Location = new System.Drawing.Point(50, 136);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(100, 40);
            this.btnAmarelo.TabIndex = 13;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(50, 193);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(100, 40);
            this.btnVerde.TabIndex = 12;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // radRua2
            // 
            this.radRua2.AutoSize = true;
            this.radRua2.Location = new System.Drawing.Point(23, 49);
            this.radRua2.Name = "radRua2";
            this.radRua2.Size = new System.Drawing.Size(54, 19);
            this.radRua2.TabIndex = 11;
            this.radRua2.Text = "Rua 2";
            this.radRua2.UseVisualStyleBackColor = true;
            // 
            // radRua1
            // 
            this.radRua1.AutoSize = true;
            this.radRua1.Checked = true;
            this.radRua1.Location = new System.Drawing.Point(122, 49);
            this.radRua1.Name = "radRua1";
            this.radRua1.Size = new System.Drawing.Size(54, 19);
            this.radRua1.TabIndex = 10;
            this.radRua1.TabStop = true;
            this.radRua1.Text = "Rua 1";
            this.radRua1.UseVisualStyleBackColor = true;
            // 
            // lblEstadoByte
            // 
            this.lblEstadoByte.AutoSize = true;
            this.lblEstadoByte.Location = new System.Drawing.Point(308, 290);
            this.lblEstadoByte.Name = "lblEstadoByte";
            this.lblEstadoByte.Size = new System.Drawing.Size(57, 15);
            this.lblEstadoByte.TabIndex = 13;
            this.lblEstadoByte.Text = "000XX000";
            // 
            // txtTick
            // 
            this.txtTick.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTick.Location = new System.Drawing.Point(126, 52);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(41, 25);
            this.txtTick.TabIndex = 10;
            this.txtTick.Text = "2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Intervalo (ms):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblEstadoByte);
            this.Controls.Add(this.grpManual);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.grpAuto);
            this.Controls.Add(this.picRua1);
            this.Controls.Add(this.picRua2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            this.grpAuto.ResumeLayout(false);
            this.grpAuto.PerformLayout();
            this.grpManual.ResumeLayout(false);
            this.grpManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRua2;
        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.GroupBox grpAuto;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Button btnCiclo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Timer tmrCiclo;
        private System.Windows.Forms.GroupBox grpManual;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnVerm;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.RadioButton radRua2;
        private System.Windows.Forms.RadioButton radRua1;
        private System.Windows.Forms.Label lblEstadoByte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTick;
    }
}

