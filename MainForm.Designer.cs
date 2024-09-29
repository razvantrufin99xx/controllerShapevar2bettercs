/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace controllerShapeTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private controllerShapeTest.controllerShape controllerShape1;
		
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
			this.controllerShape1 = new controllerShapeTest.controllerShape();
			this.SuspendLayout();
			// 
			// controllerShape1
			// 
			this.controllerShape1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.controllerShape1.Location = new System.Drawing.Point(55, 53);
			this.controllerShape1.Name = "controllerShape1";
			this.controllerShape1.Size = new System.Drawing.Size(240, 101);
			this.controllerShape1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 334);
			this.Controls.Add(this.controllerShape1);
			this.Name = "MainForm";
			this.Text = "controllerShapeTest";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
