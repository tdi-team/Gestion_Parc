namespace Gestion_parc.SubForms
{
    partial class AddCarburant
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePickerDepart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDepart = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxMarque = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Date de rempli";
            // 
            // DateTimePickerDepart
            // 
            this.DateTimePickerDepart.CheckedState.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.FillColor = System.Drawing.Color.White;
            this.DateTimePickerDepart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerDepart.HoverState.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.Location = new System.Drawing.Point(65, 291);
            this.DateTimePickerDepart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDepart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDepart.Name = "DateTimePickerDepart";
            this.DateTimePickerDepart.ShadowDecoration.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerDepart.TabIndex = 65;
            this.DateTimePickerDepart.Value = new System.DateTime(2021, 3, 4, 11, 29, 19, 412);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.CheckedState.Parent = this.ButtonCancel;
            this.ButtonCancel.CustomImages.Parent = this.ButtonCancel;
            this.ButtonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.HoverState.Parent = this.ButtonCancel;
            this.ButtonCancel.Location = new System.Drawing.Point(175, 355);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonCancel.TabIndex = 64;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.BorderRadius = 5;
            this.ButtonSubmit.CheckedState.Parent = this.ButtonSubmit;
            this.ButtonSubmit.CustomImages.Parent = this.ButtonSubmit;
            this.ButtonSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(238)))), ((int)(((byte)(134)))));
            this.ButtonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.HoverState.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Location = new System.Drawing.Point(65, 355);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.ShadowDecoration.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Size = new System.Drawing.Size(90, 35);
            this.ButtonSubmit.TabIndex = 63;
            this.ButtonSubmit.Text = "Submit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "...kmal mn rasek";
            // 
            // TextBoxDepart
            // 
            this.TextBoxDepart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDepart.DefaultText = "";
            this.TextBoxDepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDepart.DisabledState.Parent = this.TextBoxDepart;
            this.TextBoxDepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDepart.FocusedState.Parent = this.TextBoxDepart;
            this.TextBoxDepart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDepart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDepart.HoverState.Parent = this.TextBoxDepart;
            this.TextBoxDepart.Location = new System.Drawing.Point(65, 171);
            this.TextBoxDepart.Name = "TextBoxDepart";
            this.TextBoxDepart.PasswordChar = '\0';
            this.TextBoxDepart.PlaceholderText = "Prix";
            this.TextBoxDepart.SelectedText = "";
            this.TextBoxDepart.ShadowDecoration.Parent = this.TextBoxDepart;
            this.TextBoxDepart.Size = new System.Drawing.Size(200, 36);
            this.TextBoxDepart.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxDepart.TabIndex = 61;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(65, 220);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Quantité";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 67;
            // 
            // ComboBoxMarque
            // 
            this.ComboBoxMarque.Animated = true;
            this.ComboBoxMarque.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxMarque.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMarque.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMarque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMarque.FocusedState.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxMarque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxMarque.HoverState.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.ItemHeight = 30;
            this.ComboBoxMarque.ItemsAppearance.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.Location = new System.Drawing.Point(65, 73);
            this.ComboBoxMarque.Name = "ComboBoxMarque";
            this.ComboBoxMarque.ShadowDecoration.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxMarque.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxMarque.TabIndex = 68;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Animated = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(65, 122);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox1.TabIndex = 69;
            // 
            // AddCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 414);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.ComboBoxMarque);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimePickerDepart);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxDepart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarburant";
            this.Text = "AddCarburant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerDepart;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button ButtonSubmit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDepart;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMarque;
    }
}