/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 09/06/2022
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PengunjungPerpus
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.comboBoxJenKel = new System.Windows.Forms.ComboBox();
			this.comboBoxDurasi = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.AliceBlue;
			this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(1, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1468, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buku Tamu Perpustakaan";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "No. :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 34);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jenis Kelamin :";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(229, 34);
			this.label5.TabIndex = 4;
			this.label5.Text = "Durasi Berkunjung :";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(23, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 34);
			this.label6.TabIndex = 5;
			this.label6.Text = "Buku Bacaan :";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(246, 129);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(298, 33);
			this.txtID.TabIndex = 6;
			// 
			// txtNama
			// 
			this.txtNama.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNama.Location = new System.Drawing.Point(246, 174);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(298, 33);
			this.txtNama.TabIndex = 1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(246, 309);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(298, 107);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// comboBoxJenKel
			// 
			this.comboBoxJenKel.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxJenKel.FormattingEnabled = true;
			this.comboBoxJenKel.Items.AddRange(new object[] {
									"Pria",
									"Wanita"});
			this.comboBoxJenKel.Location = new System.Drawing.Point(246, 214);
			this.comboBoxJenKel.Name = "comboBoxJenKel";
			this.comboBoxJenKel.Size = new System.Drawing.Size(298, 35);
			this.comboBoxJenKel.TabIndex = 2;
			// 
			// comboBoxDurasi
			// 
			this.comboBoxDurasi.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDurasi.FormattingEnabled = true;
			this.comboBoxDurasi.Items.AddRange(new object[] {
									"Dibawah 1 Jam",
									"1 Jam",
									"2 Jam",
									"3 Jam",
									"4 Jam",
									"5 Jam"});
			this.comboBoxDurasi.Location = new System.Drawing.Point(246, 260);
			this.comboBoxDurasi.Name = "comboBoxDurasi";
			this.comboBoxDurasi.Size = new System.Drawing.Size(298, 35);
			this.comboBoxDurasi.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(581, 128);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(99, 35);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(581, 184);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(99, 35);
			this.btnEdit.TabIndex = 12;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Location = new System.Drawing.Point(581, 237);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(99, 35);
			this.btnDel.TabIndex = 13;
			this.btnDel.Text = "Delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(581, 292);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(99, 35);
			this.btnClear.TabIndex = 14;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(716, 129);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(720, 287);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1472, 468);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.comboBoxDurasi);
			this.Controls.Add(this.comboBoxJenKel);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "PengunjungPerpus";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox comboBoxDurasi;
		private System.Windows.Forms.ComboBox comboBoxJenKel;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
