/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 22/10/2024
 * Time: 07:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jijijixd
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
		string ss="";
		void Button1Click(object sender, EventArgs e)
		{
			if(txt_ap1.Text==ss||txt_ap2.Text==ss||txt_dir.Text==ss||txt_fcn.Text==ss||txt_nom.Text==ss||txt_tel.Text==ss||cmb_1.Text==ss)
			{
				MessageBox.Show("Datos incompletos >:v");
			}
			else
			{
				string dia=txt_fcn.Text;
				dia=dia.Substring(0, 2);
				string mes=txt_fcn.Text;
				mes=mes.Substring(2, 4);
				string año=txt_fcn.Text;
				año=año.Substring(4, 6);
				string mfmf=año+mes+dia;
				lbl_final.Text=mfmf.ToString();
			}
		}
	}
}
