namespace Gestion_parc.SubForms
{
    partial class AddMission
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
            this.DateTimePickerRetour = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TextBoxFonctionnaires = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDestination = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDistance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePickerDepart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDepart = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxObjet = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelFonctionnaires = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelVehicules = new Guna.UI2.WinForms.Guna2Panel();
            this.TextBoxVehicules = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label2.Location = new System.Drawing.Point(289, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Date de retour";
            // 
            // DateTimePickerRetour
            // 
            this.DateTimePickerRetour.CheckedState.Parent = this.DateTimePickerRetour;
            this.DateTimePickerRetour.FillColor = System.Drawing.Color.White;
            this.DateTimePickerRetour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerRetour.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerRetour.HoverState.Parent = this.DateTimePickerRetour;
            this.DateTimePickerRetour.Location = new System.Drawing.Point(292, 162);
            this.DateTimePickerRetour.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerRetour.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerRetour.Name = "DateTimePickerRetour";
            this.DateTimePickerRetour.ShadowDecoration.Parent = this.DateTimePickerRetour;
            this.DateTimePickerRetour.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerRetour.TabIndex = 55;
            this.DateTimePickerRetour.Value = new System.DateTime(2021, 3, 4, 11, 29, 19, 412);
            // 
            // TextBoxFonctionnaires
            // 
            this.TextBoxFonctionnaires.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFonctionnaires.DefaultText = "";
            this.TextBoxFonctionnaires.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxFonctionnaires.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxFonctionnaires.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFonctionnaires.DisabledState.Parent = this.TextBoxFonctionnaires;
            this.TextBoxFonctionnaires.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxFonctionnaires.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFonctionnaires.FocusedState.Parent = this.TextBoxFonctionnaires;
            this.TextBoxFonctionnaires.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFonctionnaires.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxFonctionnaires.HoverState.Parent = this.TextBoxFonctionnaires;
            this.TextBoxFonctionnaires.Location = new System.Drawing.Point(65, 276);
            this.TextBoxFonctionnaires.Name = "TextBoxFonctionnaires";
            this.TextBoxFonctionnaires.PasswordChar = '\0';
            this.TextBoxFonctionnaires.PlaceholderText = "Add Fonctionnaire";
            this.TextBoxFonctionnaires.SelectedText = "";
            this.TextBoxFonctionnaires.ShadowDecoration.Parent = this.TextBoxFonctionnaires;
            this.TextBoxFonctionnaires.Size = new System.Drawing.Size(200, 36);
            this.TextBoxFonctionnaires.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxFonctionnaires.TabIndex = 52;
            // 
            // TextBoxDestination
            // 
            this.TextBoxDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDestination.DefaultText = "";
            this.TextBoxDestination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDestination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDestination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDestination.DisabledState.Parent = this.TextBoxDestination;
            this.TextBoxDestination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDestination.FocusedState.Parent = this.TextBoxDestination;
            this.TextBoxDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDestination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDestination.HoverState.Parent = this.TextBoxDestination;
            this.TextBoxDestination.Location = new System.Drawing.Point(65, 119);
            this.TextBoxDestination.Name = "TextBoxDestination";
            this.TextBoxDestination.PasswordChar = '\0';
            this.TextBoxDestination.PlaceholderText = "Destination";
            this.TextBoxDestination.SelectedText = "";
            this.TextBoxDestination.ShadowDecoration.Parent = this.TextBoxDestination;
            this.TextBoxDestination.Size = new System.Drawing.Size(200, 36);
            this.TextBoxDestination.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxDestination.TabIndex = 51;
            // 
            // TextBoxDistance
            // 
            this.TextBoxDistance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDistance.DefaultText = "";
            this.TextBoxDistance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDistance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDistance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDistance.DisabledState.Parent = this.TextBoxDistance;
            this.TextBoxDistance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDistance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDistance.FocusedState.Parent = this.TextBoxDistance;
            this.TextBoxDistance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDistance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDistance.HoverState.Parent = this.TextBoxDistance;
            this.TextBoxDistance.Location = new System.Drawing.Point(65, 167);
            this.TextBoxDistance.Name = "TextBoxDistance";
            this.TextBoxDistance.PasswordChar = '\0';
            this.TextBoxDistance.PlaceholderText = "Distance";
            this.TextBoxDistance.SelectedText = "";
            this.TextBoxDistance.ShadowDecoration.Parent = this.TextBoxDistance;
            this.TextBoxDistance.Size = new System.Drawing.Size(200, 36);
            this.TextBoxDistance.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxDistance.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Date de depart";
            // 
            // DateTimePickerDepart
            // 
            this.DateTimePickerDepart.CheckedState.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.FillColor = System.Drawing.Color.White;
            this.DateTimePickerDepart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerDepart.HoverState.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.Location = new System.Drawing.Point(292, 89);
            this.DateTimePickerDepart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDepart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDepart.Name = "DateTimePickerDepart";
            this.DateTimePickerDepart.ShadowDecoration.Parent = this.DateTimePickerDepart;
            this.DateTimePickerDepart.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerDepart.TabIndex = 47;
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
            this.ButtonCancel.Location = new System.Drawing.Point(172, 453);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonCancel.TabIndex = 46;
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
            this.ButtonSubmit.Location = new System.Drawing.Point(65, 453);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.ShadowDecoration.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Size = new System.Drawing.Size(90, 35);
            this.ButtonSubmit.TabIndex = 45;
            this.ButtonSubmit.Text = "Submit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ajouter une mission";
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
            this.TextBoxDepart.Location = new System.Drawing.Point(65, 71);
            this.TextBoxDepart.Name = "TextBoxDepart";
            this.TextBoxDepart.PasswordChar = '\0';
            this.TextBoxDepart.PlaceholderText = "Lieu de depart";
            this.TextBoxDepart.SelectedText = "";
            this.TextBoxDepart.ShadowDecoration.Parent = this.TextBoxDepart;
            this.TextBoxDepart.Size = new System.Drawing.Size(200, 36);
            this.TextBoxDepart.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxDepart.TabIndex = 39;
            // 
            // TextBoxObjet
            // 
            this.TextBoxObjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxObjet.DefaultText = "";
            this.TextBoxObjet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxObjet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxObjet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxObjet.DisabledState.Parent = this.TextBoxObjet;
            this.TextBoxObjet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxObjet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxObjet.FocusedState.Parent = this.TextBoxObjet;
            this.TextBoxObjet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxObjet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxObjet.HoverState.Parent = this.TextBoxObjet;
            this.TextBoxObjet.Location = new System.Drawing.Point(62, 221);
            this.TextBoxObjet.Name = "TextBoxObjet";
            this.TextBoxObjet.PasswordChar = '\0';
            this.TextBoxObjet.PlaceholderText = "Objet de mission";
            this.TextBoxObjet.SelectedText = "";
            this.TextBoxObjet.ShadowDecoration.Parent = this.TextBoxObjet;
            this.TextBoxObjet.Size = new System.Drawing.Size(430, 36);
            this.TextBoxObjet.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxObjet.TabIndex = 57;
            // 
            // PanelFonctionnaires
            // 
            this.PanelFonctionnaires.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelFonctionnaires.BorderRadius = 5;
            this.PanelFonctionnaires.Location = new System.Drawing.Point(65, 318);
            this.PanelFonctionnaires.Name = "PanelFonctionnaires";
            this.PanelFonctionnaires.ShadowDecoration.Parent = this.PanelFonctionnaires;
            this.PanelFonctionnaires.Size = new System.Drawing.Size(200, 113);
            this.PanelFonctionnaires.TabIndex = 58;
            // 
            // PanelVehicules
            // 
            this.PanelVehicules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelVehicules.BorderRadius = 5;
            this.PanelVehicules.Location = new System.Drawing.Point(292, 318);
            this.PanelVehicules.Name = "PanelVehicules";
            this.PanelVehicules.ShadowDecoration.Parent = this.PanelVehicules;
            this.PanelVehicules.Size = new System.Drawing.Size(200, 113);
            this.PanelVehicules.TabIndex = 60;
            // 
            // TextBoxVehicules
            // 
            this.TextBoxVehicules.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVehicules.DefaultText = "";
            this.TextBoxVehicules.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxVehicules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxVehicules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehicules.DisabledState.Parent = this.TextBoxVehicules;
            this.TextBoxVehicules.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxVehicules.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehicules.FocusedState.Parent = this.TextBoxVehicules;
            this.TextBoxVehicules.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxVehicules.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxVehicules.HoverState.Parent = this.TextBoxVehicules;
            this.TextBoxVehicules.Location = new System.Drawing.Point(292, 276);
            this.TextBoxVehicules.Name = "TextBoxVehicules";
            this.TextBoxVehicules.PasswordChar = '\0';
            this.TextBoxVehicules.PlaceholderText = "Add Vehicule";
            this.TextBoxVehicules.SelectedText = "";
            this.TextBoxVehicules.ShadowDecoration.Parent = this.TextBoxVehicules;
            this.TextBoxVehicules.Size = new System.Drawing.Size(200, 36);
            this.TextBoxVehicules.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxVehicules.TabIndex = 59;
            // 
            // AddMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.PanelVehicules);
            this.Controls.Add(this.TextBoxVehicules);
            this.Controls.Add(this.PanelFonctionnaires);
            this.Controls.Add(this.TextBoxObjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePickerRetour);
            this.Controls.Add(this.TextBoxFonctionnaires);
            this.Controls.Add(this.TextBoxDestination);
            this.Controls.Add(this.TextBoxDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimePickerDepart);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxDepart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMission";
            this.Text = "AddMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelFonctionnaires;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxObjet;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerRetour;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxFonctionnaires;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDestination;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDistance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerDepart;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button ButtonSubmit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDepart;
        private Guna.UI2.WinForms.Guna2Panel PanelVehicules;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxVehicules;
    }
}