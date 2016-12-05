using System;
using System.Windows.Forms;

namespace View
{
    public partial class SearchDiscountForm : Form
    {
        public SearchDiscountForm()
        {
            InitializeComponent();
        }

        public SearchDiscountForm(DiscountsForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private DiscountsForm mainForm;

        // метод проверки корректности критериев поиска
        private void checkInputValues()
        {
            searchButton.Enabled = percentCheckBox.Checked || certificateCheckBox.Checked;
            if(searchTextBox.Text.Length > 0)
                searchButton.Enabled = priceCheckBox.Checked || discPriceCheckBox.Checked;
        }

        // метод проверки корректности вводимого символа
        // (допустимы цифры, запятая, клавиши BackSpace и Delete)
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        // метод поиска по указанным критериям
        public void searchButton_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                double price = 0;
                // проверка корректности суммы
                if(searchTextBox.Text.Length > 0)
                try
                {
                    price = Convert.ToDouble(searchTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Поле \"Сумма\" содержит некорректное значение!");
                    return;
                }
                resultListView.Items.Clear();
                //вызов метода поиска среди элементов списка
                resultListView.Items.AddRange(mainForm.searchDiscounts(percentCheckBox.Checked, certificateCheckBox.Checked, 
                    priceCheckBox.Checked, discPriceCheckBox.Checked, price));
                if (resultListView.Items.Count == 0)
                    MessageBox.Show("Скидки не найдены!");
            }
        }

        private void priceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInputValues();
        }

        private void discPriceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInputValues();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                priceCheckBox.Enabled = priceCheckBox.Checked = false;
                discPriceCheckBox.Enabled = discPriceCheckBox.Checked = false;
            }
            else
            {
                priceCheckBox.Enabled = true;
                discPriceCheckBox.Enabled = true;
            }
            checkInputValues();
        }

        private void percentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInputValues();
        }

        private void certificateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkInputValues();
        }
        
        private void SearchDiscountForm_Shown(object sender, EventArgs e)
        {
            checkInputValues();
        }

    }
}
