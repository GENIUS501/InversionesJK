
namespace InversionesJK.UI
{
    partial class AgregarMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMaquinas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.GrpMaquina = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_maq = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ubicacion_maq = new System.Windows.Forms.TextBox();
            this.LblMaquina = new System.Windows.Forms.Label();
            this.txt_codigo_maquina = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_maquina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(128, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 85;
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 84;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // GrpMaquina
            // 
            this.GrpMaquina.Controls.Add(this.dtp_fecha_maq);
            this.GrpMaquina.Controls.Add(this.label1);
            this.GrpMaquina.Controls.Add(this.txt_ubicacion_maq);
            this.GrpMaquina.Controls.Add(this.LblMaquina);
            this.GrpMaquina.Controls.Add(this.txt_codigo_maquina);
            this.GrpMaquina.Controls.Add(this.label3);
            this.GrpMaquina.Controls.Add(this.txt_nombre_maquina);
            this.GrpMaquina.Controls.Add(this.label5);
            this.GrpMaquina.Location = new System.Drawing.Point(34, 70);
            this.GrpMaquina.Name = "GrpMaquina";
            this.GrpMaquina.Size = new System.Drawing.Size(152, 244);
            this.GrpMaquina.TabIndex = 83;
            this.GrpMaquina.TabStop = false;
            this.GrpMaquina.Text = "Datos de Maquina";
            // 
            // dtp_fecha_maq
            // 
            this.dtp_fecha_maq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_maq.Location = new System.Drawing.Point(17, 150);
            this.dtp_fecha_maq.Name = "dtp_fecha_maq";
            this.dtp_fecha_maq.Size = new System.Drawing.Size(100, 20);
            this.dtp_fecha_maq.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ubicación";
            // 
            // txt_ubicacion_maq
            // 
            this.txt_ubicacion_maq.Location = new System.Drawing.Point(17, 204);
            this.txt_ubicacion_maq.Name = "txt_ubicacion_maq";
            this.txt_ubicacion_maq.Size = new System.Drawing.Size(100, 20);
            this.txt_ubicacion_maq.TabIndex = 26;
            // 
            // LblMaquina
            // 
            this.LblMaquina.AutoSize = true;
            this.LblMaquina.Location = new System.Drawing.Point(12, 26);
            this.LblMaquina.Name = "LblMaquina";
            this.LblMaquina.Size = new System.Drawing.Size(99, 13);
            this.LblMaquina.TabIndex = 22;
            this.LblMaquina.Text = "Codigo de Maquina";
            // 
            // txt_codigo_maquina
            // 
            this.txt_codigo_maquina.Location = new System.Drawing.Point(15, 43);
            this.txt_codigo_maquina.Mask = "0000000000000000";
            this.txt_codigo_maquina.Name = "txt_codigo_maquina";
            this.txt_codigo_maquina.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo_maquina.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombre de Maquina";
            // 
            // txt_nombre_maquina
            // 
            this.txt_nombre_maquina.Location = new System.Drawing.Point(15, 97);
            this.txt_nombre_maquina.Name = "txt_nombre_maquina";
            this.txt_nombre_maquina.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre_maquina.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(230, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.GrpMaquina);
            this.MaximizeBox = false;
            this.Name = "AgregarMaquinas";
            this.Text = "Agregar Maquinas";
            this.Load += new System.EventHandler(this.AgregarMaquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpMaquina.ResumeLayout(false);
            this.GrpMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox GrpMaquina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblMaquina;
        private System.Windows.Forms.MaskedTextBox txt_codigo_maquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_maquina;
        private System.Windows.Forms.DateTimePicker dtp_fecha_maq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ubicacion_maq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}