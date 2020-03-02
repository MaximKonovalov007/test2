namespace jkh
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_house = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.city_box = new System.Windows.Forms.ComboBox();
            this.tolc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jk_id,
            this.name,
            this.status,
            this.count_house,
            this.city});
            this.dataGridView1.Location = new System.Drawing.Point(109, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jk_id
            // 
            this.jk_id.HeaderText = "id ЖК";
            this.jk_id.Name = "jk_id";
            // 
            // name
            // 
            this.name.HeaderText = "название ЖК";
            this.name.Name = "name";
            // 
            // status
            // 
            this.status.HeaderText = "статуса";
            this.status.Name = "status";
            // 
            // count_house
            // 
            this.count_house.HeaderText = "Kоличество домов в ЖК";
            this.count_house.Name = "count_house";
            // 
            // city
            // 
            this.city.HeaderText = "города";
            this.city.Name = "city";
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(322, 423);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(134, 23);
            this.filter.TabIndex = 1;
            this.filter.Text = "Фильтр по городу";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите город";
            // 
            // city_box
            // 
            this.city_box.FormattingEnabled = true;
            this.city_box.Location = new System.Drawing.Point(195, 423);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(121, 21);
            this.city_box.TabIndex = 4;
            // 
            // tolc
            // 
            this.tolc.Location = new System.Drawing.Point(462, 423);
            this.tolc.Name = "tolc";
            this.tolc.Size = new System.Drawing.Size(133, 23);
            this.tolc.TabIndex = 5;
            this.tolc.Text = "Перейти к ЖК";
            this.tolc.UseVisualStyleBackColor = true;
            this.tolc.Click += new System.EventHandler(this.tolc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Список домов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tolc);
            this.Controls.Add(this.city_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(800, 521);
            this.MinimumSize = new System.Drawing.Size(800, 521);
            this.Name = "Form1";
            this.Text = "Жилые комплексы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_house;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox city_box;
        private System.Windows.Forms.Button tolc;
        private System.Windows.Forms.Button button1;
    }
}

