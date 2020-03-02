namespace jkh
{
    partial class house_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.street_filter_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lc_filter_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.house_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_house = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_selling_ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_house_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.house_id,
            this.jk_id,
            this.name,
            this.home_number,
            this.status,
            this.count_house,
            this.count_selling_ap});
            this.dataGridView1.Location = new System.Drawing.Point(128, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // street_filter_button
            // 
            this.street_filter_button.Location = new System.Drawing.Point(300, 439);
            this.street_filter_button.Name = "street_filter_button";
            this.street_filter_button.Size = new System.Drawing.Size(141, 23);
            this.street_filter_button.TabIndex = 2;
            this.street_filter_button.Text = "Фильтр по улице";
            this.street_filter_button.UseVisualStyleBackColor = true;
            this.street_filter_button.Click += new System.EventHandler(this.street_filter_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 439);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 477);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lc_filter_button
            // 
            this.lc_filter_button.Location = new System.Drawing.Point(300, 477);
            this.lc_filter_button.Name = "lc_filter_button";
            this.lc_filter_button.Size = new System.Drawing.Size(141, 23);
            this.lc_filter_button.TabIndex = 5;
            this.lc_filter_button.Text = "Фильтр по ЖК";
            this.lc_filter_button.UseVisualStyleBackColor = true;
            this.lc_filter_button.Click += new System.EventHandler(this.lc_filter_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить дом из базы данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // house_id
            // 
            this.house_id.HeaderText = "id";
            this.house_id.Name = "house_id";
            this.house_id.ReadOnly = true;
            // 
            // jk_id
            // 
            this.jk_id.HeaderText = "ЖК";
            this.jk_id.Name = "jk_id";
            // 
            // name
            // 
            this.name.HeaderText = "улица";
            this.name.Name = "name";
            // 
            // home_number
            // 
            this.home_number.HeaderText = "Номер дома";
            this.home_number.Name = "home_number";
            // 
            // status
            // 
            this.status.HeaderText = "статуса";
            this.status.Name = "status";
            // 
            // count_house
            // 
            this.count_house.HeaderText = "Kоличество проданных квартир";
            this.count_house.Name = "count_house";
            // 
            // count_selling_ap
            // 
            this.count_selling_ap.HeaderText = "Количество продающися квартир";
            this.count_selling_ap.Name = "count_selling_ap";
            // 
            // add_house_button
            // 
            this.add_house_button.Location = new System.Drawing.Point(796, 435);
            this.add_house_button.Name = "add_house_button";
            this.add_house_button.Size = new System.Drawing.Size(129, 62);
            this.add_house_button.TabIndex = 8;
            this.add_house_button.Text = "Добавить дом";
            this.add_house_button.UseVisualStyleBackColor = true;
            this.add_house_button.Click += new System.EventHandler(this.add_house_button_Click);
            // 
            // house_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 537);
            this.Controls.Add(this.add_house_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lc_filter_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.street_filter_button);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1047, 576);
            this.MinimumSize = new System.Drawing.Size(1047, 576);
            this.Name = "house_list";
            this.Text = "house_list";
            this.Load += new System.EventHandler(this.house_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button street_filter_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button lc_filter_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn house_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_house;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_selling_ap;
        private System.Windows.Forms.Button add_house_button;
    }
}