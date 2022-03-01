/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01/03/2022
 * Time: 11.33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugaspertemuan3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			string label1 = nama.Text;
			int label2 = int.Parse(nim.Text);
			string label3 = matkul.Text;
			
			listbox.Items.Add("Nama		= "+label1);
			listbox.Items.Add("Nim		= "+label2);
			listbox.Items.Add("Matkul yang diambil	= "+label3);
			
			nama.Clear();
			nim.Clear();
			matkul.Clear();

		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
