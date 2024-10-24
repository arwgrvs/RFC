/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 23/10/2024
 * Time: 07:53 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace jijijixd
{
	partial class Form2
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
			this.lbl_rfc = new System.Windows.Forms.Label();
			this.lbl_nom2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_rfc
			// 
			this.lbl_rfc.Location = new System.Drawing.Point(197, 275);
			this.lbl_rfc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_rfc.Name = "lbl_rfc";
			this.lbl_rfc.Size = new System.Drawing.Size(220, 61);
			this.lbl_rfc.TabIndex = 0;
			this.lbl_rfc.Text = "____________";
			// 
			// lbl_nom2
			// 
			this.lbl_nom2.Location = new System.Drawing.Point(197, 154);
			this.lbl_nom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_nom2.Name = "lbl_nom2";
			this.lbl_nom2.Size = new System.Drawing.Size(269, 97);
			this.lbl_nom2.TabIndex = 1;
			this.lbl_nom2.Text = "____________";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 154);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(71, 275);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "RFC";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(144, 29);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(283, 77);
			this.label3.TabIndex = 4;
			this.label3.Text = "Datos completos";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 42);
			this.button1.TabIndex = 5;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 437);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_nom2);
			this.Controls.Add(this.lbl_rfc);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form2";
			this.Text = "RFC";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_nom2;
		private System.Windows.Forms.Label lbl_rfc;
	}
}
