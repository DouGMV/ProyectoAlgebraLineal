namespace ProyectoAlgebraLineal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validarButton = new System.Windows.Forms.Button();
            this.carnetTextBox = new System.Windows.Forms.TextBox();
            this.carnetModificadoLabel = new System.Windows.Forms.Label();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.qrCodePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Carné:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carné modificado:";
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(310, 159);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(84, 32);
            this.validarButton.TabIndex = 2;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // carnetTextBox
            // 
            this.carnetTextBox.Location = new System.Drawing.Point(290, 113);
            this.carnetTextBox.Name = "carnetTextBox";
            this.carnetTextBox.Size = new System.Drawing.Size(127, 22);
            this.carnetTextBox.TabIndex = 3;
            // 
            // carnetModificadoLabel
            // 
            this.carnetModificadoLabel.AutoSize = true;
            this.carnetModificadoLabel.Location = new System.Drawing.Point(307, 221);
            this.carnetModificadoLabel.Name = "carnetModificadoLabel";
            this.carnetModificadoLabel.Size = new System.Drawing.Size(0, 16);
            this.carnetModificadoLabel.TabIndex = 4;
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = global::ProyectoAlgebraLineal.Properties.Resources.Logo_Meso;
            this.LogopictureBox.Location = new System.Drawing.Point(26, 12);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(125, 120);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogopictureBox.TabIndex = 5;
            this.LogopictureBox.TabStop = false;
            // 
            // qrCodePictureBox
            // 
            this.qrCodePictureBox.Location = new System.Drawing.Point(455, 113);
            this.qrCodePictureBox.Name = "qrCodePictureBox";
            this.qrCodePictureBox.Size = new System.Drawing.Size(132, 115);
            this.qrCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodePictureBox.TabIndex = 6;
            this.qrCodePictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-7, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 79);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.qrCodePictureBox);
            this.Controls.Add(this.LogopictureBox);
            this.Controls.Add(this.carnetModificadoLabel);
            this.Controls.Add(this.carnetTextBox);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Validar Cárne";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validarButton;
        private System.Windows.Forms.TextBox carnetTextBox;
        private System.Windows.Forms.Label carnetModificadoLabel;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.PictureBox qrCodePictureBox;
        private System.Windows.Forms.Panel panel1;
    }
}

