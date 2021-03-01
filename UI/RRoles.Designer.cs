
namespace CrearOtro_Regitro_Con_Detalle.UI
{
    partial class rRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetallesGroupBox = new System.Windows.Forms.GroupBox();
            this.PermisosComboBox = new System.Windows.Forms.ComboBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DetallesDataGridView = new System.Windows.Forms.DataGridView();
            this.AsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RolActivoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.DetallesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(111, 12);
            this.IdNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(76, 31);
            this.IdNumericUpDown.TabIndex = 2;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(111, 67);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(344, 31);
            this.DescripcionTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(195, 8);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(64, 38);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(386, 561);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(131, 68);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(210, 561);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(131, 68);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(37, 561);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(131, 68);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // DetallesGroupBox
            // 
            this.DetallesGroupBox.Controls.Add(this.PermisosComboBox);
            this.DetallesGroupBox.Controls.Add(this.RemoverButton);
            this.DetallesGroupBox.Controls.Add(this.AgregarButton);
            this.DetallesGroupBox.Controls.Add(this.DetallesDataGridView);
            this.DetallesGroupBox.Controls.Add(this.AsignadoCheckBox);
            this.DetallesGroupBox.Controls.Add(this.label3);
            this.DetallesGroupBox.Location = new System.Drawing.Point(4, 108);
            this.DetallesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetallesGroupBox.Name = "DetallesGroupBox";
            this.DetallesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetallesGroupBox.Size = new System.Drawing.Size(609, 443);
            this.DetallesGroupBox.TabIndex = 8;
            this.DetallesGroupBox.TabStop = false;
            this.DetallesGroupBox.Text = "Detalles";
            // 
            // PermisosComboBox
            // 
            this.PermisosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisosComboBox.FormattingEnabled = true;
            this.PermisosComboBox.Location = new System.Drawing.Point(111, 48);
            this.PermisosComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PermisosComboBox.Name = "PermisosComboBox";
            this.PermisosComboBox.Size = new System.Drawing.Size(140, 33);
            this.PermisosComboBox.TabIndex = 10;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.Location = new System.Drawing.Point(9, 368);
            this.RemoverButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(134, 68);
            this.RemoverButton.TabIndex = 10;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(480, 43);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(120, 41);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DetallesDataGridView
            // 
            this.DetallesDataGridView.AllowUserToAddRows = false;
            this.DetallesDataGridView.AllowUserToDeleteRows = false;
            this.DetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDataGridView.Location = new System.Drawing.Point(9, 98);
            this.DetallesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetallesDataGridView.Name = "DetallesDataGridView";
            this.DetallesDataGridView.ReadOnly = true;
            this.DetallesDataGridView.RowHeadersWidth = 62;
            this.DetallesDataGridView.RowTemplate.Height = 25;
            this.DetallesDataGridView.Size = new System.Drawing.Size(591, 260);
            this.DetallesDataGridView.TabIndex = 11;
            // 
            // AsignadoCheckBox
            // 
            this.AsignadoCheckBox.AutoSize = true;
            this.AsignadoCheckBox.Location = new System.Drawing.Point(311, 52);
            this.AsignadoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsignadoCheckBox.Name = "AsignadoCheckBox";
            this.AsignadoCheckBox.Size = new System.Drawing.Size(114, 29);
            this.AsignadoCheckBox.TabIndex = 10;
            this.AsignadoCheckBox.Text = "Asignado";
            this.AsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Permiso Id";
            // 
            // RolActivoCheckBox
            // 
            this.RolActivoCheckBox.AutoSize = true;
            this.RolActivoCheckBox.Location = new System.Drawing.Point(367, 8);
            this.RolActivoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RolActivoCheckBox.Name = "RolActivoCheckBox";
            this.RolActivoCheckBox.Size = new System.Drawing.Size(88, 29);
            this.RolActivoCheckBox.TabIndex = 9;
            this.RolActivoCheckBox.Text = "Activo";
            this.RolActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 642);
            this.Controls.Add(this.RolActivoCheckBox);
            this.Controls.Add(this.DetallesGroupBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "rRoles";
            this.Text = "Registro de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.DetallesGroupBox.ResumeLayout(false);
            this.DetallesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.CheckBox RolActivoCheckBox;
        private System.Windows.Forms.GroupBox DetallesGroupBox;
        private System.Windows.Forms.ComboBox PermisosComboBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView DetallesDataGridView;
        private System.Windows.Forms.CheckBox AsignadoCheckBox;
        private System.Windows.Forms.Label label3;
    }
}