namespace VentanaGz
{
    partial class NewUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUsuario));
            this.NewNombretextBox = new System.Windows.Forms.TextBox();
            this.NewApellidotextBox = new System.Windows.Forms.TextBox();
            this.NewUserNametextBox = new System.Windows.Forms.TextBox();
            this.NewContrasenatextBox = new System.Windows.Forms.TextBox();
            this.RepitaContrasenatextBox = new System.Windows.Forms.TextBox();
            this.MasculinocheckBox = new System.Windows.Forms.CheckBox();
            this.FemeninocheckBox = new System.Windows.Forms.CheckBox();
            this.NewUsuariobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewNombretextBox
            // 
            this.NewNombretextBox.Location = new System.Drawing.Point(96, 109);
            this.NewNombretextBox.Name = "NewNombretextBox";
            this.NewNombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NewNombretextBox.TabIndex = 0;
            // 
            // NewApellidotextBox
            // 
            this.NewApellidotextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewApellidotextBox.Location = new System.Drawing.Point(96, 135);
            this.NewApellidotextBox.Name = "NewApellidotextBox";
            this.NewApellidotextBox.Size = new System.Drawing.Size(100, 20);
            this.NewApellidotextBox.TabIndex = 1;
            // 
            // NewUserNametextBox
            // 
            this.NewUserNametextBox.Location = new System.Drawing.Point(188, 185);
            this.NewUserNametextBox.Name = "NewUserNametextBox";
            this.NewUserNametextBox.Size = new System.Drawing.Size(100, 20);
            this.NewUserNametextBox.TabIndex = 2;
            // 
            // NewContrasenatextBox
            // 
            this.NewContrasenatextBox.Location = new System.Drawing.Point(116, 211);
            this.NewContrasenatextBox.Name = "NewContrasenatextBox";
            this.NewContrasenatextBox.PasswordChar = '*';
            this.NewContrasenatextBox.Size = new System.Drawing.Size(124, 20);
            this.NewContrasenatextBox.TabIndex = 3;
            // 
            // RepitaContrasenatextBox
            // 
            this.RepitaContrasenatextBox.Location = new System.Drawing.Point(201, 237);
            this.RepitaContrasenatextBox.Name = "RepitaContrasenatextBox";
            this.RepitaContrasenatextBox.PasswordChar = '*';
            this.RepitaContrasenatextBox.Size = new System.Drawing.Size(122, 20);
            this.RepitaContrasenatextBox.TabIndex = 4;
            // 
            // MasculinocheckBox
            // 
            this.MasculinocheckBox.AutoSize = true;
            this.MasculinocheckBox.BackgroundImage = global::VentanaGz.Properties.Resources.Blue_Widescreen_Background_1920x1200;
            this.MasculinocheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MasculinocheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasculinocheckBox.Location = new System.Drawing.Point(65, 161);
            this.MasculinocheckBox.Name = "MasculinocheckBox";
            this.MasculinocheckBox.Size = new System.Drawing.Size(50, 17);
            this.MasculinocheckBox.TabIndex = 5;
            this.MasculinocheckBox.Text = "Man";
            this.MasculinocheckBox.UseVisualStyleBackColor = true;
            // 
            // FemeninocheckBox
            // 
            this.FemeninocheckBox.AutoSize = true;
            this.FemeninocheckBox.BackgroundImage = global::VentanaGz.Properties.Resources.Blue_Widescreen_Background_1920x1200;
            this.FemeninocheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FemeninocheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemeninocheckBox.Location = new System.Drawing.Point(121, 161);
            this.FemeninocheckBox.Name = "FemeninocheckBox";
            this.FemeninocheckBox.Size = new System.Drawing.Size(66, 17);
            this.FemeninocheckBox.TabIndex = 6;
            this.FemeninocheckBox.Text = "Female";
            this.FemeninocheckBox.UseVisualStyleBackColor = true;
            // 
            // NewUsuariobutton
            // 
            this.NewUsuariobutton.BackColor = System.Drawing.Color.Cornsilk;
            this.NewUsuariobutton.BackgroundImage = global::VentanaGz.Properties.Resources.Blue_Widescreen_Background_1920x1200;
            this.NewUsuariobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewUsuariobutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewUsuariobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUsuariobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsuariobutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.NewUsuariobutton.Image = global::VentanaGz.Properties.Resources.system_database_add_icon__1_;
            this.NewUsuariobutton.Location = new System.Drawing.Point(201, 313);
            this.NewUsuariobutton.Name = "NewUsuariobutton";
            this.NewUsuariobutton.Size = new System.Drawing.Size(72, 92);
            this.NewUsuariobutton.TabIndex = 7;
            this.NewUsuariobutton.Text = "Crear";
            this.NewUsuariobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewUsuariobutton.UseVisualStyleBackColor = false;
            this.NewUsuariobutton.Click += new System.EventHandler(this.NewUsuariobutton_Click);
            // 
            // NewUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources.newUsuario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 417);
            this.Controls.Add(this.NewUsuariobutton);
            this.Controls.Add(this.FemeninocheckBox);
            this.Controls.Add(this.MasculinocheckBox);
            this.Controls.Add(this.RepitaContrasenatextBox);
            this.Controls.Add(this.NewContrasenatextBox);
            this.Controls.Add(this.NewUserNametextBox);
            this.Controls.Add(this.NewApellidotextBox);
            this.Controls.Add(this.NewNombretextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUsuario";
            this.Load += new System.EventHandler(this.NewUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewNombretextBox;
        private System.Windows.Forms.TextBox NewApellidotextBox;
        private System.Windows.Forms.TextBox NewUserNametextBox;
        private System.Windows.Forms.TextBox NewContrasenatextBox;
        private System.Windows.Forms.TextBox RepitaContrasenatextBox;
        private System.Windows.Forms.CheckBox MasculinocheckBox;
        private System.Windows.Forms.CheckBox FemeninocheckBox;
        private System.Windows.Forms.Button NewUsuariobutton;
    }
}