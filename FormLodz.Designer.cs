namespace Dealer
{
    partial class FormLodz
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDeleteCar = new FontAwesome.Sharp.IconButton();
            this.btnAddCar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Size = new System.Drawing.Size(844, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtVIN
            // 
            this.txtVIN.BackColor = System.Drawing.Color.Gainsboro;
            this.txtVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVIN.ForeColor = System.Drawing.Color.DarkGray;
            this.txtVIN.Location = new System.Drawing.Point(39, 37);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(170, 23);
            this.txtVIN.TabIndex = 3;
            this.txtVIN.Text = "VIN";
            this.txtVIN.Enter += new System.EventHandler(this.txtVIN_Enter);
            this.txtVIN.Leave += new System.EventHandler(this.txtVIN_Leave);
            // 
            // txtMark
            // 
            this.txtMark.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMark.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMark.Location = new System.Drawing.Point(242, 37);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(170, 23);
            this.txtMark.TabIndex = 4;
            this.txtMark.Text = "MARKA";
            this.txtMark.Enter += new System.EventHandler(this.txtMark_Enter);
            this.txtMark.Leave += new System.EventHandler(this.txtMark_Leave);
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.ForeColor = System.Drawing.Color.DarkGray;
            this.txtModel.Location = new System.Drawing.Point(445, 37);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(170, 23);
            this.txtModel.TabIndex = 5;
            this.txtModel.Text = "MODEL";
            this.txtModel.Enter += new System.EventHandler(this.txtModel_Enter);
            this.txtModel.Leave += new System.EventHandler(this.txtModel_Leave);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Gainsboro;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYear.ForeColor = System.Drawing.Color.DarkGray;
            this.txtYear.Location = new System.Drawing.Point(648, 37);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(170, 23);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "ROCZNIK";
            this.txtYear.Enter += new System.EventHandler(this.txtYear_Enter);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCapacity.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCapacity.Location = new System.Drawing.Point(39, 84);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(170, 23);
            this.txtCapacity.TabIndex = 7;
            this.txtCapacity.Text = "POJ. SILNIKA";
            this.txtCapacity.Enter += new System.EventHandler(this.txtCapacity_Enter);
            this.txtCapacity.Leave += new System.EventHandler(this.txtCapacity_Leave);
            // 
            // txtHP
            // 
            this.txtHP.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtHP.Location = new System.Drawing.Point(242, 84);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(170, 23);
            this.txtHP.TabIndex = 8;
            this.txtHP.Text = "MOC SILNIKA (KM)";
            this.txtHP.Enter += new System.EventHandler(this.txtHP_Enter);
            this.txtHP.Leave += new System.EventHandler(this.txtHP_Leave);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtColor.ForeColor = System.Drawing.Color.DarkGray;
            this.txtColor.Location = new System.Drawing.Point(445, 84);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(170, 23);
            this.txtColor.TabIndex = 9;
            this.txtColor.Text = "KOLOR";
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Location = new System.Drawing.Point(648, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 23);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Text = "CENA";
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteCar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteCar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteCar.IconSize = 32;
            this.btnDeleteCar.Location = new System.Drawing.Point(531, 155);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(175, 55);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.Text = "Usuń";
            this.btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Green;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCar.IconSize = 32;
            this.btnAddCar.Location = new System.Drawing.Point(152, 155);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(175, 55);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Dodaj";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // FormLodz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(874, 581);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(890, 620);
            this.Name = "FormLodz";
            this.Text = "FormLodz";
            this.Load += new System.EventHandler(this.FormLodz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnAddCar;
        private FontAwesome.Sharp.IconButton btnDeleteCar;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
    }
}