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

namespace Dealer
{
    public partial class FormKambodza : Form
    {
        public FormKambodza()
        {
            InitializeComponent();
        }
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SQLiteConnection("Data Source=DataBaseKambodza.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select * From PojazdyKambodza", con);
            ds = new DataSet();
            da.Fill(ds, "PojazdyKambodza");
            dataGridView1.DataSource = ds.Tables["PojazdyKambodza"];
        }

        private void FormKambodza_Load(object sender, EventArgs e)
        {
            if (!File.Exists("DataBaseKambodza.sqlite")) //tworzy plik bazodanowy jeśli nie istnieje, znajduje sie w bin/debug
            {
                SQLiteConnection.CreateFile("DataBaseKambodza.sqlite");   //tworzenie tabeli 

                string sql = @"CREATE TABLE PojazdyKambodza(            
                                VIN                 INT NOT NULL,
                                Marka               TEXT    NOT NULL,
                                Model               TEXT    NOT NULL,
                                Rocznik             INT     NOT NULL,
                                PojemnoscSilnika    INT     NOT NULL,
                                MocSilnika          INT     NOT NULL,
                                Kolor               TEXT    NOT NULL,
                                Cena                INT     NOT NULL
                                );";
                con = new SQLiteConnection("Data Source=DataBaseKambodza.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            GetList();
        }

        private void txtVIN_Enter(object sender, EventArgs e)
        {
            if (txtVIN.Text == "VIN")
            {
                txtVIN.Text = "";
                txtVIN.ForeColor = Color.LightGray;
            }
        }

        private void txtVIN_Leave(object sender, EventArgs e)
        {
            if (txtVIN.Text == "")
            {
                txtVIN.Text = "VIN";
                txtVIN.ForeColor = Color.DimGray;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into PojazdyKambodza(VIN,Marka,Model,Rocznik,PojemnoscSilnika,MocSilnika,Kolor,Cena) values ('" + txtVIN.Text + "','" + txtMark.Text + "','" + txtModel.Text + "','" + txtYear.Text + "','" + txtCapacity.Text + "','" + txtHP.Text + "','" + txtColor.Text + "','" + txtPrice.Text + "')";
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
            cmd.CommandText = "delete from PojazdyKambodza where VIN=" + txtVIN.Text + ""; //usuwa po wprowadzeniu ID 
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            txtVIN.Clear();
        }
    }
}
