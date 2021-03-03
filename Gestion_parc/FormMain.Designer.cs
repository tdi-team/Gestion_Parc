namespace Gestion_parc
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonDisconnect = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.PictureBoxUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCarburants = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMissions = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFonctionnaires = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonVehicule = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelMenu.BorderRadius = 5;
            this.PanelMenu.Controls.Add(this.guna2Button1);
            this.PanelMenu.Controls.Add(this.ButtonMaintenance);
            this.PanelMenu.Controls.Add(this.ButtonCarburants);
            this.PanelMenu.Controls.Add(this.ButtonMissions);
            this.PanelMenu.Controls.Add(this.ButtonFonctionnaires);
            this.PanelMenu.Controls.Add(this.ButtonVehicule);
            this.PanelMenu.Controls.Add(this.ButtonHome);
            this.PanelMenu.CustomizableEdges.BottomLeft = false;
            this.PanelMenu.CustomizableEdges.TopLeft = false;
            this.PanelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.PanelMenu.Location = new System.Drawing.Point(-1, -1);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(191, 601);
            this.PanelMenu.TabIndex = 0;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDisconnect.BorderRadius = 10;
            this.ButtonDisconnect.FillColor = System.Drawing.Color.MintCream;
            this.ButtonDisconnect.Location = new System.Drawing.Point(196, 71);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.ShadowDecoration.Parent = this.ButtonDisconnect;
            this.ButtonDisconnect.Size = new System.Drawing.Size(692, 520);
            this.ButtonDisconnect.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(139)))), ((int)(((byte)(220)))));
            this.labelTitle.Location = new System.Drawing.Point(196, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 37);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Gestion Du Parc";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(664, 17);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(105, 25);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "User Name";
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Image = global::Gestion_parc.Properties.Resources.man;
            this.PictureBoxUser.Location = new System.Drawing.Point(613, 9);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxUser.ShadowDecoration.Parent = this.PictureBoxUser;
            this.PictureBoxUser.Size = new System.Drawing.Size(45, 45);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxUser.TabIndex = 15;
            this.PictureBoxUser.TabStop = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Animated = true;
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClose.BackgroundImage")));
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClose.CheckedState.Parent = this.ButtonClose;
            this.ButtonClose.CustomImages.Parent = this.ButtonClose;
            this.ButtonClose.FillColor = System.Drawing.Color.Transparent;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.HoverState.Parent = this.ButtonClose;
            this.ButtonClose.Location = new System.Drawing.Point(858, 12);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShadowDecoration.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(30, 30);
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.UseTransparentBackground = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.CustomizableEdges.TopLeft = false;
            this.guna2Button1.CustomizableEdges.TopRight = false;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(116)))), ((int)(((byte)(62)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Gestion_parc.Properties.Resources.logout_Standard;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(0, 546);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(191, 55);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Deconnecter";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonMaintenance
            // 
            this.ButtonMaintenance.Animated = true;
            this.ButtonMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaintenance.BorderRadius = 3;
            this.ButtonMaintenance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonMaintenance.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonMaintenance.CheckedState.Parent = this.ButtonMaintenance;
            this.ButtonMaintenance.CustomImages.Parent = this.ButtonMaintenance;
            this.ButtonMaintenance.FillColor = System.Drawing.Color.Transparent;
            this.ButtonMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonMaintenance.HoverState.Parent = this.ButtonMaintenance;
            this.ButtonMaintenance.Image = global::Gestion_parc.Properties.Resources.tools_Standard;
            this.ButtonMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMaintenance.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonMaintenance.Location = new System.Drawing.Point(0, 365);
            this.ButtonMaintenance.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonMaintenance.Name = "ButtonMaintenance";
            this.ButtonMaintenance.ShadowDecoration.Parent = this.ButtonMaintenance;
            this.ButtonMaintenance.Size = new System.Drawing.Size(191, 55);
            this.ButtonMaintenance.TabIndex = 5;
            this.ButtonMaintenance.Text = "Maintenance";
            this.ButtonMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMaintenance.Click += new System.EventHandler(this.ButtonMaintenance_Click);
            // 
            // ButtonCarburants
            // 
            this.ButtonCarburants.Animated = true;
            this.ButtonCarburants.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCarburants.BorderRadius = 3;
            this.ButtonCarburants.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonCarburants.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonCarburants.CheckedState.Parent = this.ButtonCarburants;
            this.ButtonCarburants.CustomImages.Parent = this.ButtonCarburants;
            this.ButtonCarburants.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCarburants.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCarburants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonCarburants.HoverState.Parent = this.ButtonCarburants;
            this.ButtonCarburants.Image = global::Gestion_parc.Properties.Resources.gas_Standard;
            this.ButtonCarburants.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCarburants.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonCarburants.Location = new System.Drawing.Point(0, 292);
            this.ButtonCarburants.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonCarburants.Name = "ButtonCarburants";
            this.ButtonCarburants.ShadowDecoration.Parent = this.ButtonCarburants;
            this.ButtonCarburants.Size = new System.Drawing.Size(191, 55);
            this.ButtonCarburants.TabIndex = 4;
            this.ButtonCarburants.Text = "Carburants";
            this.ButtonCarburants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCarburants.Click += new System.EventHandler(this.ButtonCarburants_Click);
            // 
            // ButtonMissions
            // 
            this.ButtonMissions.Animated = true;
            this.ButtonMissions.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMissions.BorderRadius = 3;
            this.ButtonMissions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonMissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonMissions.CheckedState.Parent = this.ButtonMissions;
            this.ButtonMissions.CustomImages.Parent = this.ButtonMissions;
            this.ButtonMissions.FillColor = System.Drawing.Color.Transparent;
            this.ButtonMissions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonMissions.HoverState.Parent = this.ButtonMissions;
            this.ButtonMissions.Image = global::Gestion_parc.Properties.Resources.mission_Standard;
            this.ButtonMissions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMissions.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonMissions.Location = new System.Drawing.Point(0, 219);
            this.ButtonMissions.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonMissions.Name = "ButtonMissions";
            this.ButtonMissions.ShadowDecoration.Parent = this.ButtonMissions;
            this.ButtonMissions.Size = new System.Drawing.Size(191, 55);
            this.ButtonMissions.TabIndex = 3;
            this.ButtonMissions.Text = "Missions";
            this.ButtonMissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonMissions.Click += new System.EventHandler(this.ButtonMissions_Click);
            // 
            // ButtonFonctionnaires
            // 
            this.ButtonFonctionnaires.Animated = true;
            this.ButtonFonctionnaires.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFonctionnaires.BorderRadius = 3;
            this.ButtonFonctionnaires.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonFonctionnaires.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonFonctionnaires.CheckedState.Parent = this.ButtonFonctionnaires;
            this.ButtonFonctionnaires.CustomImages.Parent = this.ButtonFonctionnaires;
            this.ButtonFonctionnaires.FillColor = System.Drawing.Color.Transparent;
            this.ButtonFonctionnaires.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFonctionnaires.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonFonctionnaires.HoverState.Parent = this.ButtonFonctionnaires;
            this.ButtonFonctionnaires.Image = global::Gestion_parc.Properties.Resources.employee_Standard;
            this.ButtonFonctionnaires.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonFonctionnaires.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonFonctionnaires.Location = new System.Drawing.Point(0, 146);
            this.ButtonFonctionnaires.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonFonctionnaires.Name = "ButtonFonctionnaires";
            this.ButtonFonctionnaires.ShadowDecoration.Parent = this.ButtonFonctionnaires;
            this.ButtonFonctionnaires.Size = new System.Drawing.Size(191, 55);
            this.ButtonFonctionnaires.TabIndex = 2;
            this.ButtonFonctionnaires.Text = "Fonctionnaires";
            this.ButtonFonctionnaires.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonFonctionnaires.Click += new System.EventHandler(this.ButtonFonctionnaires_Click);
            // 
            // ButtonVehicule
            // 
            this.ButtonVehicule.Animated = true;
            this.ButtonVehicule.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVehicule.BorderRadius = 3;
            this.ButtonVehicule.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonVehicule.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonVehicule.CheckedState.Parent = this.ButtonVehicule;
            this.ButtonVehicule.CustomImages.Parent = this.ButtonVehicule;
            this.ButtonVehicule.FillColor = System.Drawing.Color.Transparent;
            this.ButtonVehicule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVehicule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonVehicule.HoverState.Parent = this.ButtonVehicule;
            this.ButtonVehicule.Image = global::Gestion_parc.Properties.Resources.car_Standard;
            this.ButtonVehicule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonVehicule.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonVehicule.Location = new System.Drawing.Point(0, 73);
            this.ButtonVehicule.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonVehicule.Name = "ButtonVehicule";
            this.ButtonVehicule.ShadowDecoration.Parent = this.ButtonVehicule;
            this.ButtonVehicule.Size = new System.Drawing.Size(191, 55);
            this.ButtonVehicule.TabIndex = 1;
            this.ButtonVehicule.Text = "Vehicules";
            this.ButtonVehicule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonVehicule.Click += new System.EventHandler(this.ButtonVehicule_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Animated = true;
            this.ButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHome.BorderRadius = 3;
            this.ButtonHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(84)))));
            this.ButtonHome.CheckedState.Parent = this.ButtonHome;
            this.ButtonHome.CustomImages.Parent = this.ButtonHome;
            this.ButtonHome.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.ButtonHome.HoverState.Parent = this.ButtonHome;
            this.ButtonHome.Image = global::Gestion_parc.Properties.Resources.home_Standard;
            this.ButtonHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.ImageSize = new System.Drawing.Size(50, 50);
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.ShadowDecoration.Parent = this.ButtonHome;
            this.ButtonHome.Size = new System.Drawing.Size(191, 55);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.Animated = true;
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Gestion_parc.Properties.Resources.minimize_Standard;
            this.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMinimize.CheckedState.Parent = this.ButtonMinimize;
            this.ButtonMinimize.CustomImages.Parent = this.ButtonMinimize;
            this.ButtonMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonMinimize.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimize.HoverState.Parent = this.ButtonMinimize;
            this.ButtonMinimize.Location = new System.Drawing.Point(786, 12);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.ShadowDecoration.Parent = this.ButtonMinimize;
            this.ButtonMinimize.Size = new System.Drawing.Size(30, 30);
            this.ButtonMinimize.TabIndex = 10;
            this.ButtonMinimize.UseTransparentBackground = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonMaximize
            // 
            this.ButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximize.Animated = true;
            this.ButtonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaximize.BackgroundImage = global::Gestion_parc.Properties.Resources.maximize_Standard;
            this.ButtonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMaximize.CheckedState.Parent = this.ButtonMaximize;
            this.ButtonMaximize.CustomImages.Parent = this.ButtonMaximize;
            this.ButtonMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ButtonMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonMaximize.ForeColor = System.Drawing.Color.White;
            this.ButtonMaximize.HoverState.Parent = this.ButtonMaximize;
            this.ButtonMaximize.Location = new System.Drawing.Point(822, 12);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.ShadowDecoration.Parent = this.ButtonMaximize;
            this.ButtonMaximize.Size = new System.Drawing.Size(30, 30);
            this.ButtonMaximize.TabIndex = 9;
            this.ButtonMaximize.UseTransparentBackground = true;
            this.ButtonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.PictureBoxUser);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.ButtonMinimize);
            this.Controls.Add(this.ButtonMaximize);
            this.Controls.Add(this.ButtonDisconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonHome;
        private Guna.UI2.WinForms.Guna2Button ButtonVehicule;
        private Guna.UI2.WinForms.Guna2Panel ButtonDisconnect;
        private Guna.UI2.WinForms.Guna2Button ButtonMaintenance;
        private Guna.UI2.WinForms.Guna2Button ButtonCarburants;
        private Guna.UI2.WinForms.Guna2Button ButtonMissions;
        private Guna.UI2.WinForms.Guna2Button ButtonFonctionnaires;
        private Guna.UI2.WinForms.Guna2Button ButtonMinimize;
        private Guna.UI2.WinForms.Guna2Button ButtonMaximize;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxUser;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}