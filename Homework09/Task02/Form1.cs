using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task02.Models;


namespace Task02
{
    public partial class Form1 : Form
    {
        DataContext dataContext;
        public Form1()
        {
            InitializeComponent();

            dataContext = new DataContext(ConfigurationManager.ConnectionStrings["BookShelfContext"].ToString());


            dgvDirectors.DataSource = dataContext.GetTable<Director>().GetNewBindingList();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            var firstName = textFirstName.Text;
            var lastname = textLastName.Text;
            var birthData = int.Parse(textBirthDate.Text);

            dataContext.GetTable<Director>().InsertOnSubmit(new Director() { Firstname = firstName, LastName = lastname, BirthDate= birthData }) ;

            dataContext.SubmitChanges();

            dgvDirectors.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDirectors.Refresh();
        }
    }
}
