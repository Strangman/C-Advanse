using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task002
{
    public partial class Form1 : Form
    {
        CharactersList list;
        FileInfo file;
        public Form1()
        {
            InitializeComponent();

            list = new CharactersList();

            file = new FileInfo(@"C:\Games\Programming\C# Advanse\Homework11\Homework11\Example\Qw.json");

            using (FileStream be = new FileStream(file.FullName, FileMode.OpenOrCreate)) ;

            string some;
            using (StreamReader stream = file.OpenText())
                some = stream.ReadToEnd();

            if (some.Length > 0)
                list.Characters.AddRange(JsonSerializer.Deserialize<List<Character>>(some));

            dataGridView1.DataSource = list.Characters.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            bool gender = checkBox1.Checked;

            list.Characters.Add(new Character { FirstName = firstName, LastName = lastName, Age = age, Gender = gender, Id = 1 });

            using (FileStream stream = new FileStream(@"C:\Games\Programming\C# Advanse\Homework11\Homework11\Example\Qw.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(stream, list.Characters);
            }

            dataGridView1.DataSource = list.Characters.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
