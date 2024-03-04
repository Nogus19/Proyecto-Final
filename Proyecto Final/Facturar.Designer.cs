namespace Proyecto_Final
{
	partial class Facturar
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
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_subtot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combopro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboven = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(503, 741);
            this.txt_tot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.ReadOnly = true;
            this.txt_tot.Size = new System.Drawing.Size(132, 22);
            this.txt_tot.TabIndex = 37;
            this.txt_tot.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 747);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Total:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(503, 704);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(132, 22);
            this.txt_iva.TabIndex = 35;
            this.txt_iva.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 708);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "IVA:";
            // 
            // txt_subtot
            // 
            this.txt_subtot.Location = new System.Drawing.Point(503, 666);
            this.txt_subtot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_subtot.Name = "txt_subtot";
            this.txt_subtot.ReadOnly = true;
            this.txt_subtot.Size = new System.Drawing.Size(132, 22);
            this.txt_subtot.TabIndex = 33;
            this.txt_subtot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 672);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Subtotal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(86, 371);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(596, 267);
            this.dataGridView1.TabIndex = 31;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(328, 300);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(115, 46);
            this.btn_agregar.TabIndex = 30;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(572, 225);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(132, 22);
            this.txt_cant.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cantidad:";
            // 
            // txt_prec
            // 
            this.txt_prec.Location = new System.Drawing.Point(328, 243);
            this.txt_prec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prec.Name = "txt_prec";
            this.txt_prec.ReadOnly = true;
            this.txt_prec.Size = new System.Drawing.Size(132, 22);
            this.txt_prec.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio:";
            // 
            // combopro
            // 
            this.combopro.FormattingEnabled = true;
            this.combopro.Location = new System.Drawing.Point(27, 225);
            this.combopro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combopro.Name = "combopro";
            this.combopro.Size = new System.Drawing.Size(225, 24);
            this.combopro.TabIndex = 25;
            this.combopro.SelectedIndexChanged += new System.EventHandler(this.combopro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Producto:";
            // 
            // comboven
            // 
            this.comboven.FormattingEnabled = true;
            this.comboven.Location = new System.Drawing.Point(478, 112);
            this.comboven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboven.Name = "comboven";
            this.comboven.Size = new System.Drawing.Size(235, 24);
            this.comboven.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Vendedor:";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(101, 112);
            this.dateTimePicker_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_fecha.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Facturar";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(116, 672);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(136, 58);
            this.btn_guardar.TabIndex = 38;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(48, 762);
            this.btn_limp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(100, 41);
            this.btn_limp.TabIndex = 39;
            this.btn_limp.Text = "Limpiar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(220, 762);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 41);
            this.btn_salir.TabIndex = 40;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 816);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_subtot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_prec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combopro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboven);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_tot;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_iva;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_subtot;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.TextBox txt_cant;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_prec;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox combopro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboven;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_guardar;
		private System.Windows.Forms.Button btn_limp;
		private System.Windows.Forms.Button btn_salir;
	}
}