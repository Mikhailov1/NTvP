using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using Model;


namespace View
{
    public partial class DiscountsForm : Form
    {
        public DiscountsForm()
        {
            InitializeComponent();
            #if !DEBUG
            createRandomDataButton.Visible = false;
            #endif
        }

        /// <summary>
        /// формы добавления и поиска
        /// </summary>
        private static AddDiscountForm addDiscountForm;
        private static SearchDiscountForm searchDiscountForm;

        /// <summary>
        /// здесь будут храниться объекты
        /// </summary>
        private List<Discount> discountList = new List<Discount>();
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Discount>));

        /// <summary>
        /// отображение формы добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            addDiscountForm.ShowDialog();
        }

        /// <summary>
        /// создание нового объекта
        /// </summary>
        /// <param name="isPercent"></param>
        /// <param name="price"></param>
        /// <param name="discountSize"></param>
        public void createDiscount(bool isPercent, double price, double discountSize)
        {
            Discount discount = null;
            if (isPercent)
                // процентная скидка
                discount = new ProcentDiscount(price, discountSize);
            else
                // скидка по сертификату
                discount = new СertificateDiscount(price, discountSize);
            discountList.Add(discount);
            discountsListView.Items.Add(convertViewDiscountToListViewItem(discount, discountsListView.Items.Count + 1));
            // разблокируем кнопки удаления, поиска и сохранения
            removeDiscountButton.Enabled = searchDiscountButton.Enabled = saveToFileButton.Enabled = true;
        }

        /// <summary>
        /// метод преобразования объекта в строку таблицы для его отображения
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        private ListViewItem convertViewDiscountToListViewItem(Discount discount, int number)
        {
            return new ListViewItem(new String[]
                {
                    discount.GetType().Equals(typeof(ProcentDiscount)) ? "%" : "С",
                    Convert.ToString(discount.Price),                    
                    Convert.ToString(discount.DiscountedPrice)
                });
        }

        /// <summary>
        /// метод поиска в списке объектов
        /// </summary>
        /// <param name="isPercent"></param>
        /// <param name="isCertificate"></param>
        /// <param name="isPrice"></param>
        /// <param name="isDiscPrice"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public ListViewItem[] searchDiscounts(bool isPercent, bool isCertificate, 
            bool isPrice, bool isDiscPrice, double searchValue)
        {
            List<ListViewItem> resultList = new List<ListViewItem>();
            for (int i = 0; i < discountList.Count; i++)
            {
                bool matches = true;
                if(isPercent || isCertificate)
                    matches = (isPercent && discountList[i].GetType().Equals(typeof(ProcentDiscount))) ||
                        (isCertificate && discountList[i].GetType().Equals(typeof(СertificateDiscount)));
                if (matches && searchValue > 0)
                    matches = (isPrice && discountList[i].Price == searchValue) ||
                    (isDiscPrice && discountList[i].DiscountedPrice == searchValue);
                if (matches) resultList.Add(new ListViewItem(new String[] {
                    discountList[i].GetType().Equals(typeof(ProcentDiscount)) ? "%" : "С",
                    Convert.ToString(discountList[i].Price),
                    Convert.ToString(discountList[i].DiscountedPrice)
                }));
            }
            return resultList.ToArray();
        }

    private void DiscountsForm_Load(object sender, EventArgs e)
        {
            addDiscountForm = new AddDiscountForm(this);
            searchDiscountForm = new SearchDiscountForm(this);
        }

        /// <summary>
        /// метод удаления из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            // если выделена хотя бы одна строка
            if (discountsListView.SelectedItems.Count > 0)
            {
                // выполняем действия для каждой из выделенных строк
                foreach (ListViewItem item in discountsListView.SelectedItems)
                {
                    discountList.RemoveAt(item.Index);
                    discountsListView.Items.RemoveAt(item.Index);
                }
                // изменяем номера строк в таблице после удаления элементов
                for(int i = 0; i<discountsListView.Items.Count; i++)
                    discountsListView.Items[i].SubItems[0].Text = Convert.ToString(i+1);
                // если после удаления элементов список пуст, то кнопки удаления, поиска и сохранения блокируются
                removeDiscountButton.Enabled = searchDiscountButton.Enabled = 
                    saveToFileButton.Enabled = discountList.Count > 0;
            }
            else MessageBox.Show("Необходимо выбрать из списка хотя бы одну строку!");
        }

        /// <summary>
        /// метод заполнения списка случайными значениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createRandomDataButton_Click(object sender, EventArgs e)
        {
            discountList.Clear();
            discountsListView.Items.Clear();
            Random random = new Random();
            // добавляем в список 10 элементов
            for (int i = 0; i<10; i++)
            {
                bool isPercent = random.NextDouble() < 0.5;
                double price = Math.Round(random.NextDouble() * 10000, 2);
                double discountSize = random.Next(1, 100);
                createDiscount(isPercent, price, discountSize);
            }
            // разблокируем кнопки удаления, поиска и сохранения
            removeDiscountButton.Enabled = searchDiscountButton.Enabled = saveToFileButton.Enabled = true;
        }

        /// <summary>
        /// метод сохранения значений в файл с использованием сериализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(this.saveFileDialog.FileName, FileMode.Create);
                TextWriter textWriter = new StreamWriter(stream);
                XmlSerializer xmlSerializer = new XmlSerializer(discountList.GetType());
                xmlSerializer.Serialize(textWriter, discountList);
                textWriter.Close();
            }
        }

        /// <summary>
        /// метод загрузки значений из файла с использованием десериализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(this.openFileDialog.FileName, FileMode.Open);
                TextReader textReader = new StreamReader(stream);
                discountList = (List<Discount>) xmlSerializer.Deserialize(textReader);
                textReader.Close();
                discountsListView.Items.Clear();
                // отображаем загруженные элементы в таблице
                for(int i = 0; i< discountList.Count; i++)
                {
                    discountsListView.Items.Add(convertViewDiscountToListViewItem(discountList[i], i + 1));
                }
                // если после загрузки элементов список пуст, то кнопки удаления, поиска и сохранения блокируются
                removeDiscountButton.Enabled = searchDiscountButton.Enabled = 
                    saveToFileButton.Enabled = discountList.Count > 0;
            }
        }

        // отображение формы поиска
        private void searchDiscountButton_Click(object sender, EventArgs e)
        {
            searchDiscountForm.ShowDialog();
        }

    }
}
