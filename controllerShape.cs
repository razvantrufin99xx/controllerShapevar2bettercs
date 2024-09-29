/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
	
namespace controllerShapeTest
{
	/// <summary>
	/// Description of controllerShape.
	/// </summary>
	public partial class controllerShape : UserControl
	{
		public controllerShape()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public List<dot> dots = new List<dot>();
		public int x=0;
		public int y=0;
		public int w=0;
		public int h=0;
		public void setxywd(int px, int py, int pw, int ph)
		{
			x=  px;
			y = py;
			w = pw;
			h = ph;
			this.Left = x;
			this.Top = y;
			this.Width = w+6;
			this.Height = h+6;
		}
		
		
		public void forceRefresh()
		{
			
			dots[0].Left = x;
			dots[0].Top = y;
			
			dots[1].Left = w/2;
			dots[1].Top = y;
			
			dots[2].Left = w;
			dots[2].Top = y;
			
			dots[3].Left = w;
			dots[3].Top = h/2;
			
			dots[4].Left = w;
			dots[4].Top = h;
			
			dots[5].Left =w/2;
			dots[5].Top =  h;
			
			dots[6].Left = x;
			dots[6].Top =  h;
			
			dots[7].Left = x;
			dots[7].Top =  h/2;
			
			this.Refresh();
		}
			
			
		void ControllerShapeLoad(object sender, EventArgs e)
		{
			
			 
		
		
	for(int i = 0 ; i < 8 ;i++)
			{
				dots.Add(new dot());
				dots[i].Left = 0;
				dots[i].Top = 0;
				dots[i].Width = 6;
				dots[i].Height = 6;
				dots[i].BackColor = Color.Black;
				this.Controls.Add(dots[i]);
				dots[i].Visible = true;
				
				
			}
	
	
			dots[0].Left = x;
			dots[0].Top = y;
			
			dots[1].Left = w/2;
			dots[1].Top = y;
			
			dots[2].Left = w;
			dots[2].Top = y;
			
			dots[3].Left = w;
			dots[3].Top = h/2;
			
			dots[4].Left = w;
			dots[4].Top = h;
			
			dots[5].Left =w/2;
			dots[5].Top =  h;
			
			dots[6].Left = x;
			dots[6].Top =  h;
			
			dots[7].Left = x;
			dots[7].Top =  h/2;
			
			this.Refresh();
			
		}
		
		
	}
}
