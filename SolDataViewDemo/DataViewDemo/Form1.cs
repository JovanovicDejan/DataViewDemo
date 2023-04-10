using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable students;
        DataView vstudents;
        private void btnCreateDataTable_Click(object sender, EventArgs e)
        {
            students = new DataTable("Students");
            //Definition of table structure

            //Identity
            DataColumn id = new DataColumn("ID")
            {
                DataType = typeof(int),
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
                AllowDBNull = false
            };

            students.Columns.Add(id);

            //index

            DataColumn index = new DataColumn("Index")
            {
                DataType = typeof(string),
                MaxLength = 100,
                Unique = true,
                AllowDBNull = false,
                Caption = "Index"
            }; 
            
            students.Columns.Add(index);

            DataColumn name = new DataColumn("Name")
            {
                DataType = typeof(string),
                MaxLength = 50,
                AllowDBNull = false
            };

            students.Columns.Add(name);


            //PK

            students.PrimaryKey = new DataColumn[] { id };

            Random rnd = new Random();

            for(int i = 0; i < 1000; i++)
            {
                DataRow newStudent = students.NewRow();
                newStudent["Index"] = rnd.NextDouble().ToString().Substring(2,10);
                newStudent["Name"] = "Student" + i.ToString();
                students.Rows.Add(newStudent);
            }
            Grid.DataSource = students;

        }

        private void btnPrimeniFilter_Click(object sender, EventArgs e)
        {
            vstudents = new DataView(students);
            try
            {
                vstudents.RowFilter = txtFilter.Text;
                vGrid.DataSource = vstudents;
                this.Text = "Records count: " + vstudents.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPrimeniSort_Click(object sender, EventArgs e)
        {
            vstudents = new DataView(students);
            try
            {
                vstudents.Sort = txtSort.Text;
                vGrid.DataSource = vstudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFilterSort_Click(object sender, EventArgs e)
        {
            vstudents = new DataView(students);
            try
            {
                vstudents.RowFilter = txtFilter.Text;
                vstudents.Sort = txtSort.Text;
                vGrid.DataSource = vstudents;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                students.WriteXml(@"../DataViewDemo/studentswithschema.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Saved");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DataTable students2 = new DataTable();
            students2.ReadXml(@"../DataViewDemo/studentswithschema.xml");
            Grid.DataSource = students2;
        }
    }
}
