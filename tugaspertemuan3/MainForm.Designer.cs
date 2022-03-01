/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01/03/2022
 * Time: 11.33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugaspertemuan3
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.TextBox();
			this.nim = new System.Windows.Forms.TextBox();
			this.listbox = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.matkul = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Tampilkan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nama Mahasiswa";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "NIM Mahasiswa";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(165, 40);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(141, 20);
			this.nama.TabIndex = 3;
			this.nama.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// nim
			// 
			this.nim.Location = new System.Drawing.Point(165, 85);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(141, 20);
			this.nim.TabIndex = 4;
			this.nim.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// listbox
			// 
			this.listbox.FormattingEnabled = true;
			this.listbox.Location = new System.Drawing.Point(12, 272);
			this.listbox.Name = "listbox";
			this.listbox.Size = new System.Drawing.Size(294, 95);
			this.listbox.TabIndex = 6;
			this.listbox.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mata Kuliah ";
			// 
			// matkul
			// 
			this.matkul.Location = new System.Drawing.Point(165, 134);
			this.matkul.Name = "matkul";
			this.matkul.Size = new System.Drawing.Size(141, 20);
			this.matkul.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 468);
			this.Controls.Add(this.matkul);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listbox);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "tugaspertemuan3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox matkul;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listbox;
		private System.Windows.Forms.TextBox nim;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
