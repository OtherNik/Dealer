using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using FontAwesome.Sharp;

namespace Dealer
{
    public partial class FormLodz : Form
    {
        public FormLodz()
        {
            InitializeComponent();
        }

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SQLiteConnection("Data Source=DataBaseLodz.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select * From PojazdyLodz", con);
            ds = new DataSet();
            da.Fill(ds, "PojazdyLodz");
            dataGridView1.DataSource = ds.Tables["PojazdyLodz"];
        }

        private void FormLodz_Load(object sender, EventArgs e)
        {
            if (!File.Exists("DataBaseLodz.sqlite")) //tworzy plik bazodanowy jeśli nie istnieje, znajduje sie w bin/debug
            {
                SQLiteConnection.CreateFile("DataBaseLodz.sqlite");   //tworzenie tabeli 

                string sql = @"CREATE TABLE PojazdyLodz(            
                                VIN                 INT NOT NULL,
                                Marka               TEXT    NOT NULL,
                                Model               TEXT    NOT NULL,
                                Rocznik             INT     NOT NULL,
                                PojemnoscSilnika    INT     NOT NULL,
                                MocSilnika          INT     NOT NULL,
                                Kolor               TEXT    NOT NULL,
                                Cena                INT     NOT NULL
                                );";
                con = new SQLiteConnection("Data Source=DataBaseLodz.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            GetList();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into PojazdyLodz(VIN,Marka,Model,Rocznik,PojemnoscSilnika,MocSilnika,Kolor,Cena) values ('" + txtVIN.Text + "','" + txtMark.Text + "','" + txtModel.Text + "','" + txtYear.Text + "','" + txtCapacity.Text + "','" + txtHP.Text + "','" + txtColor.Text + "','" + txtPrice.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            txtVIN.Clear(); //po dodaniu czyści textboxa
            txtMark.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtCapacity.Clear();
            txtHP.Clear();
            txtColor.Clear();
            txtPrice.Clear();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from PojazdyLodz where VIN=" + txtVIN.Text + ""; //usuwa po wprowadzeniu ID 
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            txtVIN.Clear();
        }
        private void txtVIN_Enter(object sender, EventArgs e)
        {
            if (txtVIN.Text == "VIN")
            {
                txtVIN.Text = "";
                txtVIN.ForeColor = Color.Black;
            }
        }

        private void txtVIN_Leave(object sender, EventArgs e)
        {
            if (txtVIN.Text == "")
            {
                txtVIN.Text = "VIN";
                txtVIN.ForeColor = Color.Silver;
            }
        }
        private void txtMark_Enter(object sender, EventArgs e)
        {
            if (txtMark.Text == "MARKA")
            {
                txtMark.Text = "";
                txtMark.ForeColor = Color.Black;
            }
        }

        private void txtMark_Leave(object sender, EventArgs e)
        {
            if (txtMark.Text == "")
            {
                txtMark.Text = "MARKA";
                txtMark.ForeColor = Color.Silver;
            }
        }

        private void txtModel_Enter(object sender, EventArgs e)
        {
            if (txtModel.Text == "MODEL")
            {
                txtModel.Text = "";
                txtModel.ForeColor = Color.Black;
            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                txtModel.Text = "MODEL";
                txtModel.ForeColor = Color.Silver;
            }
        }

        private void txtYear_Enter(object sender, EventArgs e)
        {
            if (txtYear.Text == "ROCZNIK")
            {
                txtYear.Text = "";
                txtYear.ForeColor = Color.Black;
            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                txtYear.Text = "ROCZNIK";
                txtYear.ForeColor = Color.Silver;
            }
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "POJ. SILNIKA")
            {
                txtCapacity.Text = "";
                txtCapacity.ForeColor = Color.Black;
            }
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "")
            {
                txtCapacity.Text = "POJ. SILNIKA";
                txtCapacity.ForeColor = Color.Silver;
            }
        }

        private void txtHP_Enter(object sender, EventArgs e)
        {
            if (txtHP.Text == "MOC SILNIKA (KM)")
            {
                txtHP.Text = "";
                txtHP.ForeColor = Color.Black;
            }
        }

        private void txtHP_Leave(object sender, EventArgs e)
        {
            if (txtHP.Text == "")
            {
                txtHP.Text = "MOC SILNIKA (KM)";
                txtHP.ForeColor = Color.Silver;
            }
        }

        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "KOLOR")
            {
                txtColor.Text = "";
                txtColor.ForeColor = Color.Black;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "KOLOR";
                txtColor.ForeColor = Color.Silver;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "CENA")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "CENA";
                txtPrice.ForeColor = Color.Silver;
            }
        }
    }
}
