/*******************************************************************************
 *
 * Space Trader for Windows 2.00
 *
 * Copyright (C) 2004 Jay French, All Rights Reserved
 *
 * Additional coding by David Pierron
 * Original coding by Pieter Spronck, Sam Anderson, Samuel Goldstein, Matt Lee
 *
 * This program is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License as published by the Free
 * Software Foundation; either version 2 of the License, or (at your option) any
 * later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * If you'd like a copy of the GNU General Public License, go to
 * http://www.gnu.org/copyleft/gpl.html.
 *
 * You can contact the author at spacetrader@frenchfryz.com
 *
 ******************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Fryz.Apps.SpaceTrader
{
	public class FormAbout : System.Windows.Forms.Form
	{
		#region Control Declarations

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblAbout;
		private System.Windows.Forms.PictureBox picLogo;
		private System.ComponentModel.Container components = null;

		#endregion

		#region Methods

		public FormAbout()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormAbout));
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblAbout = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			//
			// btnClose
			//
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(-32, -32);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(32, 32);
			this.btnClose.TabIndex = 32;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "X";
			//
			// lblTitle
			//
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(172, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(163, 13);
			this.lblTitle.TabIndex = 33;
			this.lblTitle.Text = "Space Trader for Windows " + Consts.CurrentVersion;
			//
			// lblAbout
			//
			this.lblAbout.Location = new System.Drawing.Point(172, 32);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(272, 160);
			this.lblAbout.TabIndex = 34;
			this.lblAbout.Text = "Copyright " + Strings.CopyrightChar +
				" 2005 by Jay French" + Environment.NewLine + "spacetrader@frenchfryz.com" + Environment.NewLine + Environment.NewLine + "Palm version copyright " +
				Strings.CopyrightChar + " 2000-2002 by Peter Spronk" + Environment.NewLine + "space_trader@hotmail.com" + Environment.NewLine + Environment.NewLine + "Pictures copyright " +
				Strings.CopyrightChar + " 2000 by Alexander Lawrence" + Environment.NewLine + Environment.NewLine + "This game is freeware under a GNU General " +
				"Public License." + Environment.NewLine + Environment.NewLine + "http://spacetraderwin.sourceforge.net/";
			//
			// picLogo
			//
			this.picLogo.Image = ((System.Drawing.Bitmap)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(8, 8);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(160, 160);
			this.picLogo.TabIndex = 35;
			this.picLogo.TabStop = false;
			//
			// FormAbout
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(446, 191);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.picLogo,
																																	this.lblAbout,
																																	this.lblTitle,
																																	this.btnClose});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Space Trader";
			this.ResumeLayout(false);
		}
		#endregion

		#endregion
	}
}
