using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task02.Models;


namespace Task02
{
    public partial class Form1 : Form
    {
        BookShelfContext dbContext;
        public Form1()
        {
            InitializeComponent();

            dbContext = new BookShelfContext();
            dbContext.Directors.Load();

            dgvDirectors.DataSource = dbContext.Directors.Local.ToBindingList();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            var firstName = textFirstName.Text;
            var lastname = textLastName.Text;
            var birthData = int.Parse(textBirthDate.Text);

            dbContext.Directors.Add(new Director() { Firstname = firstName, LastName = lastname, BirthDate = birthData });
            dbContext.SaveChanges();

            dgvDirectors.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDirectors.Refresh();
        }
    }
}
