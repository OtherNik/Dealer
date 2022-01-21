using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Dealer
{
    public partial class FormMain : Form
    {
        private IconButton currnetBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(195, 241, 126);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currnetBtn = (IconButton)senderBtn;
                currnetBtn.BackColor = Color.FromArgb(37, 36, 81);
                currnetBtn.ForeColor = color;
                currnetBtn.TextAlign = ContentAlignment.MiddleCenter;
                currnetBtn.IconColor = color;
                currnetBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currnetBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currnetBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                IconCurrentChildForm.IconChar = currnetBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }
         private void DisableButton()
        {
            if(currnetBtn != null)
            {
                currnetBtn.BackColor = Color.MidnightBlue;
                currnetBtn.ForeColor = Color.Gainsboro;
                currnetBtn.TextAlign = ContentAlignment.MiddleLeft;
                currnetBtn.IconColor = Color.Gainsboro;
                currnetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currnetBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }



        private void btnOdzKatowice_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            //OpenChildForm(new FormKatowice());
        }

        private void btnOdzLodz_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FormLodz());
        }

        private void btnOdzKambodza_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormKambodza());
        }
        private void iconbtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fLogIn = new FormLogin();
            fLogIn.Show();
        }
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWand, int wMsg, int wParam, int lPram);



        private void UpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)            //czas
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToLongTimeString();
            labelDate.Text = System.DateTime.Now.ToLongDateString();
            timer1.Start();
        }
        private void FormMain_Load(object sender, EventArgs e)      //dodanie czasu i daty
        {
            labelTime.Text = System.DateTime.Now.ToLongTimeString();
            labelDate.Text = System.DateTime.Now.ToLongDateString();
        }
        private void panelLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }
    }
}
