namespace View
{
    partial class AddDiscountForm
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
            this.discountTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.sertificateRadioButton = new System.Windows.Forms.RadioButton();
            this.percentRadioButton = new System.Windows.Forms.RadioButton();
            this.percentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.certificateTextBox = new System.Windows.Forms.TextBox();
            this.discountTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // discountTypeGroupBox
            // 
            this.discountTypeGroupBox.Controls.Add(this.sertificateRadioButton);
            this.discountTypeGroupBox.Controls.Add(this.percentRadioButton);
            this.discountTypeGroupBox.Location = new System.Drawing.Point(14, 40);
            this.discountTypeGroupBox.Name = "discountTypeGroupBox";
            this.discountTypeGroupBox.Size = new System.Drawing.Size(215, 45);
            this.discountTypeGroupBox.TabIndex = 0;
            this.discountTypeGroupBox.TabStop = false;
            this.discountTypeGroupBox.Text = "Тип скидки";
            // 
            // sertificateRadioButton
            // 
            this.sertificateRadioButton.AutoSize = true;
            this.sertificateRadioButton.Location = new System.Drawing.Point(99, 19);
            this.sertificateRadioButton.Name = "sertificateRadioButton";
            this.sertificateRadioButton.Size = new System.Drawing.Size(105, 17);
            this.sertificateRadioButton.TabIndex = 2;
            this.sertificateRadioButton.Text = "по сертификату";
            this.sertificateRadioButton.UseVisualStyleBackColor = true;
            this.sertificateRadioButton.CheckedChanged += new System.EventHandler(this.sertificateRadioButton_CheckedChanged);
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Checked = true;
            this.percentRadioButton.Location = new System.Drawing.Point(9, 19);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(84, 17);
            this.percentRadioButton.TabIndex = 1;
            this.percentRadioButton.TabStop = true;
            this.percentRadioButton.Text = "процентная";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            this.percentRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // percentNumericUpDown
            // 
            this.percentNumericUpDown.Location = new System.Drawing.Point(191, 95);
            this.percentNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentNumericUpDown.Name = "percentNumericUpDown";
            this.percentNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.percentNumericUpDown.TabIndex = 1;
            this.percentNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(20, 97);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(158, 13);
            this.discountLabel.TabIndex = 2;
            this.discountLabel.Text = "Размер скидки (в процентах):";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(46, 125);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "ОК";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(131, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(20, 15);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(126, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Цена товара (в рублях):";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(153, 13);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(75, 20);
            this.priceTextBox.TabIndex = 0;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // certificateTextBox
            // 
            this.certificateTextBox.Location = new System.Drawing.Point(184, 94);
            this.certificateTextBox.Name = "certificateTextBox";
            this.certificateTextBox.Size = new System.Drawing.Size(45, 20);
            this.certificateTextBox.TabIndex = 5;
            this.certificateTextBox.Visible = false;
            this.certificateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.certificateTextBox_KeyPress);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 157);
            this.Controls.Add(this.certificateTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.percentNumericUpDown);
            this.Controls.Add(this.discountTypeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление скидки";
            this.Shown += new System.EventHandler(this.AddDiscountForm_Shown);
            this.discountTypeGroupBox.ResumeLayout(false);
            this.discountTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox discountTypeGroupBox;
        private System.Windows.Forms.RadioButton sertificateRadioButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private System.Windows.Forms.NumericUpDown percentNumericUpDown;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox certificateTextBox;
    }
}