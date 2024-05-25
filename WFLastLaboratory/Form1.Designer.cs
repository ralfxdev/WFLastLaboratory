namespace WFLastLaboratory
{
    partial class Form1
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
            this.myInfoLbl = new System.Windows.Forms.Label();
            this.consoledDataGrid = new System.Windows.Forms.DataGridView();
            this.cargarDataBtn = new System.Windows.Forms.Button();
            this.cargarSonyBtn = new System.Windows.Forms.Button();
            this.nintendoBtn = new System.Windows.Forms.Button();
            this.segaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.lanzamientoNum = new System.Windows.Forms.NumericUpDown();
            this.generacionNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crearBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.companiaBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.consoledDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanzamientoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generacionNum)).BeginInit();
            this.SuspendLayout();
            // 
            // myInfoLbl
            // 
            this.myInfoLbl.AutoSize = true;
            this.myInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myInfoLbl.Location = new System.Drawing.Point(0, 0);
            this.myInfoLbl.Name = "myInfoLbl";
            this.myInfoLbl.Size = new System.Drawing.Size(706, 39);
            this.myInfoLbl.TabIndex = 0;
            this.myInfoLbl.Text = "Randy Alexander López Flores 0905-20-8464";
            // 
            // consoledDataGrid
            // 
            this.consoledDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consoledDataGrid.Location = new System.Drawing.Point(513, 107);
            this.consoledDataGrid.Name = "consoledDataGrid";
            this.consoledDataGrid.RowHeadersWidth = 51;
            this.consoledDataGrid.RowTemplate.Height = 24;
            this.consoledDataGrid.Size = new System.Drawing.Size(550, 312);
            this.consoledDataGrid.TabIndex = 1;
            this.consoledDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consoledDataGrid_CellContentClick);
            // 
            // cargarDataBtn
            // 
            this.cargarDataBtn.Location = new System.Drawing.Point(513, 461);
            this.cargarDataBtn.Name = "cargarDataBtn";
            this.cargarDataBtn.Size = new System.Drawing.Size(75, 23);
            this.cargarDataBtn.TabIndex = 2;
            this.cargarDataBtn.Text = "Cargar";
            this.cargarDataBtn.UseVisualStyleBackColor = true;
            this.cargarDataBtn.Click += new System.EventHandler(this.cargarDataBtn_Click);
            // 
            // cargarSonyBtn
            // 
            this.cargarSonyBtn.Location = new System.Drawing.Point(654, 461);
            this.cargarSonyBtn.Name = "cargarSonyBtn";
            this.cargarSonyBtn.Size = new System.Drawing.Size(75, 23);
            this.cargarSonyBtn.TabIndex = 3;
            this.cargarSonyBtn.Text = "Sony";
            this.cargarSonyBtn.UseVisualStyleBackColor = true;
            this.cargarSonyBtn.Click += new System.EventHandler(this.cargarSonyBtn_Click);
            // 
            // nintendoBtn
            // 
            this.nintendoBtn.Location = new System.Drawing.Point(798, 461);
            this.nintendoBtn.Name = "nintendoBtn";
            this.nintendoBtn.Size = new System.Drawing.Size(113, 23);
            this.nintendoBtn.TabIndex = 4;
            this.nintendoBtn.Text = "Nintendo";
            this.nintendoBtn.UseVisualStyleBackColor = true;
            this.nintendoBtn.Click += new System.EventHandler(this.nintendoBtn_Click);
            // 
            // segaBtn
            // 
            this.segaBtn.Location = new System.Drawing.Point(988, 461);
            this.segaBtn.Name = "segaBtn";
            this.segaBtn.Size = new System.Drawing.Size(75, 23);
            this.segaBtn.TabIndex = 5;
            this.segaBtn.Text = "Sega";
            this.segaBtn.UseVisualStyleBackColor = true;
            this.segaBtn.Click += new System.EventHandler(this.segaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(180, 153);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(219, 22);
            this.nombreText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compañía";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(180, 108);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(92, 22);
            this.idText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(324, 109);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 12;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // lanzamientoNum
            // 
            this.lanzamientoNum.Location = new System.Drawing.Point(180, 248);
            this.lanzamientoNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lanzamientoNum.Name = "lanzamientoNum";
            this.lanzamientoNum.Size = new System.Drawing.Size(120, 22);
            this.lanzamientoNum.TabIndex = 13;
            // 
            // generacionNum
            // 
            this.generacionNum.Location = new System.Drawing.Point(180, 296);
            this.generacionNum.Name = "generacionNum";
            this.generacionNum.Size = new System.Drawing.Size(120, 22);
            this.generacionNum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Generación";
            // 
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(73, 363);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(75, 23);
            this.crearBtn.TabIndex = 17;
            this.crearBtn.Text = "Crear";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Location = new System.Drawing.Point(180, 363);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(103, 23);
            this.actualizarBtn.TabIndex = 17;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(324, 363);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 18;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // companiaBox
            // 
            this.companiaBox.FormattingEnabled = true;
            this.companiaBox.Location = new System.Drawing.Point(180, 203);
            this.companiaBox.Name = "companiaBox";
            this.companiaBox.Size = new System.Drawing.Size(219, 24);
            this.companiaBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.companiaBox);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generacionNum);
            this.Controls.Add(this.lanzamientoNum);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.segaBtn);
            this.Controls.Add(this.nintendoBtn);
            this.Controls.Add(this.cargarSonyBtn);
            this.Controls.Add(this.cargarDataBtn);
            this.Controls.Add(this.consoledDataGrid);
            this.Controls.Add(this.myInfoLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.consoledDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanzamientoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generacionNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myInfoLbl;
        private System.Windows.Forms.DataGridView consoledDataGrid;
        private System.Windows.Forms.Button cargarDataBtn;
        private System.Windows.Forms.Button cargarSonyBtn;
        private System.Windows.Forms.Button nintendoBtn;
        private System.Windows.Forms.Button segaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.NumericUpDown lanzamientoNum;
        private System.Windows.Forms.NumericUpDown generacionNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.ComboBox companiaBox;
    }
}

