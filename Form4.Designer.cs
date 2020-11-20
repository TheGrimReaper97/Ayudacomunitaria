namespace Proyecto_Ayuda_Comunitaria
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnUP2 = new System.Windows.Forms.NumericUpDown();
            this.btnregistrarpr = new System.Windows.Forms.Button();
            this.btnsalirpr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtnUP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Producto";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(142, 49);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(100, 20);
            this.txtnombreproducto.TabIndex = 2;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(142, 107);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 20);
            this.txtidproducto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtnUP2
            // 
            this.txtnUP2.Location = new System.Drawing.Point(142, 171);
            this.txtnUP2.Name = "txtnUP2";
            this.txtnUP2.Size = new System.Drawing.Size(100, 20);
            this.txtnUP2.TabIndex = 5;
            // 
            // btnregistrarpr
            // 
            this.btnregistrarpr.Location = new System.Drawing.Point(34, 236);
            this.btnregistrarpr.Name = "btnregistrarpr";
            this.btnregistrarpr.Size = new System.Drawing.Size(75, 23);
            this.btnregistrarpr.TabIndex = 6;
            this.btnregistrarpr.Text = "Registrar";
            this.btnregistrarpr.UseVisualStyleBackColor = true;
            this.btnregistrarpr.Click += new System.EventHandler(this.btnregistrarpr_Click);
            // 
            // btnsalirpr
            // 
            this.btnsalirpr.Location = new System.Drawing.Point(167, 236);
            this.btnsalirpr.Name = "btnsalirpr";
            this.btnsalirpr.Size = new System.Drawing.Size(75, 23);
            this.btnsalirpr.TabIndex = 7;
            this.btnsalirpr.Text = "SALIR";
            this.btnsalirpr.UseVisualStyleBackColor = true;
            this.btnsalirpr.Click += new System.EventHandler(this.btnsalirpr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(301, 190);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 308);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsalirpr);
            this.Controls.Add(this.btnregistrarpr);
            this.Controls.Add(this.txtnUP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnUP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtnUP2;
        private System.Windows.Forms.Button btnregistrarpr;
        private System.Windows.Forms.Button btnsalirpr;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}