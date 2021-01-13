using NorthwindDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NorthwindExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindContext context = new NorthwindContext();

        public MainWindow()
        {
            InitializeComponent();

            context.Database.Log += LogIt;
        }

        private void LogIt(string logString)
        {
            txtLog.Text = $"{txtLog.Text}{logString}";
            txtLog.ScrollToEnd();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var qCountries = context.Customers.Select(cu => cu.Country).Distinct();

            foreach (string country in qCountries)
            {
                TreeViewItem countryNode = new TreeViewItem() { Header = country };
                countryNode.Items.Add(new TreeViewItem());
                countryNode.Expanded += CountryNode_Expanded;
                trvCustomers.Items.Add(countryNode);
            }
        }

        private void CountryNode_Expanded(object sender, RoutedEventArgs e)
        {
            if (sender is TreeViewItem countryNode)
            {
                countryNode.Items.Clear();

                var qCustomersByCountry = context.Customers.Where(cu => cu.Country == countryNode.Header.ToString());

                foreach (Customer customer in qCustomersByCountry.OrderBy(cu => cu.CompanyName))
                {
                    TreeViewItem customerNode = new TreeViewItem() { Header = customer.CompanyName, Tag = customer };
                    customerNode.Selected += CustomerNode_Selected;
                    countryNode.Items.Add(customerNode);
                }
            }
        }

        private void CustomerNode_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (((TreeViewItem)trvCustomers.SelectedItem).Tag is Customer customer)
            {
                AddEditCustomer editCustomer = new AddEditCustomer(customer);

                if (editCustomer.ShowDialog() == true)
                {
                    context.SaveChanges();
                }
                else
                {
                    // customer-Objekt zurücksetzen

                    //context.Entry(customer).CurrentValues.SetValues(context.Entry(customer).GetDatabaseValues());
                    //context.Entry(customer).State = System.Data.Entity.EntityState.Unchanged;

                    context.Entry(customer).Reload();
                }
            }
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();

            AddEditCustomer addCustomer = new AddEditCustomer(customer);

            if (addCustomer.ShowDialog() == true)
            {
                context.Customers.Add(customer); // EntityState = Added
                context.SaveChanges();
            }
        }
    }
}
