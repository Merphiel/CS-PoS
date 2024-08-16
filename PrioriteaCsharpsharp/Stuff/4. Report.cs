using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace PrioriteaCsharpsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime frompickerstring;
        DateTime topickerstring;        
        public double tempprice = 0;
        public double price = 0;
        DataTable dt = new DataTable();
        private void frompicker_ValueChanged(object sender, EventArgs e)
        {
            dt.Clear();
            price = 0;
            tempprice = 0;
            saleslbl.Text = "Php " + price.ToString();
            var files = Directory.GetFiles(Application.StartupPath.ToString() + @"\XML\Orders\", "*.xml", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DateTime currentfile = File.GetLastWriteTime(file);
                frompickerstring = frompicker.Value.Date;                
                topickerstring = topicker.Value.Date;                
                string xmlfile = Path.GetFileName(file).ToString();
                dataGridView1.DataSource = "";
                if (currentfile >= frompickerstring && currentfile <= topickerstring)
                {
                   
                    DataSet dsload = new DataSet();
                    var doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Orders\" + xmlfile);
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load(Application.StartupPath.ToString() + @"\XML\Orders\" + xmlfile);
                    int check = Convert.ToInt32(doc1.SelectNodes("//pile").Count);
                    

                    var prices = from x in doc.Descendants("pile").Where(x => (string)x.Element("Price") != null)
                                 select new
                                 {
                                     tempprice = x.Element("Price").Value
                                 };
                    foreach (var x in prices)
                    {
                        tempprice = Convert.ToDouble(x.tempprice);
                        price += tempprice;
                    }
                    saleslbl.Text = "Php " + price.ToString();

                    if (dt.Columns.Contains("User") == false)
                    {
                        dt.Columns.Add("User", typeof(string));
                        dt.Columns.Add("Type", typeof(string));
                        dt.Columns.Add("Date and Time", typeof(string));
                        dt.Columns.Add("Size", typeof(string));
                        dt.Columns.Add("Sugar level", typeof(string));
                        dt.Columns.Add("Product Name", typeof(string));
                        dt.Columns.Add("Add-ons", typeof(string));
                        dt.Columns.Add("Price", typeof(string));
                    }

                    
                        foreach (XElement order in doc.Descendants().Where(x => x.Name.LocalName == "order"))
                        {
                            XElement pile = order.Descendants("pile").FirstOrDefault();
                            dt.Rows.Add(new object[] {

                            (string)pile.Element("User"),
                            (string)pile.Element("Type"),
                            (string)pile.Element("Date_and_Time"),
                            (string)pile.Element("Size"),
                            (string)pile.Element("Sugar_level"),
                            (string)pile.Element("Product_name"),
                            (string)pile.Element("Add-ons"),
                            (string)pile.Element("Price")

                    });
                    }
                    dataGridView1.DataSource = dt;
                }
             }
        }

        private void topicker_ValueChanged(object sender, EventArgs e)
        {
            dt.Clear();
            price = 0;
            tempprice = 0;
            saleslbl.Text = "Php " + price.ToString();
            var files = Directory.GetFiles(Application.StartupPath.ToString() + @"\XML\Orders\", "*.xml", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DateTime currentfile = File.GetLastWriteTime(file);
                frompickerstring = frompicker.Value.Date;
                topickerstring = topicker.Value.Date;
                string xmlfile = Path.GetFileName(file).ToString();
                dataGridView1.DataSource = "";
                if (currentfile >= frompickerstring && currentfile <= topickerstring)
                {

                    DataSet dsload = new DataSet();
                    var doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Orders\" + xmlfile);
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load(Application.StartupPath.ToString() + @"\XML\Orders\" + xmlfile);
                    int check = Convert.ToInt32(doc1.SelectNodes("//pile").Count);


                    var prices = from x in doc.Descendants("pile").Where(x => (string)x.Element("Price") != null)
                                 select new
                                 {
                                     tempprice = x.Element("Price").Value
                                 };
                    foreach (var x in prices)
                    {
                        tempprice = Convert.ToDouble(x.tempprice);
                        price += tempprice;
                    }
                    saleslbl.Text = "Php " + price.ToString();

                    if (dt.Columns.Contains("User") == false)
                    {
                        dt.Columns.Add("User", typeof(string));
                        dt.Columns.Add("Type", typeof(string));
                        dt.Columns.Add("Date and Time", typeof(string));
                        dt.Columns.Add("Size", typeof(string));
                        dt.Columns.Add("Sugar level", typeof(string));
                        dt.Columns.Add("Product Name", typeof(string));
                        dt.Columns.Add("Add-ons", typeof(string));
                        dt.Columns.Add("Price", typeof(string));
                    }


                    foreach (XElement order in doc.Descendants().Where(x => x.Name.LocalName == "order"))
                    {
                        XElement pile = order.Descendants("pile").FirstOrDefault();
                        dt.Rows.Add(new object[] {

                            (string)pile.Element("User"),
                            (string)pile.Element("Type"),
                            (string)pile.Element("Date_and_Time"),
                            (string)pile.Element("Size"),
                            (string)pile.Element("Sugar_level"),
                            (string)pile.Element("Product_name"),
                            (string)pile.Element("Add-ons"),
                            (string)pile.Element("Price")

                    });
                    }
                    dataGridView1.DataSource = dt;
                }
            }

        }
        private void orderbtn_Click(object sender, EventArgs e)
        {
            PrioriteaCsharpsharp.Stuff.Order f3 = new PrioriteaCsharpsharp.Stuff.Order();
            this.Close();
            f3.Show();
        }

        private void incomingbtn_Click(object sender, EventArgs e)
        {
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yy");
        }
    }
}
