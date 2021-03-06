﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        public AddDiscountForm(DiscountsForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private DiscountsForm mainForm;

        /// <summary>
        /// отображение компонентов для ввода значения процентной скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            discountLabel.Text = "Размер скидки (в процентах):";
            certificateTextBox.Hide();
            percentNumericUpDown.Show();
        }

        /// <summary>
        /// отображение компонентов для ввода значения скидки по сертификату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sertificateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            discountLabel.Text = "Размер скидки (в рублях):";
            certificateTextBox.Show();
            percentNumericUpDown.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// метод добавления скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (mainForm != null) {
                double price = 0, discountSize = 0;
                // проверка корректности введенных значений
                try {
                    price = Convert.ToDouble(priceTextBox.Text);
                } catch (FormatException) {
                    MessageBox.Show("Поле \"Цена товара\" содержит некорректное значение!" );
                    return;
                }
                if (percentRadioButton.Checked)
                    discountSize = Convert.ToDouble(percentNumericUpDown.Value);
                else
                    try
                    {
                        discountSize = Convert.ToDouble(certificateTextBox.Text);
                    } catch (FormatException) {
                        MessageBox.Show("Поле \"Скидка\" содержит некорректное значение!");
                        return;
                }
                // вызов метода добавления элемента в список
                mainForm.createDiscount(percentRadioButton.Checked, price, discountSize);
        }
            this.Close();
        }

        /// <summary>
        /// метод проверки корректности вводимого символа (допустимы цифры, запятая, клавиши BackSpace и Delete)
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        private bool isValidChar(char ch)
        {
            return Char.IsDigit(ch) || ch == 8 || ch == 44;
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isValidChar(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void certificateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isValidChar(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// очистка предыдущих значений при отображении формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountForm_Shown(object sender, EventArgs e)
        {
            percentNumericUpDown.Value = 50;
            certificateTextBox.Clear();
            priceTextBox.Clear();            
        }
    }
}
