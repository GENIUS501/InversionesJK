﻿
namespace InversionesJK.UI
{
    partial class Bitacora_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_Movimientos));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dat_sesiones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.btn_nombre = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Accion = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.BackgroundImage")));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(360, 379);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 54);
            this.btn_imprimir.TabIndex = 99;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // dat_sesiones
            // 
            this.dat_sesiones.AllowUserToAddRows = false;
            this.dat_sesiones.AllowUserToDeleteRows = false;
            this.dat_sesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_sesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_sesiones.Location = new System.Drawing.Point(12, 171);
            this.dat_sesiones.Name = "dat_sesiones";
            this.dat_sesiones.ReadOnly = true;
            this.dat_sesiones.Size = new System.Drawing.Size(777, 202);
            this.dat_sesiones.TabIndex = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_fecha);
            this.groupBox1.Controls.Add(this.btn_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbo_Accion);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_ini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 147);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Busqueda";
            // 
            // btn_fecha
            // 
            this.btn_fecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fecha.BackgroundImage")));
            this.btn_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fecha.Location = new System.Drawing.Point(353, 102);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(25, 20);
            this.btn_fecha.TabIndex = 56;
            this.btn_fecha.UseVisualStyleBackColor = true;
            // 
            // btn_nombre
            // 
            this.btn_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nombre.BackgroundImage")));
            this.btn_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nombre.Location = new System.Drawing.Point(115, 44);
            this.btn_nombre.Name = "btn_nombre";
            this.btn_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_nombre.TabIndex = 55;
            this.btn_nombre.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Accion";
            // 
            // cbo_Accion
            // 
            this.cbo_Accion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Accion.FormattingEnabled = true;
            this.cbo_Accion.Items.AddRange(new object[] {
            "Todas",
            "Agregar",
            "Modificar",
            "Eliminar"});
            this.cbo_Accion.Location = new System.Drawing.Point(215, 43);
            this.cbo_Accion.Name = "cbo_Accion";
            this.cbo_Accion.Size = new System.Drawing.Size(121, 21);
            this.cbo_Accion.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(384, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 20);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(146, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 20);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(9, 45);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre de usuario";
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_fin.Location = new System.Drawing.Point(215, 102);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(121, 20);
            this.txt_fecha_fin.TabIndex = 5;
            // 
            // txt_fecha_ini
            // 
            this.txt_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_ini.Location = new System.Drawing.Point(9, 102);
            this.txt_fecha_ini.Name = "txt_fecha_ini";
            this.txt_fecha_ini.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_ini.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha inicial";
            // 
            // Bitacora_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_sesiones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bitacora_Movimientos";
            this.Text = "Bitacora_Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dat_sesiones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.Button btn_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Accion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}