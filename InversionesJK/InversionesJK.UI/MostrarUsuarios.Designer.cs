﻿
namespace InversionesJK.UI
{
    partial class MostrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar_cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar_cedula);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 139);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_nombre.BackgroundImage")));
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(115, 102);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_nombre.TabIndex = 3;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cédula del usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre Usuario";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(115, 48);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar_cedula
            // 
            this.txt_buscar_cedula.Location = new System.Drawing.Point(9, 48);
            this.txt_buscar_cedula.Mask = "0000000000";
            this.txt_buscar_cedula.Name = "txt_buscar_cedula";
            this.txt_buscar_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar_cedula.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 102);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Enabled = false;
            this.btn_consultar.Location = new System.Drawing.Point(303, 179);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(86, 41);
            this.btn_consultar.TabIndex = 61;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(211, 179);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 41);
            this.btn_eliminar.TabIndex = 60;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Enabled = false;
            this.btn_editar.Location = new System.Drawing.Point(119, 179);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 41);
            this.btn_editar.TabIndex = 59;
            this.btn_editar.Text = "Modificar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(27, 179);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(86, 41);
            this.btn_agregar.TabIndex = 58;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dat_principal
            // 
            this.dat_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_principal.Location = new System.Drawing.Point(25, 237);
            this.dat_principal.Name = "dat_principal";
            this.dat_principal.Size = new System.Drawing.Size(739, 185);
            this.dat_principal.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_principal);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "MostrarUsuarios";
            this.Text = "Mostrar Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox txt_buscar_cedula;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dat_principal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}