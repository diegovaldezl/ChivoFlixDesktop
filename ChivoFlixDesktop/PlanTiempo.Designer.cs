
namespace ChivoFlixDesktop
{
    partial class PlanTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanTiempo));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTiempo = new System.Windows.Forms.DataGridView();
            this.btnAgregarTiempo = new System.Windows.Forms.Button();
            this.txtNombreTiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarTiempo = new System.Windows.Forms.Button();
            this.btnEliminarTiempo = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo de duración de planes";
            // 
            // dgvTiempo
            // 
            this.dgvTiempo.AllowUserToAddRows = false;
            this.dgvTiempo.AllowUserToDeleteRows = false;
            this.dgvTiempo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempo.Location = new System.Drawing.Point(27, 86);
            this.dgvTiempo.Name = "dgvTiempo";
            this.dgvTiempo.ReadOnly = true;
            this.dgvTiempo.Size = new System.Drawing.Size(240, 204);
            this.dgvTiempo.TabIndex = 1;
            this.dgvTiempo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiempo_CellClick);
            // 
            // btnAgregarTiempo
            // 
            this.btnAgregarTiempo.Location = new System.Drawing.Point(427, 138);
            this.btnAgregarTiempo.Name = "btnAgregarTiempo";
            this.btnAgregarTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTiempo.TabIndex = 2;
            this.btnAgregarTiempo.Text = "Agregar";
            this.btnAgregarTiempo.UseVisualStyleBackColor = true;
            this.btnAgregarTiempo.Click += new System.EventHandler(this.btnAgregarTiempo_Click);
            // 
            // txtNombreTiempo
            // 
            this.txtNombreTiempo.Location = new System.Drawing.Point(402, 83);
            this.txtNombreTiempo.Name = "txtNombreTiempo";
            this.txtNombreTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTiempo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo:";
            // 
            // btnModificarTiempo
            // 
            this.btnModificarTiempo.Location = new System.Drawing.Point(427, 198);
            this.btnModificarTiempo.Name = "btnModificarTiempo";
            this.btnModificarTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTiempo.TabIndex = 5;
            this.btnModificarTiempo.Text = "Modificar";
            this.btnModificarTiempo.UseVisualStyleBackColor = true;
            this.btnModificarTiempo.Click += new System.EventHandler(this.btnModificarTiempo_Click);
            // 
            // btnEliminarTiempo
            // 
            this.btnEliminarTiempo.Location = new System.Drawing.Point(427, 267);
            this.btnEliminarTiempo.Name = "btnEliminarTiempo";
            this.btnEliminarTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTiempo.TabIndex = 6;
            this.btnEliminarTiempo.Text = "Eliminar";
            this.btnEliminarTiempo.UseVisualStyleBackColor = true;
            this.btnEliminarTiempo.Click += new System.EventHandler(this.btnEliminarTiempo_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(516, 138);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 28;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(516, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(516, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // PlanTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(612, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnEliminarTiempo);
            this.Controls.Add(this.btnModificarTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreTiempo);
            this.Controls.Add(this.btnAgregarTiempo);
            this.Controls.Add(this.dgvTiempo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanTiempo";
            this.Text = "PlanTiempo";
            this.Load += new System.EventHandler(this.PlanTiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiempo;
        private System.Windows.Forms.Button btnAgregarTiempo;
        private System.Windows.Forms.TextBox txtNombreTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarTiempo;
        private System.Windows.Forms.Button btnEliminarTiempo;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}