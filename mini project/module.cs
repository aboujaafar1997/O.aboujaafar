﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class module : Form
    {
        public module()
        {
            InitializeComponent();
        }

        private void module_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Cco.adapter = new OracleDataAdapter("select * from matiere ", Cco.cn);
            Cco.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }

        private void BunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Cco.cmd = new OracleCommand("INSERT INTO module values('" + bunifuMetroTextbox1.Text + "' , '" + bunifuMetroTextbox2.Text+ "' )", Cco.cn);
            Cco.cn.Open();
            Cco.cmd.ExecuteNonQuery();
            Cco.cn.Close();
            DataTable dt1 = new DataTable();
            Cco.adapter = new OracleDataAdapter("select * from module ", Cco.cn);
            Cco.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            Cco.cmd = new OracleCommand("delete from module where ID_MAT ='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].ToString().ToUpper() + "' )", Cco.cn);
            Cco.cn.Open();
            Cco.cmd.ExecuteNonQuery();
            Cco.cn.Close();
            DataTable dt1 = new DataTable();
            Cco.adapter = new OracleDataAdapter("select * from module ", Cco.cn);
            Cco.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }
    }
}
