﻿
namespace VariablenUndDatentypen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAnzeigen = new System.Windows.Forms.Button();
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAnzeigen
			// 
			this.btnAnzeigen.Location = new System.Drawing.Point(220, 283);
			this.btnAnzeigen.Name = "btnAnzeigen";
			this.btnAnzeigen.Size = new System.Drawing.Size(181, 69);
			this.btnAnzeigen.TabIndex = 0;
			this.btnAnzeigen.Text = "Variablen anzeigen";
			this.btnAnzeigen.UseVisualStyleBackColor = true;
			this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(216, 66);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(51, 20);
			this.lblAnzeige.TabIndex = 1;
			this.lblAnzeige.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAnzeige);
			this.Controls.Add(this.btnAnzeigen);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnzeigen;
		private System.Windows.Forms.Label lblAnzeige;
	}
}

