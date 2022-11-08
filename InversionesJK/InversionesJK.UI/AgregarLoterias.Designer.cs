
namespace InversionesJK.UI
{
    partial class AgregarLoterias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarLoterias));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txt_nombre_loteria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo_loteria = new System.Windows.Forms.MaskedTextBox();
            this.LblCodigoLoteria = new System.Windows.Forms.Label();
            this.GrpLoteria = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpLoteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(155, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(11, 249);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txt_nombre_loteria
            // 
            this.txt_nombre_loteria.Location = new System.Drawing.Point(23, 99);
            this.txt_nombre_loteria.Name = "txt_nombre_loteria";
            this.txt_nombre_loteria.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre_loteria.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre de Loteria";
            // 
            // txt_codigo_loteria
            // 
            this.txt_codigo_loteria.Location = new System.Drawing.Point(23, 45);
            this.txt_codigo_loteria.Mask = "0000000000000000";
            this.txt_codigo_loteria.Name = "txt_codigo_loteria";
            this.txt_codigo_loteria.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo_loteria.TabIndex = 19;
            // 
            // LblCodigoLoteria
            // 
            this.LblCodigoLoteria.AutoSize = true;
            this.LblCodigoLoteria.Location = new System.Drawing.Point(20, 28);
            this.LblCodigoLoteria.Name = "LblCodigoLoteria";
            this.LblCodigoLoteria.Size = new System.Drawing.Size(90, 13);
            this.LblCodigoLoteria.TabIndex = 18;
            this.LblCodigoLoteria.Text = "Codigo de Loteria";
            // 
            // GrpLoteria
            // 
            this.GrpLoteria.Controls.Add(this.LblCodigoLoteria);
            this.GrpLoteria.Controls.Add(this.txt_codigo_loteria);
            this.GrpLoteria.Controls.Add(this.label3);
            this.GrpLoteria.Controls.Add(this.txt_nombre_loteria);
            this.GrpLoteria.Location = new System.Drawing.Point(41, 80);
            this.GrpLoteria.Name = "GrpLoteria";
            this.GrpLoteria.Size = new System.Drawing.Size(170, 150);
            this.GrpLoteria.TabIndex = 14;
            this.GrpLoteria.TabStop = false;
            this.GrpLoteria.Text = "Datos de Loteria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarLoterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(250, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.GrpLoteria);
            this.MaximizeBox = false;
            this.Name = "AgregarLoterias";
            this.Text = "AgregarLoterias";
            this.Load += new System.EventHandler(this.AgregarLoterias_Load);
            this.GrpLoteria.ResumeLayout(false);
            this.GrpLoteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txt_nombre_loteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_codigo_loteria;
        private System.Windows.Forms.Label LblCodigoLoteria;
        private System.Windows.Forms.GroupBox GrpLoteria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}