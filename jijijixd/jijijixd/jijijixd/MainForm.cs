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
				string ape1=txt_ap1.Text;
				ape1=ape1.Substring(0, 2);
				string fecha=txt_fcn.Text;
				char ape2=txt_ap2.Text[0];
				char nom=txt_nom.Text[0];
				string dia=fecha.Substring(0,2);
				string mes=fecha.Substring(3,2);
				string anio=fecha.Substring(6,2);
				string mfmf=ape1+ape2+nom+anio+mes+dia;
				label9.Text=mfmf.ToString();
				string textToPass = txt_nom.Text+" "+txt_ap1.Text+" "+txt_ap2.Text;
				string textToPass2 = label9.Text;
    			Form2 form2 = new Form2(textToPass, textToPass2);
    			form2.Show();
			}
		}
		
	}
}
