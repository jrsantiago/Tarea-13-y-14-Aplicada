namespace VentanaGz
{
    partial class VentanaGz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGz));
            this.logNombretextBox = new System.Windows.Forms.TextBox();
            this.logContrasenatextBox = new System.Windows.Forms.TextBox();
            this.logbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Olvidobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logNombretextBox
            // 
            this.logNombretextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.logNombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logNombretextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logNombretextBox.Location = new System.Drawing.Point(104, 114);
            this.logNombretextBox.Name = "logNombretextBox";
            this.logNombretextBox.Size = new System.Drawing.Size(128, 24);
            this.logNombretextBox.TabIndex = 0;
            // 
            // logContrasenatextBox
            // 
            this.logContrasenatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logContrasenatextBox.Location = new System.Drawing.Point(104, 157);
            this.logContrasenatextBox.Name = "logContrasenatextBox";
            this.logContrasenatextBox.PasswordChar = '*';
            this.logContrasenatextBox.Size = new System.Drawing.Size(128, 24);
            this.logContrasenatextBox.TabIndex = 1;
            // 
            // logbutton
            // 
            this.logbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logbutton.Image = global::VentanaGz.Properties.Resources.RUN_icon;
            this.logbutton.Location = new System.Drawing.Point(255, 138);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(56, 43);
            this.logbutton.TabIndex = 2;
            this.logbutton.UseVisualStyleBackColor = false;
            this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-2, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realize su inicio de seccion....";
            // 
            // Olvidobutton
            // 
            this.Olvidobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Olvidobutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Olvidobutton.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olvidobutton.Image = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.Olvidobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Olvidobutton.Location = new System.Drawing.Point(116, 187);
            this.Olvidobutton.Name = "Olvidobutton";
            this.Olvidobutton.Size = new System.Drawing.Size(116, 19);
            this.Olvidobutton.TabIndex = 4;
            this.Olvidobutton.Text = "Olvido su Contraseña.??";
            this.Olvidobutton.UseVisualStyleBackColor = true;
            // 
            // VentanaGz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VentanaGz.Properties.Resources._2016_06_22_19_32_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(323, 389);
            this.Controls.Add(this.Olvidobutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logbutton);
            this.Controls.Add(this.logContrasenatextBox);
            this.Controls.Add(this.logNombretextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaGz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaGz";
            this.Load += new System.EventHandler(this.VentanaGz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logNombretextBox;
        private System.Windows.Forms.TextBox logContrasenatextBox;
        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Olvidobutton;
    }
}

