namespace Proyecto_Final
{
	partial class CrearCatego
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btn_ingres = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stocat = new System.Windows.Forms.TextBox();
            this.txt_nomcat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ingres
            // 
            this.btn_ingres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingres.Location = new System.Drawing.Point(115, 250);
            this.btn_ingres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ingres.Name = "btn_ingres";
            this.btn_ingres.Size = new System.Drawing.Size(128, 39);
            this.btn_ingres.TabIndex = 38;
            this.btn_ingres.Text = "Ingresar";
            this.btn_ingres.UseVisualStyleBackColor = true;
            this.btn_ingres.Click += new System.EventHandler(this.btn_ingres_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ingresa el stock:";
            // 
            // txt_stocat
            // 
            this.txt_stocat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stocat.Location = new System.Drawing.Point(157, 182);
            this.txt_stocat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_stocat.Name = "txt_stocat";
            this.txt_stocat.Size = new System.Drawing.Size(253, 23);
            this.txt_stocat.TabIndex = 36;
            // 
            // txt_nomcat
            // 
            this.txt_nomcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomcat.Location = new System.Drawing.Point(157, 115);
            this.txt_nomcat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nomcat.Name = "txt_nomcat";
            this.txt_nomcat.Size = new System.Drawing.Size(253, 23);
            this.txt_nomcat.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ingresa el nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Registro de Categorias";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(354, 251);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(133, 39);
            this.btn_salir.TabIndex = 39;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // CrearCatego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 320);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_stocat);
            this.Controls.Add(this.txt_nomcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearCatego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Registros de Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ingres;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_stocat;
		private System.Windows.Forms.TextBox txt_nomcat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_salir;
	}
}