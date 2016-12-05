namespace View
{
    partial class SearchDiscountForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discPriceCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.ListView();
            this.discountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountedPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.certificateCheckBox = new System.Windows.Forms.CheckBox();
            this.percentCheckBox = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.discPriceCheckBox);
            this.groupBox1.Controls.Add(this.priceCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по полям:";
            // 
            // discPriceCheckBox
            // 
            this.discPriceCheckBox.AutoSize = true;
            this.discPriceCheckBox.Enabled = false;
            this.discPriceCheckBox.Location = new System.Drawing.Point(126, 19);
            this.discPriceCheckBox.Name = "discPriceCheckBox";
            this.discPriceCheckBox.Size = new System.Drawing.Size(110, 17);
            this.discPriceCheckBox.TabIndex = 4;
            this.discPriceCheckBox.Text = "цена со скидкой";
            this.discPriceCheckBox.UseVisualStyleBackColor = true;
            this.discPriceCheckBox.CheckedChanged += new System.EventHandler(this.discPriceCheckBox_CheckedChanged);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Enabled = false;
            this.priceCheckBox.Location = new System.Drawing.Point(10, 19);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(110, 17);
            this.priceCheckBox.TabIndex = 3;
            this.priceCheckBox.Text = "цена без скидки";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.priceCheckBox_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(212, 31);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Сумма:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(262, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(60, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(262, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultListView
            // 
            this.resultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.discountType,
            this.price,
            this.discountedPrice});
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(12, 136);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(310, 113);
            this.resultListView.TabIndex = 19;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // discountType
            // 
            this.discountType.Text = "Тип скидки";
            this.discountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discountType.Width = 75;
            // 
            // price
            // 
            this.price.Text = "Цена товара";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 105;
            // 
            // discountedPrice
            // 
            this.discountedPrice.Text = "Цена со скидкой";
            this.discountedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountedPrice.Width = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.certificateCheckBox);
            this.groupBox2.Controls.Add(this.percentCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип скидки:";
            // 
            // certificateCheckBox
            // 
            this.certificateCheckBox.AutoSize = true;
            this.certificateCheckBox.Location = new System.Drawing.Point(101, 19);
            this.certificateCheckBox.Name = "certificateCheckBox";
            this.certificateCheckBox.Size = new System.Drawing.Size(86, 17);
            this.certificateCheckBox.TabIndex = 1;
            this.certificateCheckBox.Text = "сертификат";
            this.certificateCheckBox.UseVisualStyleBackColor = true;
            this.certificateCheckBox.CheckedChanged += new System.EventHandler(this.certificateCheckBox_CheckedChanged);
            // 
            // percentCheckBox
            // 
            this.percentCheckBox.AutoSize = true;
            this.percentCheckBox.Location = new System.Drawing.Point(10, 19);
            this.percentCheckBox.Name = "percentCheckBox";
            this.percentCheckBox.Size = new System.Drawing.Size(85, 17);
            this.percentCheckBox.TabIndex = 0;
            this.percentCheckBox.Text = "процентная";
            this.percentCheckBox.UseVisualStyleBackColor = true;
            this.percentCheckBox.CheckedChanged += new System.EventHandler(this.percentCheckBox_CheckedChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(109, 13);
            this.resultLabel.TabIndex = 20;
            this.resultLabel.Text = "Результаты поиска:";
            // 
            // SearchDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск скидки";
            this.Shown += new System.EventHandler(this.SearchDiscountForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox discPriceCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader discountType;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader discountedPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox certificateCheckBox;
        private System.Windows.Forms.CheckBox percentCheckBox;
        private System.Windows.Forms.Label resultLabel;
    }
}