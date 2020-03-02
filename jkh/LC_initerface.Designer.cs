namespace jkh
{
    partial class LC_initerface
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
            this.lc_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostsonBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_label
            // 
            this.lc_label.AutoSize = true;
            this.lc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lc_label.Location = new System.Drawing.Point(370, 43);
            this.lc_label.Name = "lc_label";
            this.lc_label.Size = new System.Drawing.Size(57, 20);
            this.lc_label.TabIndex = 0;
            this.lc_label.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.AddedCost,
            this.status,
            this.CostsonBuilding,
            this.city});
            this.dataGridView1.Location = new System.Drawing.Point(61, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "название ЖК";
            this.name.Name = "name";
            // 
            // AddedCost
            // 
            this.AddedCost.HeaderText = "коэффициент добавочной стоимости на строительство жилищного комплекса";
            this.AddedCost.Name = "AddedCost";
            // 
            // status
            // 
            this.status.HeaderText = "статуса";
            this.status.Name = "status";
            // 
            // CostsonBuilding
            // 
            this.CostsonBuilding.HeaderText = "Затраты на строительство ЖК";
            this.CostsonBuilding.Name = "CostsonBuilding";
            // 
            // city
            // 
            this.city.HeaderText = "города";
            this.city.Name = "city";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LC_initerface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lc_label);
            this.Name = "LC_initerface";
            this.Text = "LC_initerface";
            this.Load += new System.EventHandler(this.LC_initerface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lc_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostsonBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.Button button1;
    }
}