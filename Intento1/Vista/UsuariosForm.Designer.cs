namespace Vista
{
    partial class UsuariosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(294, 41);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(304, 31);
            this.CodigoTextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(294, 91);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(312, 31);
            this.NombreTextBox.TabIndex = 6;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(294, 137);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(313, 31);
            this.ClaveTextBox.TabIndex = 7;
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(294, 198);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(331, 31);
            this.CorreoTextBox.TabIndex = 8;
            // 
            // RolComboBox
            // 
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolComboBox.Location = new System.Drawing.Point(294, 268);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(293, 33);
            this.RolComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "EstadoActivo";
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(294, 344);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(22, 21);
            this.EstaActivoCheckBox.TabIndex = 11;
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(12, 479);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.RowHeadersWidth = 62;
            this.UsuariosDataGridView.RowTemplate.Height = 33;
            this.UsuariosDataGridView.Size = new System.Drawing.Size(1172, 225);
            this.UsuariosDataGridView.TabIndex = 12;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(275, 414);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(112, 34);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(461, 414);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(112, 34);
            this.ModificarButton.TabIndex = 14;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(623, 414);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(112, 34);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(778, 414);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(112, 34);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(958, 414);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 34);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 716);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CodigoTextBox;
        private TextBox NombreTextBox;
        private TextBox ClaveTextBox;
        private TextBox CorreoTextBox;
        private ComboBox RolComboBox;
        private Label label6;
        private CheckBox EstaActivoCheckBox;
        private DataGridView UsuariosDataGridView;
        private Button NuevoButton;
        private Button ModificarButton;
        private Button GuardarButton;
        private Button EliminarButton;
        private Button CancelarButton;
        private ErrorProvider errorProvider1;
    }
}