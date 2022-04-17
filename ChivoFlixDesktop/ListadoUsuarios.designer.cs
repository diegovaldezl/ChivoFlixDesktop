
namespace ChivoFlixDesktop
{
    partial class ListadoUsuarios
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
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(516, 64);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gvListaUsuarios);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 531);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(518, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar todos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(519, 346);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(168, 31);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Buscar usuario";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(515, 159);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 16);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User name";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(518, 200);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(168, 20);
            this.txt_User.TabIndex = 4;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(519, 110);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(168, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado de usuarios";
            // 
            // gvListaUsuarios
            // 
            this.gvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaUsuarios.Location = new System.Drawing.Point(29, 88);
            this.gvListaUsuarios.Name = "gvListaUsuarios";
            this.gvListaUsuarios.ReadOnly = true;
            this.gvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListaUsuarios.Size = new System.Drawing.Size(454, 397);
            this.gvListaUsuarios.TabIndex = 1;
            this.gvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListaUsuarios_CellClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(515, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(518, 292);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(168, 20);
            this.txt_Email.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Location = new System.Drawing.Point(518, 444);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(168, 31);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // ListadoUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(720, 508);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(736, 547);
            this.Name = "ListadoUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvListaUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_clear;
    }
}