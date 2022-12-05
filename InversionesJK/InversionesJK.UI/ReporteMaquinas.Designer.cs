
namespace InversionesJK.UI
{
    partial class ReporteMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMaquinas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ubi_maq = new System.Windows.Forms.TextBox();
            this.btn_buscar_ubicacion = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_imprimir_todo = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_ubicacion = new System.Windows.Forms.Button();
            this.btn_imprimir_maquina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // dat_principal
            // 
            this.dat_principal.AllowUserToAddRows = false;
            this.dat_principal.AllowUserToDeleteRows = false;
            this.dat_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_principal.Location = new System.Drawing.Point(31, 183);
            this.dat_principal.Name = "dat_principal";
            this.dat_principal.ReadOnly = true;
            this.dat_principal.Size = new System.Drawing.Size(739, 229);
            this.dat_principal.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ubi_maq);
            this.groupBox1.Controls.Add(this.btn_buscar_ubicacion);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_imprimir_todo);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.btn_ubicacion);
            this.groupBox1.Controls.Add(this.btn_imprimir_maquina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 139);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // txt_ubi_maq
            // 
            this.txt_ubi_maq.Location = new System.Drawing.Point(9, 102);
            this.txt_ubi_maq.Name = "txt_ubi_maq";
            this.txt_ubi_maq.Size = new System.Drawing.Size(111, 20);
            this.txt_ubi_maq.TabIndex = 54;
            // 
            // btn_buscar_ubicacion
            // 
            this.btn_buscar_ubicacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_buscar_ubicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_ubicacion.BackgroundImage")));
            this.btn_buscar_ubicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_ubicacion.Location = new System.Drawing.Point(126, 101);
            this.btn_buscar_ubicacion.Name = "btn_buscar_ubicacion";
            this.btn_buscar_ubicacion.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_ubicacion.TabIndex = 53;
            this.btn_buscar_ubicacion.UseVisualStyleBackColor = true;
            this.btn_buscar_ubicacion.Click += new System.EventHandler(this.btn_buscar_ubicacion_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(115, 45);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar.TabIndex = 52;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Imprimir todo";
            // 
            // btn_imprimir_todo
            // 
            this.btn_imprimir_todo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_todo.BackgroundImage")));
            this.btn_imprimir_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_todo.Location = new System.Drawing.Point(264, 45);
            this.btn_imprimir_todo.Name = "btn_imprimir_todo";
            this.btn_imprimir_todo.Size = new System.Drawing.Size(62, 54);
            this.btn_imprimir_todo.TabIndex = 6;
            this.btn_imprimir_todo.UseVisualStyleBackColor = true;
            this.btn_imprimir_todo.Click += new System.EventHandler(this.btn_imprimir_todo_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 45);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_ubicacion
            // 
            this.btn_ubicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ubicacion.BackgroundImage")));
            this.btn_ubicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ubicacion.Location = new System.Drawing.Point(157, 102);
            this.btn_ubicacion.Name = "btn_ubicacion";
            this.btn_ubicacion.Size = new System.Drawing.Size(25, 20);
            this.btn_ubicacion.TabIndex = 5;
            this.btn_ubicacion.UseVisualStyleBackColor = true;
            this.btn_ubicacion.Click += new System.EventHandler(this.btn_ubicacion_Click);
            // 
            // btn_imprimir_maquina
            // 
            this.btn_imprimir_maquina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_maquina.BackgroundImage")));
            this.btn_imprimir_maquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_maquina.Location = new System.Drawing.Point(146, 46);
            this.btn_imprimir_maquina.Name = "btn_imprimir_maquina";
            this.btn_imprimir_maquina.Size = new System.Drawing.Size(25, 20);
            this.btn_imprimir_maquina.TabIndex = 2;
            this.btn_imprimir_maquina.UseVisualStyleBackColor = true;
            this.btn_imprimir_maquina.Click += new System.EventHandler(this.btn_imprimir_maquina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre de Maquina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ubicacion de Maquina";
            // 
            // ReporteMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_principal);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReporteMaquinas";
            this.Text = "Reporte de Maquinas";
            this.Load += new System.EventHandler(this.ReporteMaquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dat_principal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_ubicacion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_imprimir_todo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_ubicacion;
        private System.Windows.Forms.Button btn_imprimir_maquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ubi_maq;
        private System.Windows.Forms.Label label3;
    }
}