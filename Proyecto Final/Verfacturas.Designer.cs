namespace Proyecto_Final
{
	partial class Verfacturas
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
            this.txt_idfact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_busc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_subtot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idfact
            // 
            this.txt_idfact.Location = new System.Drawing.Point(362, 144);
            this.txt_idfact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idfact.Name = "txt_idfact";
            this.txt_idfact.Size = new System.Drawing.Size(132, 22);
            this.txt_idfact.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el ID de la factura que esta buscando:";
            // 
            // btn_busc
            // 
            this.btn_busc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc.Location = new System.Drawing.Point(634, 106);
            this.btn_busc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_busc.Name = "btn_busc";
            this.btn_busc.Size = new System.Drawing.Size(132, 60);
            this.btn_busc.TabIndex = 7;
            this.btn_busc.Text = "Buscar Registros";
            this.btn_busc.UseVisualStyleBackColor = true;
            this.btn_busc.Click += new System.EventHandler(this.btn_busc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(809, 298);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ver Factura y Detalles";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(102, 645);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(147, 79);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(304, 645);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(149, 76);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha:";
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(683, 702);
            this.txt_tot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.ReadOnly = true;
            this.txt_tot.Size = new System.Drawing.Size(132, 22);
            this.txt_tot.TabIndex = 43;
            this.txt_tot.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 705);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Total:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(683, 665);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(132, 22);
            this.txt_iva.TabIndex = 41;
            this.txt_iva.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 668);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "IVA:";
            // 
            // txt_subtot
            // 
            this.txt_subtot.Location = new System.Drawing.Point(683, 626);
            this.txt_subtot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_subtot.Name = "txt_subtot";
            this.txt_subtot.ReadOnly = true;
            this.txt_subtot.Size = new System.Drawing.Size(132, 22);
            this.txt_subtot.TabIndex = 39;
            this.txt_subtot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 630);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Subtotal:";
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(292, 241);
            this.txt_vendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.ReadOnly = true;
            this.txt_vendedor.Size = new System.Drawing.Size(219, 22);
            this.txt_vendedor.TabIndex = 44;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(292, 195);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(253, 22);
            this.txt_fecha.TabIndex = 45;
            // 
            // Verfacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 774);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_vendedor);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_subtot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idfact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_busc);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Verfacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verfacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_idfact;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_busc;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_limpiar;
		private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_tot;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_iva;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_subtot;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_vendedor;
		private System.Windows.Forms.TextBox txt_fecha;
	}
}