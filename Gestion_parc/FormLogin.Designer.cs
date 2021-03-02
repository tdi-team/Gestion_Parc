namespace Gestion_parc
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Animated = true;
            this.ButtonClose.BorderRadius = 10;
            this.ButtonClose.CheckedState.Parent = this.ButtonClose;
            this.ButtonClose.CustomImages.Parent = this.ButtonClose;
            this.ButtonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(103)))), ((int)(((byte)(207)))));
            this.ButtonClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(68)))), ((int)(((byte)(199)))));
            this.ButtonClose.HoverState.Parent = this.ButtonClose;
            this.ButtonClose.Location = new System.Drawing.Point(353, 12);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShadowDecoration.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(35, 35);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.Text = "X";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Animated = true;
            this.TextBoxUser.AutoRoundedCorners = true;
            this.TextBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUser.BorderRadius = 21;
            this.TextBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUser.DefaultText = "user";
            this.TextBoxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUser.DisabledState.Parent = this.TextBoxUser;
            this.TextBoxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUser.FocusedState.Parent = this.TextBoxUser;
            this.TextBoxUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUser.HoverState.Parent = this.TextBoxUser;
            this.TextBoxUser.Location = new System.Drawing.Point(73, 232);
            this.TextBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.PlaceholderText = "User Name";
            this.TextBoxUser.SelectedText = "";
            this.TextBoxUser.SelectionStart = 4;
            this.TextBoxUser.ShadowDecoration.Parent = this.TextBoxUser;
            this.TextBoxUser.Size = new System.Drawing.Size(250, 45);
            this.TextBoxUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxUser.TabIndex = 5;
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_TextChanged);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Animated = true;
            this.TextBoxPass.AutoRoundedCorners = true;
            this.TextBoxPass.BorderRadius = 21;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.DefaultText = "user";
            this.TextBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPass.DisabledState.Parent = this.TextBoxPass;
            this.TextBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPass.FocusedState.Parent = this.TextBoxPass;
            this.TextBoxPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPass.HoverState.Parent = this.TextBoxPass;
            this.TextBoxPass.Location = new System.Drawing.Point(73, 317);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.PlaceholderText = "Password";
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.SelectionStart = 4;
            this.TextBoxPass.ShadowDecoration.Parent = this.TextBoxPass;
            this.TextBoxPass.Size = new System.Drawing.Size(250, 45);
            this.TextBoxPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBoxPass.TabIndex = 6;
            this.TextBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.guna2PictureBox2;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Gestion_parc.Properties.Resources.user;
            this.guna2PictureBox2.Location = new System.Drawing.Point(135, 60);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(130, 130);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2ButtonLogin
            // 
            this.guna2ButtonLogin.Animated = true;
            this.guna2ButtonLogin.BorderRadius = 8;
            this.guna2ButtonLogin.CheckedState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.CustomImages.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLogin.HoverState.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButtonLogin.Image")));
            this.guna2ButtonLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonLogin.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ButtonLogin.Location = new System.Drawing.Point(108, 395);
            this.guna2ButtonLogin.Name = "guna2ButtonLogin";
            this.guna2ButtonLogin.ShadowDecoration.Parent = this.guna2ButtonLogin;
            this.guna2ButtonLogin.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonLogin.TabIndex = 7;
            this.guna2ButtonLogin.Text = "Login";
            this.guna2ButtonLogin.Click += new System.EventHandler(this.guna2ButtonLogin_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.guna2HtmlToolTip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.guna2HtmlToolTip1.ToolTipTitle = "Error";
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.ContainerControl = this;
            this.guna2DragControl2.TargetControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2ButtonLogin);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUser;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}