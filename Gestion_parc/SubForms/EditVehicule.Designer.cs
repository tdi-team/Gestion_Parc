namespace Gestion_parc.SubForms
{
    partial class EditVehicule
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
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNivCarb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBarNivCarb = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TextBoxModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxMarque = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxMatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Niveau de carburant";
            // 
            // TextBoxNivCarb
            // 
            this.TextBoxNivCarb.Animated = true;
            this.TextBoxNivCarb.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxNivCarb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNivCarb.DefaultText = "0";
            this.TextBoxNivCarb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNivCarb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNivCarb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNivCarb.DisabledState.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNivCarb.FillColor = System.Drawing.SystemColors.Control;
            this.TextBoxNivCarb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNivCarb.FocusedState.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNivCarb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNivCarb.HoverState.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Location = new System.Drawing.Point(240, 356);
            this.TextBoxNivCarb.Name = "TextBoxNivCarb";
            this.TextBoxNivCarb.PasswordChar = '\0';
            this.TextBoxNivCarb.PlaceholderText = "";
            this.TextBoxNivCarb.SelectedText = "";
            this.TextBoxNivCarb.ShadowDecoration.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Size = new System.Drawing.Size(36, 25);
            this.TextBoxNivCarb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxNivCarb.TabIndex = 20;
            this.TextBoxNivCarb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxNivCarb.TextChanged += new System.EventHandler(this.TextBoxNivCarb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Modifier la vehicule";
            // 
            // TrackBarNivCarb
            // 
            this.TrackBarNivCarb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TrackBarNivCarb.HoverState.Parent = this.TrackBarNivCarb;
            this.TrackBarNivCarb.IndicateFocus = false;
            this.TrackBarNivCarb.Location = new System.Drawing.Point(76, 327);
            this.TrackBarNivCarb.Name = "TrackBarNivCarb";
            this.TrackBarNivCarb.Size = new System.Drawing.Size(200, 23);
            this.TrackBarNivCarb.TabIndex = 16;
            this.TrackBarNivCarb.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.TrackBarNivCarb.Value = 0;
            this.TrackBarNivCarb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarNivCarb_Scroll);
            // 
            // TextBoxModele
            // 
            this.TextBoxModele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxModele.DefaultText = "";
            this.TextBoxModele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxModele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxModele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxModele.DisabledState.Parent = this.TextBoxModele;
            this.TextBoxModele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxModele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxModele.FocusedState.Parent = this.TextBoxModele;
            this.TextBoxModele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxModele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxModele.HoverState.Parent = this.TextBoxModele;
            this.TextBoxModele.Location = new System.Drawing.Point(76, 197);
            this.TextBoxModele.Name = "TextBoxModele";
            this.TextBoxModele.PasswordChar = '\0';
            this.TextBoxModele.PlaceholderText = "Modèle";
            this.TextBoxModele.SelectedText = "";
            this.TextBoxModele.ShadowDecoration.Parent = this.TextBoxModele;
            this.TextBoxModele.Size = new System.Drawing.Size(200, 36);
            this.TextBoxModele.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxModele.TabIndex = 15;
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
            this.ComboBoxMarque.Location = new System.Drawing.Point(76, 155);
            this.ComboBoxMarque.Name = "ComboBoxMarque";
            this.ComboBoxMarque.ShadowDecoration.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxMarque.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxMarque.TabIndex = 14;
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.Animated = true;
            this.ComboBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStatus.FocusedState.Parent = this.ComboBoxStatus;
            this.ComboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxStatus.HoverState.Parent = this.ComboBoxStatus;
            this.ComboBoxStatus.ItemHeight = 30;
            this.ComboBoxStatus.ItemsAppearance.Parent = this.ComboBoxStatus;
            this.ComboBoxStatus.Location = new System.Drawing.Point(76, 239);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.ShadowDecoration.Parent = this.ComboBoxStatus;
            this.ComboBoxStatus.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxStatus.TabIndex = 13;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Animated = true;
            this.ComboBoxType.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxType.FocusedState.Parent = this.ComboBoxType;
            this.ComboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxType.HoverState.Parent = this.ComboBoxType;
            this.ComboBoxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxType.ItemHeight = 30;
            this.ComboBoxType.ItemsAppearance.Parent = this.ComboBoxType;
            this.ComboBoxType.Location = new System.Drawing.Point(76, 113);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.ShadowDecoration.Parent = this.ComboBoxType;
            this.ComboBoxType.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxType.TabIndex = 12;
            // 
            // TextBoxMatricule
            // 
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
            this.TextBoxMatricule.Location = new System.Drawing.Point(76, 71);
            this.TextBoxMatricule.Name = "TextBoxMatricule";
            this.TextBoxMatricule.PasswordChar = '\0';
            this.TextBoxMatricule.PlaceholderText = "Matricule";
            this.TextBoxMatricule.SelectedText = "";
            this.TextBoxMatricule.ShadowDecoration.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.Size = new System.Drawing.Size(200, 36);
            this.TextBoxMatricule.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxMatricule.TabIndex = 11;
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
            this.ButtonCancel.Location = new System.Drawing.Point(125, 395);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonCancel.TabIndex = 23;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BorderRadius = 5;
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(238)))), ((int)(((byte)(134)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Location = new System.Drawing.Point(18, 395);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 35);
            this.ButtonUpdate.TabIndex = 22;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // EditVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNivCarb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBarNivCarb);
            this.Controls.Add(this.TextBoxModele);
            this.Controls.Add(this.ComboBoxMarque);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.TextBoxMatricule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditVehicule";
            this.Text = "EditVehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNivCarb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarNivCarb;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxModele;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMarque;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxStatus;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxType;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxMatricule;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdate;
    }
}