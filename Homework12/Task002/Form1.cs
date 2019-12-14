using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task002
{
    public partial class Form1 : Form
    {
        BookShelfContext dbContext;
        public Form1()
        {
            InitializeComponent();

            Do();
        }
        async Task Do()
        {
            var dbContext = new BookShelfContext();

            await dbContext.Directors.LoadAsync();

            directorTable.DataSource = dbContext.Directors.ToList();
        }
    }
}
