﻿namespace SistemaFletesAcarreoB
{
    partial class VerFctura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.dgv_Factura = new System.Windows.Forms.DataGridView();
            this.boletanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmetrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalviajesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factlicenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factplacasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factKilometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURABindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet();
            this.btn_BuscarFac = new System.Windows.Forms.Button();
            this.dtp_FechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechafactura = new System.Windows.Forms.Label();
            this.fACTURABindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMAFLETESACARREOSDataSet20 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20();
            this.fACTURABindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURATableAdapter5 = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSet20TableAdapters.FACTURATableAdapter();
            this.fACTURATableAdapter = new SistemaFletesAcarreoB.SISTEMAFLETESACARREOSDataSetTableAdapters.FACTURATableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Controls.Add(this.dgv_Factura);
            this.panel1.Controls.Add(this.btn_BuscarFac);
            this.panel1.Controls.Add(this.dtp_FechaFactura);
            this.panel1.Controls.Add(this.lbl_fechafactura);
            this.panel1.Location = new System.Drawing.Point(45, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 501);
            this.panel1.TabIndex = 0;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(18, 459);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 26);
            this.btn_Imprimir.TabIndex = 10;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // dgv_Factura
            // 
            this.dgv_Factura.AllowUserToAddRows = false;
            this.dgv_Factura.AutoGenerateColumns = false;
            this.dgv_Factura.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boletanoDataGridViewTextBoxColumn,
            this.numFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.materialesDataGridViewTextBoxColumn,
            this.totalmetrosDataGridViewTextBoxColumn,
            this.totalviajesDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.factmaterialDataGridViewTextBoxColumn,
            this.factlicenciaDataGridViewTextBoxColumn,
            this.factplacasDataGridViewTextBoxColumn,
            this.factKilometroDataGridViewTextBoxColumn});
            this.dgv_Factura.DataSource = this.fACTURABindingSource7;
            this.dgv_Factura.Location = new System.Drawing.Point(18, 89);
            this.dgv_Factura.Name = "dgv_Factura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Factura.Size = new System.Drawing.Size(930, 341);
            this.dgv_Factura.TabIndex = 9;
            this.dgv_Factura.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Factura_CellMouseClick);
            // 
            // boletanoDataGridViewTextBoxColumn
            // 
            this.boletanoDataGridViewTextBoxColumn.DataPropertyName = "Boleta_no";
            this.boletanoDataGridViewTextBoxColumn.HeaderText = "Boleta_no";
            this.boletanoDataGridViewTextBoxColumn.Name = "boletanoDataGridViewTextBoxColumn";
            this.boletanoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numFacturaDataGridViewTextBoxColumn
            // 
            this.numFacturaDataGridViewTextBoxColumn.DataPropertyName = "Num_Factura";
            this.numFacturaDataGridViewTextBoxColumn.HeaderText = "Num_Factura";
            this.numFacturaDataGridViewTextBoxColumn.Name = "numFacturaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // materialesDataGridViewTextBoxColumn
            // 
            this.materialesDataGridViewTextBoxColumn.DataPropertyName = "Materiales";
            this.materialesDataGridViewTextBoxColumn.HeaderText = "Materiales";
            this.materialesDataGridViewTextBoxColumn.Name = "materialesDataGridViewTextBoxColumn";
            // 
            // totalmetrosDataGridViewTextBoxColumn
            // 
            this.totalmetrosDataGridViewTextBoxColumn.DataPropertyName = "Total_metros";
            this.totalmetrosDataGridViewTextBoxColumn.HeaderText = "Total_metros";
            this.totalmetrosDataGridViewTextBoxColumn.Name = "totalmetrosDataGridViewTextBoxColumn";
            // 
            // totalviajesDataGridViewTextBoxColumn
            // 
            this.totalviajesDataGridViewTextBoxColumn.DataPropertyName = "Total_viajes";
            this.totalviajesDataGridViewTextBoxColumn.HeaderText = "Total_viajes";
            this.totalviajesDataGridViewTextBoxColumn.Name = "totalviajesDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // factmaterialDataGridViewTextBoxColumn
            // 
            this.factmaterialDataGridViewTextBoxColumn.DataPropertyName = "Fact_material";
            this.factmaterialDataGridViewTextBoxColumn.HeaderText = "Fact_material";
            this.factmaterialDataGridViewTextBoxColumn.Name = "factmaterialDataGridViewTextBoxColumn";
            // 
            // factlicenciaDataGridViewTextBoxColumn
            // 
            this.factlicenciaDataGridViewTextBoxColumn.DataPropertyName = "Fact_licencia";
            this.factlicenciaDataGridViewTextBoxColumn.HeaderText = "Fact_licencia";
            this.factlicenciaDataGridViewTextBoxColumn.Name = "factlicenciaDataGridViewTextBoxColumn";
            // 
            // factplacasDataGridViewTextBoxColumn
            // 
            this.factplacasDataGridViewTextBoxColumn.DataPropertyName = "Fact_placas";
            this.factplacasDataGridViewTextBoxColumn.HeaderText = "Fact_placas";
            this.factplacasDataGridViewTextBoxColumn.Name = "factplacasDataGridViewTextBoxColumn";
            // 
            // factKilometroDataGridViewTextBoxColumn
            // 
            this.factKilometroDataGridViewTextBoxColumn.DataPropertyName = "Fact_Kilometro";
            this.factKilometroDataGridViewTextBoxColumn.HeaderText = "Fact_Kilometro";
            this.factKilometroDataGridViewTextBoxColumn.Name = "factKilometroDataGridViewTextBoxColumn";
            // 
            // fACTURABindingSource7
            // 
            this.fACTURABindingSource7.DataMember = "FACTURA";
            this.fACTURABindingSource7.DataSource = this.sISTEMAFLETESACARREOSDataSet;
            // 
            // sISTEMAFLETESACARREOSDataSet
            // 
            this.sISTEMAFLETESACARREOSDataSet.DataSetName = "SISTEMAFLETESACARREOSDataSet";
            this.sISTEMAFLETESACARREOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_BuscarFac
            // 
            this.btn_BuscarFac.BackColor = System.Drawing.Color.DarkRed;
            this.btn_BuscarFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_BuscarFac.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarFac.Location = new System.Drawing.Point(664, 53);
            this.btn_BuscarFac.Name = "btn_BuscarFac";
            this.btn_BuscarFac.Size = new System.Drawing.Size(75, 26);
            this.btn_BuscarFac.TabIndex = 2;
            this.btn_BuscarFac.Text = "Buscar";
            this.btn_BuscarFac.UseVisualStyleBackColor = false;
            this.btn_BuscarFac.Click += new System.EventHandler(this.btn_BuscarFac_Click);
            // 
            // dtp_FechaFactura
            // 
            this.dtp_FechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_FechaFactura.Location = new System.Drawing.Point(329, 53);
            this.dtp_FechaFactura.Name = "dtp_FechaFactura";
            this.dtp_FechaFactura.Size = new System.Drawing.Size(317, 26);
            this.dtp_FechaFactura.TabIndex = 1;
            // 
            // lbl_fechafactura
            // 
            this.lbl_fechafactura.AutoSize = true;
            this.lbl_fechafactura.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechafactura.ForeColor = System.Drawing.Color.White;
            this.lbl_fechafactura.Location = new System.Drawing.Point(335, 22);
            this.lbl_fechafactura.Name = "lbl_fechafactura";
            this.lbl_fechafactura.Size = new System.Drawing.Size(311, 28);
            this.lbl_fechafactura.TabIndex = 0;
            this.lbl_fechafactura.Text = "Introduzca fecha de factura:";
            // 
            // fACTURABindingSource6
            // 
            this.fACTURABindingSource6.DataMember = "FACTURA";
            this.fACTURABindingSource6.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // sISTEMAFLETESACARREOSDataSet20
            // 
            this.sISTEMAFLETESACARREOSDataSet20.DataSetName = "SISTEMAFLETESACARREOSDataSet20";
            this.sISTEMAFLETESACARREOSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURABindingSource5
            // 
            this.fACTURABindingSource5.DataMember = "FACTURA";
            this.fACTURABindingSource5.DataSource = this.sISTEMAFLETESACARREOSDataSet20;
            // 
            // fACTURABindingSource4
            // 
            this.fACTURABindingSource4.DataMember = "FACTURA";
            // 
            // fACTURABindingSource3
            // 
            this.fACTURABindingSource3.DataMember = "FACTURA";
            // 
            // fACTURABindingSource1
            // 
            this.fACTURABindingSource1.DataMember = "FACTURA";
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            // 
            // fACTURABindingSource2
            // 
            this.fACTURABindingSource2.DataMember = "FACTURA";
            // 
            // fACTURATableAdapter5
            // 
            this.fACTURATableAdapter5.ClearBeforeFill = true;
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // VerFctura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerFctura";
            this.Text = "VerFctura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VerFctura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMAFLETESACARREOSDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BuscarFac;
        private System.Windows.Forms.DateTimePicker dtp_FechaFactura;
        private System.Windows.Forms.Label lbl_fechafactura;
        private System.Windows.Forms.DataGridView dgv_Factura;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private System.Windows.Forms.BindingSource fACTURABindingSource1;
        private System.Windows.Forms.BindingSource fACTURABindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmetrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalviajesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factlicenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factplacasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factKilometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fACTURABindingSource3;
        private System.Windows.Forms.BindingSource fACTURABindingSource4;
        private SISTEMAFLETESACARREOSDataSet20 sISTEMAFLETESACARREOSDataSet20;
        private System.Windows.Forms.BindingSource fACTURABindingSource5;
        private SISTEMAFLETESACARREOSDataSet20TableAdapters.FACTURATableAdapter fACTURATableAdapter5;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.BindingSource fACTURABindingSource6;
        private SISTEMAFLETESACARREOSDataSet sISTEMAFLETESACARREOSDataSet;
        private System.Windows.Forms.BindingSource fACTURABindingSource7;
        private SISTEMAFLETESACARREOSDataSetTableAdapters.FACTURATableAdapter fACTURATableAdapter;
    }
}