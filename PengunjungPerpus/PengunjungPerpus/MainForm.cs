/*
 * Created by SharpDevelop.
 * User: Puan Abidah
 * Date: 09/06/2022
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace PengunjungPerpus
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = data_kunjungan_perpus; Uid = root;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_tamu";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_tamu") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_tamu";
				}
				else {
					MessageBox.Show("Data tabel sedang kosong");
				}
			}
			catch (Exception ex){
				MessageBox.Show("Data tidak dapat dimasukkan");
				MessageBox.Show(ex.ToString());
			}
		}
		
		void NoID()
		{
			long hitung;
			string urutan;
			mycommand.Connection=co;
			mycommand.CommandText="select No from tbl_tamu where No in(select max(No) from tbl_tamu) order by No desc";
			myadapter.SelectCommand = mycommand;
			MySqlDataReader reader1;
			reader1 = mycommand.ExecuteReader();
			reader1.Read();
			if(reader1.HasRows)
			{
				hitung = Convert.ToInt64(reader1[0].ToString().Substring(reader1["No"].ToString().Length - 3, 3))+1;
				string kodeurutan = "000"+hitung;
				urutan = kodeurutan.Substring(kodeurutan.Length - 3,3);
			}
			else
			{
				urutan = "001";
			}
			reader1.Close();
			txtID.Text = urutan;
		}
		
		public void ClearData(){
			txtID.Text="";
			txtNama.Text="";
			comboBoxJenKel.Text="";
			comboBoxDurasi.Text="";
			richTextBox1.Text="";
			ReadData();
			NoID();
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			NoID();
			ClearData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				comboBoxJenKel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				comboBoxDurasi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
	
		void BtnSaveClick(object sender, EventArgs e)
		{
			// Memeriksa apakah kolom text kosong?
			if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || comboBoxJenKel.Text.Trim() == "" || comboBoxDurasi.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* SAVE DATA */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="insert into tbl_tamu values('"+txtID.Text+"','"+txtNama.Text+"','"+comboBoxJenKel.Text+"','"+comboBoxDurasi.Text+"','"+richTextBox1.Text+"')";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						ClearData();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			// Memeriksa apakah kolom text kosong?
			if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || comboBoxJenKel.Text.Trim() == "" || comboBoxDurasi.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* EDIT DATA */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="update tbl_tamu set No='"+txtID.Text+"', Nama='"+txtNama.Text+"', JenisKelamin='"+comboBoxJenKel.Text+"', DurasiKunjungan='"+comboBoxDurasi.Text+"', BukuBacaan='"+richTextBox1.Text+"' where No='"+txtID.Text+"'";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Update data berhasil","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						ClearData();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void BtnDelClick(object sender, EventArgs e)
		{
			// Memeriksa apakah sudah ada data yang terpilih?
			if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || comboBoxJenKel.Text.Trim() == "" || comboBoxDurasi.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else if (MessageBox.Show("Apakah yakin ingin menghapus pengunjung dengan nama " + txtNama.Text + "?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				
				/* DELETE DATA */
				try {
					mycommand.Connection=co;
					mycommand.CommandText="delete from tbl_tamu where No='"+txtID.Text+"'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery()==1) {
						MessageBox.Show("Data berhasil dihapus");
						ReadData();
						ClearData();
					}
				}
				catch(Exception ex) {
					MessageBox.Show(ex.ToString());
				}
			}			
		}
	}
}
