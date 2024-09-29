/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace controllerShapeTest
{
	partial class controllerShape
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.SuspendLayout();
			// 
			// controllerShape
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "controllerShape";
			this.Size = new System.Drawing.Size(240, 101);
			this.Load += new System.EventHandler(this.ControllerShapeLoad);
			this.ResumeLayout(false);

		}
	}
}
