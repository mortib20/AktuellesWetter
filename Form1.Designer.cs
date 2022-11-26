namespace Wetter
{
	partial class WetterForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WetterForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.LBeschreibung = new System.Windows.Forms.Label();
			this.LDruck = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LFeuchtigkeit = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LRichtung = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LWind = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LTemperatur = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.BUpdate = new System.Windows.Forms.Button();
			this.TBOrt = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Name = "panel1";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.LBeschreibung, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.LDruck, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.LFeuchtigkeit, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.LRichtung, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LWind, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LTemperatur, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// LBeschreibung
			// 
			resources.ApplyResources(this.LBeschreibung, "LBeschreibung");
			this.LBeschreibung.Name = "LBeschreibung";
			// 
			// LDruck
			// 
			resources.ApplyResources(this.LDruck, "LDruck");
			this.LDruck.Name = "LDruck";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// LFeuchtigkeit
			// 
			resources.ApplyResources(this.LFeuchtigkeit, "LFeuchtigkeit");
			this.LFeuchtigkeit.Name = "LFeuchtigkeit";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// LRichtung
			// 
			resources.ApplyResources(this.LRichtung, "LRichtung");
			this.LRichtung.Name = "LRichtung";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// LWind
			// 
			resources.ApplyResources(this.LWind, "LWind");
			this.LWind.Name = "LWind";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// LTemperatur
			// 
			resources.ApplyResources(this.LTemperatur, "LTemperatur");
			this.LTemperatur.Name = "LTemperatur";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// panel2
			// 
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Controls.Add(this.BUpdate);
			this.panel2.Controls.Add(this.TBOrt);
			this.panel2.Name = "panel2";
			// 
			// BUpdate
			// 
			resources.ApplyResources(this.BUpdate, "BUpdate");
			this.BUpdate.Name = "BUpdate";
			this.BUpdate.UseVisualStyleBackColor = true;
			this.BUpdate.Click += new System.EventHandler(this.UpdateWetterClick);
			// 
			// TBOrt
			// 
			resources.ApplyResources(this.TBOrt, "TBOrt");
			this.TBOrt.Name = "TBOrt";
			// 
			// WetterForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "WetterForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Button BUpdate;
		private TextBox TBOrt;
		private TableLayoutPanel tableLayoutPanel1;
		private Label LWind;
		private Label label3;
		private Label LTemperatur;
		private Label label1;
		private Label label6;
		private Label LFeuchtigkeit;
		private Label label4;
		private Label LRichtung;
		private Label label2;
		private Label LDruck;
		private Label label7;
		private Label LBeschreibung;
	}
}