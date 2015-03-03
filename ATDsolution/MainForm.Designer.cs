namespace ATDsolution
{
    partial class MainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.userControlMenu = new ATDsolution.UserControlMenu();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(612, 31);
            this.panelTop.TabIndex = 1;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = global::ATDsolution.Properties.Resources.icon_menu_orange;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenu.Location = new System.Drawing.Point(8, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(31, 26);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // userControlMenu
            // 
            this.userControlMenu.Location = new System.Drawing.Point(3, 34);
            this.userControlMenu.Name = "userControlMenu";
            this.userControlMenu.Size = new System.Drawing.Size(278, 189);
            this.userControlMenu.TabIndex = 0;
            this.userControlMenu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 303);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.userControlMenu);
            this.Name = "Form1";
            this.Text = "Form";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlMenu userControlMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonMenu;
    }
}

