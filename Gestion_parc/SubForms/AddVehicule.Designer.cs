namespace Gestion_parc.SubForms
{
    partial class AddVehicule
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
            this.ComboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxEtat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxMarque = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBoxModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.TrackBarNivCarb = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxNivCarb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePickerAquisition = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCapacite = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxConsomage = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxHorsePower = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxKilometrage = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.TextBoxMatricule.Location = new System.Drawing.Point(63, 74);
            this.TextBoxMatricule.Name = "TextBoxMatricule";
            this.TextBoxMatricule.PasswordChar = '\0';
            this.TextBoxMatricule.PlaceholderText = "Matricule";
            this.TextBoxMatricule.SelectedText = "";
            this.TextBoxMatricule.ShadowDecoration.Parent = this.TextBoxMatricule;
            this.TextBoxMatricule.Size = new System.Drawing.Size(200, 36);
            this.TextBoxMatricule.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxMatricule.TabIndex = 0;
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
            this.ComboBoxType.Location = new System.Drawing.Point(63, 129);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.ShadowDecoration.Parent = this.ComboBoxType;
            this.ComboBoxType.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxType.TabIndex = 1;
            // 
            // ComboBoxEtat
            // 
            this.ComboBoxEtat.Animated = true;
            this.ComboBoxEtat.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxEtat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEtat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxEtat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxEtat.FocusedState.Parent = this.ComboBoxEtat;
            this.ComboBoxEtat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxEtat.HoverState.Parent = this.ComboBoxEtat;
            this.ComboBoxEtat.ItemHeight = 30;
            this.ComboBoxEtat.ItemsAppearance.Parent = this.ComboBoxEtat;
            this.ComboBoxEtat.Location = new System.Drawing.Point(63, 239);
            this.ComboBoxEtat.Name = "ComboBoxEtat";
            this.ComboBoxEtat.ShadowDecoration.Parent = this.ComboBoxEtat;
            this.ComboBoxEtat.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxEtat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxEtat.TabIndex = 2;
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
            this.ComboBoxMarque.Location = new System.Drawing.Point(63, 184);
            this.ComboBoxMarque.Name = "ComboBoxMarque";
            this.ComboBoxMarque.ShadowDecoration.Parent = this.ComboBoxMarque;
            this.ComboBoxMarque.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxMarque.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ComboBoxMarque.TabIndex = 3;
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
            this.TextBoxModele.Location = new System.Drawing.Point(288, 74);
            this.TextBoxModele.Name = "TextBoxModele";
            this.TextBoxModele.PasswordChar = '\0';
            this.TextBoxModele.PlaceholderText = "Modèle";
            this.TextBoxModele.SelectedText = "";
            this.TextBoxModele.ShadowDecoration.Parent = this.TextBoxModele;
            this.TextBoxModele.Size = new System.Drawing.Size(200, 36);
            this.TextBoxModele.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxModele.TabIndex = 4;
            // 
            // TrackBarNivCarb
            // 
            this.TrackBarNivCarb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrackBarNivCarb.HoverState.Parent = this.TrackBarNivCarb;
            this.TrackBarNivCarb.IndicateFocus = false;
            this.TrackBarNivCarb.Location = new System.Drawing.Point(288, 333);
            this.TrackBarNivCarb.Name = "TrackBarNivCarb";
            this.TrackBarNivCarb.Size = new System.Drawing.Size(200, 23);
            this.TrackBarNivCarb.TabIndex = 5;
            this.TrackBarNivCarb.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TrackBarNivCarb.Value = 0;
            this.TrackBarNivCarb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarNivCarb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter une vehicule";
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
            this.ButtonSubmit.Location = new System.Drawing.Point(12, 411);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.ShadowDecoration.Parent = this.ButtonSubmit;
            this.ButtonSubmit.Size = new System.Drawing.Size(90, 35);
            this.ButtonSubmit.TabIndex = 7;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
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
            this.ButtonCancel.Location = new System.Drawing.Point(119, 411);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShadowDecoration.Parent = this.ButtonCancel;
            this.ButtonCancel.Size = new System.Drawing.Size(90, 35);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
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
            this.TextBoxNivCarb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.TextBoxNivCarb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNivCarb.FocusedState.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNivCarb.ForeColor = System.Drawing.Color.White;
            this.TextBoxNivCarb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNivCarb.HoverState.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Location = new System.Drawing.Point(452, 362);
            this.TextBoxNivCarb.Name = "TextBoxNivCarb";
            this.TextBoxNivCarb.PasswordChar = '\0';
            this.TextBoxNivCarb.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextBoxNivCarb.PlaceholderText = "";
            this.TextBoxNivCarb.SelectedText = "";
            this.TextBoxNivCarb.SelectionStart = 1;
            this.TextBoxNivCarb.ShadowDecoration.Parent = this.TextBoxNivCarb;
            this.TextBoxNivCarb.Size = new System.Drawing.Size(36, 25);
            this.TextBoxNivCarb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxNivCarb.TabIndex = 9;
            this.TextBoxNivCarb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxNivCarb.TextChanged += new System.EventHandler(this.TextBoxNivCarb_TextChanged);
            this.TextBoxNivCarb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNivCarb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Niveau de carburant";
            // 
            // DateTimePickerAquisition
            // 
            this.DateTimePickerAquisition.CheckedState.Parent = this.DateTimePickerAquisition;
            this.DateTimePickerAquisition.FillColor = System.Drawing.Color.White;
            this.DateTimePickerAquisition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerAquisition.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerAquisition.HoverState.Parent = this.DateTimePickerAquisition;
            this.DateTimePickerAquisition.Location = new System.Drawing.Point(288, 143);
            this.DateTimePickerAquisition.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerAquisition.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerAquisition.Name = "DateTimePickerAquisition";
            this.DateTimePickerAquisition.ShadowDecoration.Parent = this.DateTimePickerAquisition;
            this.DateTimePickerAquisition.Size = new System.Drawing.Size(200, 36);
            this.DateTimePickerAquisition.TabIndex = 11;
            this.DateTimePickerAquisition.Value = new System.DateTime(2021, 3, 4, 11, 29, 19, 412);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date d\'aquisition";
            // 
            // TextBoxCapacite
            // 
            this.TextBoxCapacite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCapacite.DefaultText = "";
            this.TextBoxCapacite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCapacite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCapacite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCapacite.DisabledState.Parent = this.TextBoxCapacite;
            this.TextBoxCapacite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCapacite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCapacite.FocusedState.Parent = this.TextBoxCapacite;
            this.TextBoxCapacite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCapacite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCapacite.HoverState.Parent = this.TextBoxCapacite;
            this.TextBoxCapacite.Location = new System.Drawing.Point(63, 349);
            this.TextBoxCapacite.Name = "TextBoxCapacite";
            this.TextBoxCapacite.PasswordChar = '\0';
            this.TextBoxCapacite.PlaceholderText = "CapaciteReservoir";
            this.TextBoxCapacite.SelectedText = "";
            this.TextBoxCapacite.ShadowDecoration.Parent = this.TextBoxCapacite;
            this.TextBoxCapacite.Size = new System.Drawing.Size(200, 36);
            this.TextBoxCapacite.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxCapacite.TabIndex = 13;
            this.TextBoxCapacite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNivCarb_KeyPress);
            // 
            // TextBoxConsomage
            // 
            this.TextBoxConsomage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsomage.DefaultText = "";
            this.TextBoxConsomage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxConsomage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxConsomage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConsomage.DisabledState.Parent = this.TextBoxConsomage;
            this.TextBoxConsomage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConsomage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxConsomage.FocusedState.Parent = this.TextBoxConsomage;
            this.TextBoxConsomage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsomage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxConsomage.HoverState.Parent = this.TextBoxConsomage;
            this.TextBoxConsomage.Location = new System.Drawing.Point(288, 239);
            this.TextBoxConsomage.Name = "TextBoxConsomage";
            this.TextBoxConsomage.PasswordChar = '\0';
            this.TextBoxConsomage.PlaceholderText = "Consomage";
            this.TextBoxConsomage.SelectedText = "";
            this.TextBoxConsomage.ShadowDecoration.Parent = this.TextBoxConsomage;
            this.TextBoxConsomage.Size = new System.Drawing.Size(200, 36);
            this.TextBoxConsomage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxConsomage.TabIndex = 14;
            this.TextBoxConsomage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNivCarb_KeyPress);
            // 
            // TextBoxHorsePower
            // 
            this.TextBoxHorsePower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHorsePower.DefaultText = "";
            this.TextBoxHorsePower.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHorsePower.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHorsePower.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHorsePower.DisabledState.Parent = this.TextBoxHorsePower;
            this.TextBoxHorsePower.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHorsePower.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHorsePower.FocusedState.Parent = this.TextBoxHorsePower;
            this.TextBoxHorsePower.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxHorsePower.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHorsePower.HoverState.Parent = this.TextBoxHorsePower;
            this.TextBoxHorsePower.Location = new System.Drawing.Point(63, 294);
            this.TextBoxHorsePower.Name = "TextBoxHorsePower";
            this.TextBoxHorsePower.PasswordChar = '\0';
            this.TextBoxHorsePower.PlaceholderText = "Horse Power";
            this.TextBoxHorsePower.SelectedText = "";
            this.TextBoxHorsePower.ShadowDecoration.Parent = this.TextBoxHorsePower;
            this.TextBoxHorsePower.Size = new System.Drawing.Size(200, 36);
            this.TextBoxHorsePower.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxHorsePower.TabIndex = 15;
            // 
            // TextBoxKilometrage
            // 
            this.TextBoxKilometrage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxKilometrage.DefaultText = "";
            this.TextBoxKilometrage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxKilometrage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxKilometrage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKilometrage.DisabledState.Parent = this.TextBoxKilometrage;
            this.TextBoxKilometrage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKilometrage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKilometrage.FocusedState.Parent = this.TextBoxKilometrage;
            this.TextBoxKilometrage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxKilometrage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKilometrage.HoverState.Parent = this.TextBoxKilometrage;
            this.TextBoxKilometrage.Location = new System.Drawing.Point(288, 185);
            this.TextBoxKilometrage.Name = "TextBoxKilometrage";
            this.TextBoxKilometrage.PasswordChar = '\0';
            this.TextBoxKilometrage.PlaceholderText = "Kilometrage";
            this.TextBoxKilometrage.SelectedText = "";
            this.TextBoxKilometrage.ShadowDecoration.Parent = this.TextBoxKilometrage;
            this.TextBoxKilometrage.Size = new System.Drawing.Size(200, 36);
            this.TextBoxKilometrage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxKilometrage.TabIndex = 16;
            // 
            // AddVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 458);
            this.Controls.Add(this.TextBoxKilometrage);
            this.Controls.Add(this.TextBoxHorsePower);
            this.Controls.Add(this.TextBoxConsomage);
            this.Controls.Add(this.TextBoxCapacite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimePickerAquisition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNivCarb);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBarNivCarb);
            this.Controls.Add(this.TextBoxModele);
            this.Controls.Add(this.ComboBoxMarque);
            this.Controls.Add(this.ComboBoxEtat);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.TextBoxMatricule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVehicule";
            this.Text = "AddVehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarNivCarb;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxModele;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMarque;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxEtat;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxType;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxMatricule;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNivCarb;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button ButtonSubmit;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxConsomage;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCapacite;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerAquisition;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxHorsePower;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxKilometrage;
    }
}