﻿namespace Vista
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrase;a";
            // 
            // CodigoUsuarioTextBox
            // 
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(224, 55);
            this.CodigoUsuarioTextBox.Name = "CodigoUsuarioTextBox";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(268, 31);
            this.CodigoUsuarioTextBox.TabIndex = 2;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(218, 147);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(263, 31);
            this.ClaveTextBox.TabIndex = 3;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(61, 300);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(159, 64);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(363, 301);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(175, 77);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CodigoUsuarioTextBox;
        private TextBox ClaveTextBox;
        private Button AceptarButton;
        private Button CancelarButton;
        private ErrorProvider errorProvider1;
    }
}