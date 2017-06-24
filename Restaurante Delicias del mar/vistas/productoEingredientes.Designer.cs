namespace Restaurante_Delicias_del_mar.vistas
{
    partial class productoEingredientes
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.lblProdut = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwProducto = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwIngredientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(963, 523);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 59);
            this.button4.TabIndex = 34;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Agregue los ingredientes que necesita el produto";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(725, 565);
            this.lblm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(200, 17);
            this.lblm.TabIndex = 33;
            this.lblm.Text = "                                                ";
            // 
            // lblProdut
            // 
            this.lblProdut.AutoSize = true;
            this.lblProdut.Location = new System.Drawing.Point(1053, 112);
            this.lblProdut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdut.Name = "lblProdut";
            this.lblProdut.Size = new System.Drawing.Size(236, 17);
            this.lblProdut.TabIndex = 31;
            this.lblProdut.Text = ":                                                        ";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(783, 151);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(365, 28);
            this.lblProducto.TabIndex = 30;
            this.lblProducto.Text = "Vista de los ingredientes del producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwProducto);
            this.panel1.Location = new System.Drawing.Point(729, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 332);
            this.panel1.TabIndex = 28;
            // 
            // dgwProducto
            // 
            this.dgwProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducto.Location = new System.Drawing.Point(43, 20);
            this.dgwProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProducto.Name = "dgwProducto";
            this.dgwProducto.Size = new System.Drawing.Size(421, 282);
            this.dgwProducto.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgwIngredientes);
            this.panel3.Location = new System.Drawing.Point(61, 183);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 332);
            this.panel3.TabIndex = 23;
            // 
            // dgwIngredientes
            // 
            this.dgwIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIngredientes.Location = new System.Drawing.Point(33, 20);
            this.dgwIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgwIngredientes.Name = "dgwIngredientes";
            this.dgwIngredientes.Size = new System.Drawing.Size(479, 282);
            this.dgwIngredientes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1111, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 59);
            this.button1.TabIndex = 27;
            this.button1.Text = "Listo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Agregar Ingredientes al Producto";
            // 
            // cbPRODUCTOS
            // 
            this.cbPRODUCTOS.FormattingEnabled = true;
            this.cbPRODUCTOS.Location = new System.Drawing.Point(488, 118);
            this.cbPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbPRODUCTOS.Name = "cbPRODUCTOS";
            this.cbPRODUCTOS.Size = new System.Drawing.Size(160, 24);
            this.cbPRODUCTOS.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccione el producto que necesita ingredientes.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1266, 36);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarProductoToolStripMenuItem
            // 
            this.administrarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.detalleProductosToolStripMenuItem});
            this.administrarProductoToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarProductoToolStripMenuItem.Name = "administrarProductoToolStripMenuItem";
            this.administrarProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.administrarProductoToolStripMenuItem.Text = "Administrar Producto";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // detalleProductosToolStripMenuItem
            // 
            this.detalleProductosToolStripMenuItem.Name = "detalleProductosToolStripMenuItem";
            this.detalleProductosToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.detalleProductosToolStripMenuItem.Text = "DetalleProductos";
            // 
            // productoEingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 628);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblProdut);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPRODUCTOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "productoEingredientes";
            this.Text = "productoEingredientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lblProdut;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwIngredientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPRODUCTOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleProductosToolStripMenuItem;
    }
}