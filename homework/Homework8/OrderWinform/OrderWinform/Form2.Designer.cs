namespace OrderWinform
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConf = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGood = new System.Windows.Forms.ComboBox();
            this.labelGood = new System.Windows.Forms.Label();
            this.bdCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.bdGoods = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTime, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCustomer, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(864, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "下单时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Id", true));
            this.labelId.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelId.Location = new System.Drawing.Point(267, 8);
            this.labelId.Margin = new System.Windows.Forms.Padding(8);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(15, 31);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "3";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(OrderApp.Order);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CreateTime", true));
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Location = new System.Drawing.Point(267, 102);
            this.labelTime.Margin = new System.Windows.Forms.Padding(8);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 34);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "label5";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "Customer", true));
            this.comboBoxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Customer", true));
            this.comboBoxCustomer.DataSource = this.bdCustomers;
            this.comboBoxCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(262, 50);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCustomer.TabIndex = 5;
            this.comboBoxCustomer.Text = "abd";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 233);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(864, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "Details";
            this.orderDetailBindingSource.DataSource = this.bindingSource1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConf);
            this.panel2.Controls.Add(this.buttonDel);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 44);
            this.panel2.TabIndex = 2;
            // 
            // buttonConf
            // 
            this.buttonConf.Location = new System.Drawing.Point(228, 4);
            this.buttonConf.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size(85, 30);
            this.buttonConf.TabIndex = 3;
            this.buttonConf.Text = "确认订单";
            this.buttonConf.UseVisualStyleBackColor = true;
            this.buttonConf.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(117, 5);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 30);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "删除明细";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 5);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "添加明细";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownNum);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBoxGood);
            this.panel3.Controls.Add(this.labelGood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 44);
            this.panel3.TabIndex = 3;
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(338, 4);
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(99, 25);
            this.numericUpDownNum.TabIndex = 3;
            this.numericUpDownNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "数量";
            // 
            // comboBoxGood
            // 
            this.comboBoxGood.DataSource = this.bdGoods;
            this.comboBoxGood.FormattingEnabled = true;
            this.comboBoxGood.Location = new System.Drawing.Point(117, 4);
            this.comboBoxGood.Name = "comboBoxGood";
            this.comboBoxGood.Size = new System.Drawing.Size(85, 23);
            this.comboBoxGood.TabIndex = 1;
            this.comboBoxGood.Text = "苹果";
            // 
            // labelGood
            // 
            this.labelGood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGood.AutoSize = true;
            this.labelGood.Location = new System.Drawing.Point(11, 4);
            this.labelGood.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(37, 15);
            this.labelGood.TabIndex = 0;
            this.labelGood.Text = "商品";
            // 
            // bdCustomers
            // 
            this.bdCustomers.DataMember = "Customers";
            this.bdCustomers.DataSource = typeof(OrderWinform.Form2);
            // 
            // bdGoods
            // 
            this.bdGoods.DataMember = "GoodList";
            this.bdGoods.DataSource = typeof(OrderWinform.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGood;
        private System.Windows.Forms.Label labelGood;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bdCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdGoods;
    }
}