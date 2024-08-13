using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using static ASM21.Form2;

namespace ASM21
{
    public partial class Form2 : Form
    {
        List<string> listCustomerType = new List<string>() { "Household customer", "Administrative agency, public services", "Production units", "Business services" };
        private List<Customer> customers = new List<Customer>();

        public Form2()
        {
            InitializeComponent();
            cboCustomertype.DataSource = listCustomerType;
        }

        public class Customer
        {
            public string Name { get; set; }
            public double TotalAmountWithoutTax { get; set; }
            public double LastMonth { get; set; } 
            public double ThisMonth { get; set; } 
            public string NumberOfPeople { get; set; } 
            public double VAT { get; set; }
            public double EnvironmentFee { get; set; }
            public double TotalPrice { get; set; }
            public string CustomerType { get; set; }

        }
 
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void lbCustomername_Click(object sender, EventArgs e) { }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomername.Text;
            double lastMonth = double.Parse(txtLastmonthreading.Text);
            double thisMonth = double.Parse(txtThismonthreading.Text);
            int numberOfPeople = (int)nudNumberofpeople.Value;
            string toc_1 = cboCustomertype.SelectedItem.ToString();

            // Calculate water consumption
            double waterConsumption = thisMonth - lastMonth;
            double consumptionPerPerson_1 = waterConsumption / numberOfPeople;

            // Variables for calculation
            double priceM3_1;
            double totalAmountWithoutTax;
            double vat;
            double environmentFee;
            double totalPrice;

            // Call checkSign function to get the price per M3
            checkSign(toc_1, out priceM3_1, consumptionPerPerson_1);

            // Calculate total amounts
            totalAmountWithoutTax = consumptionPerPerson_1 * priceM3_1;
            environmentFee = totalAmountWithoutTax * 0.1;
            vat = totalAmountWithoutTax * 0.1;
            totalPrice = totalAmountWithoutTax + vat + environmentFee;

            // Display the results
            txbResult.Text = $"Profile customer:\n" + Environment.NewLine
                             + $"Name customer: {customerName}\n" + Environment.NewLine
                             + $"Number water last month: {lastMonth}\n" + Environment.NewLine
                             + $"Number water this month: {thisMonth}\n" + Environment.NewLine
                             + $"Amount of consumption: {waterConsumption} M3\n" + Environment.NewLine
                             + $"Number of People: {numberOfPeople}\n" + Environment.NewLine
                             + $"Total price: {totalPrice} VND";

            ListViewItem item = lsvbill.Items.Add(customerName);
            item.SubItems.Add(lastMonth.ToString());
            item.SubItems.Add(thisMonth.ToString());
            item.SubItems.Add(toc_1);
            item.SubItems.Add(numberOfPeople.ToString());
            item.SubItems.Add(totalPrice.ToString("F2") + " VND");

            // Add to customers list
            customers.Add(new Customer
            {
                Name = customerName,
                TotalAmountWithoutTax = totalAmountWithoutTax,
                VAT = vat,
                EnvironmentFee = environmentFee,
                TotalPrice = totalPrice
            });

            // Clear input fields
            txtCustomername.Text = "";
            txtLastmonthreading.Text = "";
            txtThismonthreading.Text = "";
            cboCustomertype.SelectedItem = null;
            nudNumberofpeople.Value = 0;
        }

        private void checkSign(string toc, out double priceM3, double consumptionPerPerson)
        {
            priceM3 = 0;

            if (toc == "Household customer")
            {
                if (consumptionPerPerson >= 0 && consumptionPerPerson <= 10)
                {
                    priceM3 = 5.973;
                }
                else if (consumptionPerPerson > 10 && consumptionPerPerson <= 20)
                {
                    priceM3 = 7.052;
                }
                else if (consumptionPerPerson > 20 && consumptionPerPerson <= 30)
                {
                    priceM3 = 8.699;
                }
                else
                {
                    priceM3 = 15.929;
                }
            }
            else if (toc == "Administrative agency, public services")
            {
                priceM3 = 9.955;
            }
            else if (toc == "Production units")
            {
                priceM3 = 11.615;
            }
            else if (toc == "Business services")
            {
                priceM3 = 22.068;
            }
            else
            {
                MessageBox.Show("Invalid value");
            }
        }

        private void lbResult_Click(object sender, EventArgs e) { }

        private void Form2_Load(object sender, EventArgs e)
        {
            cboCustomertype.DataSource = listCustomerType;
        }

        private void lsvbill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvbill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvbill.SelectedItems[0];
                txtCustomername.Text = item.SubItems[0].Text;
                txtLastmonthreading.Text = item.SubItems[1].Text;
                txtThismonthreading.Text = item.SubItems[2].Text;
                cboCustomertype.SelectedItem = item.SubItems[3].Text;
                nudNumberofpeople.Value = int.Parse(item.SubItems[4].Text);
            }

            lsvbill.Columns[0].Width = (int)(lsvbill.Width * 0.10);
            lsvbill.Columns[1].Width = (int)(lsvbill.Width * 0.17);
            lsvbill.Columns[2].Width = (int)(lsvbill.Width * 0.17);
            lsvbill.Columns[3].Width = (int)(lsvbill.Width * 0.17);
            lsvbill.Columns[4].Width = (int)(lsvbill.Width * 0.15);
            lsvbill.Columns[5].Width = (int)(lsvbill.Width * 0.15);
            lsvbill.View = View.Details;
            lsvbill.GridLines = true;
            lsvbill.FullRowSelect = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvbill.SelectedItems.Count > 0)
            {
                lsvbill.Items.Remove(lsvbill.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Must select at least 1 row!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvbill.SelectedItems.Count > 0)
            {
                // Lấy mục đã chọn
                ListViewItem selectedItem = lsvbill.SelectedItems[0];

                // Lấy thông tin từ các điều khiển
                string customerName = txtCustomername.Text;
                double lastMonth = double.Parse(txtLastmonthreading.Text);
                double thisMonth = double.Parse(txtThismonthreading.Text);
                int numberOfPeople = (int)nudNumberofpeople.Value;
                string toc_1 = cboCustomertype.SelectedItem.ToString();
                string customerType = cboCustomertype.SelectedItem?.ToString() ?? string.Empty;

                // Tính toán lượng nước tiêu thụ
                double waterConsumption = thisMonth - lastMonth;
                double consumptionPerPerson = waterConsumption / numberOfPeople;

                // Tính toán giá tiền
                double priceM3;
                double totalAmountWithoutTax;
                double vat;
                double environmentFee;
                double totalPrice;

                // Gọi hàm checkSign để lấy giá per M3
                checkSign(customerType, out priceM3, consumptionPerPerson);

                // Tính toán các khoản chi
                totalAmountWithoutTax = consumptionPerPerson * priceM3;
                environmentFee = totalAmountWithoutTax * 0.1;
                vat = totalAmountWithoutTax * 0.1;
                totalPrice = totalAmountWithoutTax + vat + environmentFee;

                // Cập nhật thông tin trong ListView
                selectedItem.SubItems[0].Text = customerName;
                selectedItem.SubItems[1].Text = txtLastmonthreading.Text;
                selectedItem.SubItems[2].Text = txtThismonthreading.Text;
                selectedItem.SubItems[3].Text = customerType;
                selectedItem.SubItems[4].Text = nudNumberofpeople.Value.ToString();
                selectedItem.SubItems[5].Text = totalPrice.ToString("F2") + " VND";

                // Cập nhật giá tiền tổng
                totalPrice = 0;
            }
            else
            {
                MessageBox.Show("You must select at least one row to edit!");
            }
        }

        private List<ListViewItem> originalItems = new List<ListViewItem>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
                string searchTerm = txtSearch.Text.Trim().ToLower();

                // Lưu các mục hiện tại vào một danh sách tạm thời
                List<ListViewItem> itemsToShow = new List<ListViewItem>();

                foreach (ListViewItem item in lsvbill.Items)
                {
                    // Kiểm tra nếu tên khách hàng trong mục có chứa từ tìm kiếm
                    if (item.SubItems[0].Text.ToLower().Contains(searchTerm))
                    {
                        itemsToShow.Add(item); // Thêm mục phù hợp vào danh sách tạm thời
                    }
                }

                // Xóa tất cả các mục hiện tại trong ListView
                lsvbill.Items.Clear();

                // Thêm các mục từ danh sách tạm thời vào ListView
                if (itemsToShow.Count > 0)
                {
                    lsvbill.Items.AddRange(itemsToShow.ToArray());
                }
                else
                {
                    MessageBox.Show("No customer found with name: " + searchTerm);
                }
        }
        


        private void txtCustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = lsvbill.Items.Cast<ListViewItem>().ToList();

            // Sắp xếp danh sách các mục theo giá (giả sử giá ở cột 5)
            items.Sort((item1, item2) =>
            {
                double price1 = double.Parse(item1.SubItems[5].Text.Replace(" VND", "").Trim());
                double price2 = double.Parse(item2.SubItems[5].Text.Replace(" VND", "").Trim());
                return price1.CompareTo(price2);
            });

            // Xóa tất cả các mục hiện có trong ListView
            lsvbill.Items.Clear();

            // Thêm các mục đã sắp xếp vào ListView
            lsvbill.Items.AddRange(items.ToArray());
        }
    }
}