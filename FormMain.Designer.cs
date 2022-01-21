namespace Dealer
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnOdzKambodza = new FontAwesome.Sharp.IconButton();
            this.btnOdzLodz = new FontAwesome.Sharp.IconButton();
            this.btnOdzKatowice = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnOdzKambodza);
            this.panelMenu.Controls.Add(this.btnOdzLodz);
            this.panelMenu.Controls.Add(this.btnOdzKatowice);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 641);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 52;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "ZAMKNIJ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 52;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 244);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Size = new System.Drawing.Size(200, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "WYLOGUJ";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.iconbtnLogOut_Click);
            // 
            // btnOdzKambodza
            // 
            this.btnOdzKambodza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdzKambodza.FlatAppearance.BorderSize = 0;
            this.btnOdzKambodza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdzKambodza.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOdzKambodza.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnOdzKambodza.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOdzKambodza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOdzKambodza.IconSize = 52;
            this.btnOdzKambodza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzKambodza.Location = new System.Drawing.Point(0, 194);
            this.btnOdzKambodza.Name = "btnOdzKambodza";
            this.btnOdzKambodza.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOdzKambodza.Size = new System.Drawing.Size(200, 50);
            this.btnOdzKambodza.TabIndex = 4;
            this.btnOdzKambodza.Text = "ODDZIAŁ KAMBODŻA";
            this.btnOdzKambodza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzKambodza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdzKambodza.UseVisualStyleBackColor = true;
            this.btnOdzKambodza.Click += new System.EventHandler(this.btnOdzKambodza_Click);
            // 
            // btnOdzLodz
            // 
            this.btnOdzLodz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdzLodz.FlatAppearance.BorderSize = 0;
            this.btnOdzLodz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdzLodz.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOdzLodz.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnOdzLodz.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOdzLodz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOdzLodz.IconSize = 52;
            this.btnOdzLodz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzLodz.Location = new System.Drawing.Point(0, 144);
            this.btnOdzLodz.Name = "btnOdzLodz";
            this.btnOdzLodz.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOdzLodz.Size = new System.Drawing.Size(200, 50);
            this.btnOdzLodz.TabIndex = 3;
            this.btnOdzLodz.Text = "ODDZIAŁ ŁÓDZ";
            this.btnOdzLodz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzLodz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdzLodz.UseVisualStyleBackColor = true;
            this.btnOdzLodz.Click += new System.EventHandler(this.btnOdzLodz_Click);
            // 
            // btnOdzKatowice
            // 
            this.btnOdzKatowice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdzKatowice.FlatAppearance.BorderSize = 0;
            this.btnOdzKatowice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdzKatowice.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOdzKatowice.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnOdzKatowice.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOdzKatowice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOdzKatowice.IconSize = 52;
            this.btnOdzKatowice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzKatowice.Location = new System.Drawing.Point(0, 94);
            this.btnOdzKatowice.Name = "btnOdzKatowice";
            this.btnOdzKatowice.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOdzKatowice.Size = new System.Drawing.Size(200, 50);
            this.btnOdzKatowice.TabIndex = 2;
            this.btnOdzKatowice.Text = "ODDZIAŁ KATOWICE";
            this.btnOdzKatowice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdzKatowice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdzKatowice.UseVisualStyleBackColor = true;
            this.btnOdzKatowice.Click += new System.EventHandler(this.btnOdzKatowice_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(200, 94);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.UpPanel.Controls.Add(this.labelTime);
            this.UpPanel.Controls.Add(this.iconPictureBox2);
            this.UpPanel.Controls.Add(this.labelDate);
            this.UpPanel.Controls.Add(this.iconPictureBox1);
            this.UpPanel.Controls.Add(this.labelTitle);
            this.UpPanel.Controls.Add(this.IconCurrentChildForm);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(200, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(874, 51);
            this.UpPanel.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(647, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 18);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 45;
            this.iconPictureBox2.Location = new System.Drawing.Point(596, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(45, 50);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDate.Location = new System.Drawing.Point(385, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(43, 18);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(334, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 50);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(67, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 18);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 45;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(16, 12);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(45, 50);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 9);
            this.panel1.TabIndex = 11;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.lblWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(874, 581);
            this.panelDesktop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(236, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "to the app";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblWelcome.Location = new System.Drawing.Point(247, 152);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(378, 91);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1074, 641);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpPanel);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1090, 680);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer samochodowy – zarządzanie dystrybucją Zwoliński, Sroczkowski, Skoczylas";
            this.panelMenu.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnOdzKambodza;
        private FontAwesome.Sharp.IconButton btnOdzLodz;
        private FontAwesome.Sharp.IconButton btnOdzKatowice;
        private System.Windows.Forms.Panel UpPanel;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label labelTime;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelDate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

