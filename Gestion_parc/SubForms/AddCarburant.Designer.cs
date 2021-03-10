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
            this.TextBoxMatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxTypeC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxQuantité = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePickerRemplissage = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPrix = new Guna.UI2.WinForms.Guna2TextBox();
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
            // TextBoxMatricule
            // 
            this.TextBoxMatricule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxMatricule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxMatricule.AutoScroll = true;
            this.TextBoxMatricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMatricule.DefaultText = "";
            this.TextBoxMatricule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxMatricule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxMatricule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMatricule.DisabledState.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMatricule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMatricule.FocusedState.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMatricule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMatricule.HoverState.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.Location = new System.Drawing.Point(64, 78);
            this.TextBoxMatricule.Name = "TextBoxMatricule";
            this.TextBoxMatricule.PasswordChar = '\0';
            this.TextBoxMatricule.PlaceholderText = "";
            this.TextBoxMatricule.SelectedText = "";
            this.TextBoxMatricule.ShadowDecoration.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.Size = new System.Drawing.Size(200, 36);
            this.TextBoxMatricule.TabIndex = 79;
            // 
            // ComboBoxTypeC
            // 
            this.ComboBoxTypeC.Animated = true;
            this.ComboBoxTypeC.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxTypeC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxTypeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxTypeC.FocusedState.Parent = this.ComboBoxTypeC;
            this.ComboBoxTypeC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxTypeC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxTypeC.HoverState.Parent = this.ComboBoxTypeC;
            this.ComboBoxTypeC.ItemHeight = 30;
            this.ComboBoxTypeC.Items.AddRange(new object[] {
            "LICENCE",
            "MAZOT",
            "LICENCE-PLOMB"});
            this.ComboBoxTypeC.ItemsAppearance.Parent = this.ComboBoxTypeC;
            this.ComboBoxTypeC.Location = new System.Drawing.Point(64, 130);
            this.ComboBoxTypeC.Name = "ComboBoxTypeC";
            this.ComboBoxTypeC.ShadowDecoration.Parent = this.ComboBoxTypeC;
            this.ComboBoxTypeC.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxTypeC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxTypeC.TabIndex = 78;
            // 
            // TextBoxQuantité
            // 
            this.TextBoxQuantité.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuantité.DefaultText = "";
            this.TextBoxQuantité.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuantité.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuantité.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantité.DisabledState.Parent = this.TextBoxQuantité;
            this.TextBoxQuantité.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantité.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuantité.FocusedState.Parent = this.TextBoxQuantité;
            this.TextBoxQuantité.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxQuantité.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuantité.HoverState.Parent = this.TextBoxQuantité;
            this.TextBoxQuantité.Location = new System.Drawing.Point(64, 228);
            this.TextBoxQuantité.Name = "TextBoxQuantité";
            this.TextBoxQuantité.PasswordChar = '\0';
            this.TextBoxQuantité.PlaceholderText = "Quantité";
            this.TextBoxQuantité.SelectedText = "";
            this.TextBoxQuantité.ShadowDecoration.Parent = this.TextBoxQuantité;
            this.TextBoxQuantité.Size = new System.Drawing.Size(200, 36);
            this.TextBoxQuantité.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxQuantité.TabIndex = 77;
            this.TextBoxQuantité.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxQuantité_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Date de rempli";
            // 
            // DateTimePickerRemplissage
            // 
            this.DateTimePickerRemplissage.CheckedState.Parent = this.DateTimePickerRemplissage;
            this.DateTimePickerRemplissage.FillColor = System.Drawing.Color.White;
            this.DateTimePickerRemplissage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerRemplissage.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerRemplissage.HoverState.Parent = this.DateTimePickerRemplissage;
            this.DateTimePickerRemplissage.Location = new System.Drawing.Point(64, 299);
            this.DateTimePickerRemplissage.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerRemplissage.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerRemplissage.Name = "DateTimePickerRemplissage";
            this.DateTimePickerRemplissage.ShadowDecoration.Parent = this.DateTimePickerRemplissage;
            this.DateTimePickerRemplissage.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerRemplissage.TabIndex = 75;
            this.DateTimePickerRemplissage.Value = new System.DateTime(2021, 3, 4, 11, 29, 19, 412);
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
            this.ButtonCancel.Location = new System.Drawing.Point(174, 363);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonCancel.TabIndex = 74;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
            this.ButtonSubmit.Location = new System.Drawing.Point(64, 363);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.ShadowDecoration.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Size = new System.Drawing.Size(90, 35);
            this.ButtonSubmit.TabIndex = 73;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "Remplir Carburant";
            // 
            // TextBoxPrix
            // 
            this.TextBoxPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrix.DefaultText = "";
            this.TextBoxPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrix.DisabledState.Parent = this.TextBoxPrix;
            this.TextBoxPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrix.FocusedState.Parent = this.TextBoxPrix;
            this.TextBoxPrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrix.HoverState.Parent = this.TextBoxPrix;
            this.TextBoxPrix.Location = new System.Drawing.Point(64, 186);
            this.TextBoxPrix.Name = "TextBoxPrix";
            this.TextBoxPrix.PasswordChar = '\0';
            this.TextBoxPrix.PlaceholderText = "Prix";
            this.TextBoxPrix.SelectedText = "";
            this.TextBoxPrix.ShadowDecoration.Parent = this.TextBoxPrix;
            this.TextBoxPrix.Size = new System.Drawing.Size(200, 36);
            this.TextBoxPrix.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxPrix.TabIndex = 71;
            this.TextBoxPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrix_KeyPress);
            // 
            // AddCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 414);
            this.Controls.Add(this.TextBoxMatricule);
            this.Controls.Add(this.ComboBoxTypeC);
            this.Controls.Add(this.TextBoxQuantité);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimePickerRemplissage);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarburant";
            this.Text = "AddCarburant";
            this.Load += new System.EventHandler(this.AddCarburant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxMatricule;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxTypeC;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuantité;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerRemplissage;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button ButtonSubmit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPrix;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

    }
}