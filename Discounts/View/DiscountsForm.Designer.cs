namespace View
{
    partial class DiscountsForm
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
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.discountsListView = new System.Windows.Forms.ListView();
            this.discountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountedPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.createRandomDataButton = new System.Windows.Forms.Button();
            this.searchDiscountButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addDiscountButton.Location = new System.Drawing.Point(22, 220);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(110, 23);
            this.addDiscountButton.TabIndex = 20;
            this.addDiscountButton.Text = "Добавить скидку";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.addDiscountButton_Click);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeDiscountButton.Enabled = false;
            this.removeDiscountButton.Location = new System.Drawing.Point(194, 220);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(110, 23);
            this.removeDiscountButton.TabIndex = 19;
            this.removeDiscountButton.Text = "Удалить скидку";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.removeDiscountButton_Click);
            // 
            // discountsListView
            // 
            this.discountsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.discountType,
            this.price,
            this.discountedPrice});
            this.discountsListView.FullRowSelect = true;
            this.discountsListView.GridLines = true;
            this.discountsListView.Location = new System.Drawing.Point(10, 12);
            this.discountsListView.Name = "discountsListView";
            this.discountsListView.Size = new System.Drawing.Size(307, 198);
            this.discountsListView.TabIndex = 18;
            this.discountsListView.UseCompatibleStateImageBehavior = false;
            this.discountsListView.View = System.Windows.Forms.View.Details;
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
            // saveToFileButton
            // 
            this.saveToFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveToFileButton.Enabled = false;
            this.saveToFileButton.Location = new System.Drawing.Point(39, 249);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(120, 23);
            this.saveToFileButton.TabIndex = 24;
            this.saveToFileButton.Text = "Сохранить в файл";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadFromFileButton.Location = new System.Drawing.Point(165, 249);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(120, 23);
            this.loadFromFileButton.TabIndex = 23;
            this.loadFromFileButton.Text = "Загрузить из файла";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // createRandomDataButton
            // 
            this.createRandomDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createRandomDataButton.Location = new System.Drawing.Point(124, 278);
            this.createRandomDataButton.Name = "createRandomDataButton";
            this.createRandomDataButton.Size = new System.Drawing.Size(80, 23);
            this.createRandomDataButton.TabIndex = 22;
            this.createRandomDataButton.Text = "Заполнение";
            this.createRandomDataButton.UseVisualStyleBackColor = true;
            this.createRandomDataButton.Click += new System.EventHandler(this.createRandomDataButton_Click);
            // 
            // searchDiscountButton
            // 
            this.searchDiscountButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchDiscountButton.Enabled = false;
            this.searchDiscountButton.Location = new System.Drawing.Point(138, 220);
            this.searchDiscountButton.Name = "searchDiscountButton";
            this.searchDiscountButton.Size = new System.Drawing.Size(50, 23);
            this.searchDiscountButton.TabIndex = 21;
            this.searchDiscountButton.Text = "Поиск";
            this.searchDiscountButton.UseVisualStyleBackColor = true;
            this.searchDiscountButton.Click += new System.EventHandler(this.searchDiscountButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "файл списка скидок (*.dsc)|*.dsc";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "файл списка скидок (*.dsc)|*.dsc";
            // 
            // DiscountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 307);
            this.Controls.Add(this.addDiscountButton);
            this.Controls.Add(this.removeDiscountButton);
            this.Controls.Add(this.discountsListView);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.loadFromFileButton);
            this.Controls.Add(this.createRandomDataButton);
            this.Controls.Add(this.searchDiscountButton);
            this.Name = "DiscountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Скидки";
            this.Load += new System.EventHandler(this.DiscountsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button removeDiscountButton;
        private System.Windows.Forms.ListView discountsListView;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader discountedPrice;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.Button createRandomDataButton;
        private System.Windows.Forms.Button searchDiscountButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColumnHeader discountType;
    }
}