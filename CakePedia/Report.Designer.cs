
namespace CakePedia
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Cakepedia_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAKEPEDIA_DBDataSet = new CakePedia.CAKEPEDIA_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Cakepedia_TableTableAdapter = new CakePedia.CAKEPEDIA_DBDataSetTableAdapters.Cakepedia_TableTableAdapter();
            this.Bupdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cakepedia_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAKEPEDIA_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // Cakepedia_TableBindingSource
            // 
            this.Cakepedia_TableBindingSource.DataMember = "Cakepedia_Table";
            this.Cakepedia_TableBindingSource.DataSource = this.CAKEPEDIA_DBDataSet;
            // 
            // CAKEPEDIA_DBDataSet
            // 
            this.CAKEPEDIA_DBDataSet.DataSetName = "CAKEPEDIA_DBDataSet";
            this.CAKEPEDIA_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportViewer1.BackgroundImage")));
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Cakepedia_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakePedia.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 187);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(892, 456);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // Cakepedia_TableTableAdapter
            // 
            this.Cakepedia_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Bupdate
            // 
            this.Bupdate.BackColor = System.Drawing.Color.Transparent;
            this.Bupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bupdate.Image = ((System.Drawing.Image)(resources.GetObject("Bupdate.Image")));
            this.Bupdate.Location = new System.Drawing.Point(905, 137);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(101, 45);
            this.Bupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bupdate.TabIndex = 25;
            this.Bupdate.TabStop = false;
            this.Bupdate.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 765);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cakepedia_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAKEPEDIA_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bupdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Cakepedia_TableBindingSource;
        private CAKEPEDIA_DBDataSet CAKEPEDIA_DBDataSet;
        private CAKEPEDIA_DBDataSetTableAdapters.Cakepedia_TableTableAdapter Cakepedia_TableTableAdapter;
        private System.Windows.Forms.PictureBox Bupdate;
    }
}