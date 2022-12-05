
namespace InversionesJK.UI
{
    partial class ReporteLoteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteLoteria));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar_fecha = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_loteria = new System.Windows.Forms.TextBox();
            this.btn_imprimir_fecha = new System.Windows.Forms.Button();
            this.btn_imprimir_nombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_loteria = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txt_id_loteria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_buscar_fecha);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.txt_loteria);
            this.groupBox1.Controls.Add(this.btn_imprimir_fecha);
            this.groupBox1.Controls.Add(this.btn_imprimir_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 139);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Id loteria";
            // 
            // btn_buscar_fecha
            // 
            this.btn_buscar_fecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_fecha.BackgroundImage")));
            this.btn_buscar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_fecha.Location = new System.Drawing.Point(115, 100);
            this.btn_buscar_fecha.Name = "btn_buscar_fecha";
            this.btn_buscar_fecha.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_fecha.TabIndex = 53;
            this.btn_buscar_fecha.UseVisualStyleBackColor = true;
            this.btn_buscar_fecha.Click += new System.EventHandler(this.btn_buscar_fecha_Click);
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
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.BackgroundImage")));
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(264, 45);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 54);
            this.btn_imprimir.TabIndex = 6;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_loteria
            // 
            this.txt_loteria.Location = new System.Drawing.Point(9, 45);
            this.txt_loteria.Name = "txt_loteria";
            this.txt_loteria.Size = new System.Drawing.Size(100, 20);
            this.txt_loteria.TabIndex = 0;
            // 
            // btn_imprimir_fecha
            // 
            this.btn_imprimir_fecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_fecha.BackgroundImage")));
            this.btn_imprimir_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_fecha.Location = new System.Drawing.Point(146, 99);
            this.btn_imprimir_fecha.Name = "btn_imprimir_fecha";
            this.btn_imprimir_fecha.Size = new System.Drawing.Size(25, 20);
            this.btn_imprimir_fecha.TabIndex = 5;
            this.btn_imprimir_fecha.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir_nombre
            // 
            this.btn_imprimir_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir_nombre.BackgroundImage")));
            this.btn_imprimir_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_nombre.Location = new System.Drawing.Point(146, 44);
            this.btn_imprimir_nombre.Name = "btn_imprimir_nombre";
            this.btn_imprimir_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_imprimir_nombre.TabIndex = 2;
            this.btn_imprimir_nombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre de Loteria";
            // 
            // txt_id_loteria
            // 
            this.txt_id_loteria.Location = new System.Drawing.Point(9, 100);
            this.txt_id_loteria.Name = "txt_id_loteria";
            this.txt_id_loteria.Size = new System.Drawing.Size(100, 20);
            this.txt_id_loteria.TabIndex = 58;
            this.txt_id_loteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_loteria_KeyPress);
            // 
            // ReporteLoteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_principal);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReporteLoteria";
            this.Text = "Reporte Loteria";
            this.Load += new System.EventHandler(this.ReporteLoteria_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar_fecha;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_loteria;
        private System.Windows.Forms.Button btn_imprimir_fecha;
        private System.Windows.Forms.Button btn_imprimir_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_loteria;
    }
}