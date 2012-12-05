namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetSample = new WindowsFormsApplication1.DataSetSample();
            this.dataTableSampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataColumnSample1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumnSample2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumnSample3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSampleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataColumnSample1DataGridViewTextBoxColumn,
            this.dataColumnSample2DataGridViewTextBoxColumn,
            this.dataColumnSample3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTableSampleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(380, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetSample
            // 
            this.dataSetSample.DataSetName = "DataSetSample";
            this.dataSetSample.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableSampleBindingSource
            // 
            this.dataTableSampleBindingSource.DataMember = "DataTableSample";
            this.dataTableSampleBindingSource.DataSource = this.dataSetSample;
            // 
            // dataColumnSample1DataGridViewTextBoxColumn
            // 
            this.dataColumnSample1DataGridViewTextBoxColumn.DataPropertyName = "DataColumnSample1";
            this.dataColumnSample1DataGridViewTextBoxColumn.HeaderText = "DataColumnSample1";
            this.dataColumnSample1DataGridViewTextBoxColumn.Name = "dataColumnSample1DataGridViewTextBoxColumn";
            // 
            // dataColumnSample2DataGridViewTextBoxColumn
            // 
            this.dataColumnSample2DataGridViewTextBoxColumn.DataPropertyName = "DataColumnSample2";
            this.dataColumnSample2DataGridViewTextBoxColumn.HeaderText = "DataColumnSample2";
            this.dataColumnSample2DataGridViewTextBoxColumn.Name = "dataColumnSample2DataGridViewTextBoxColumn";
            // 
            // dataColumnSample3DataGridViewTextBoxColumn
            // 
            this.dataColumnSample3DataGridViewTextBoxColumn.DataPropertyName = "DataColumnSample3";
            this.dataColumnSample3DataGridViewTextBoxColumn.HeaderText = "DataColumnSample3";
            this.dataColumnSample3DataGridViewTextBoxColumn.Name = "dataColumnSample3DataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSampleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumnSample1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumnSample2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataColumnSample3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableSampleBindingSource;
        private DataSetSample dataSetSample;
        private System.Windows.Forms.Button button1;
    }
}

