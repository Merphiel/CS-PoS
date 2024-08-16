using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

namespace PrioriteaCsharpsharp.Stuff
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public double tempprice = 0;
        public double price = 0;
        public double temppval = 0;
        //---------------------GOTO MENU---------------------//
        private void incomingbtn_Click(object sender, EventArgs e)
        {
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }
        //---------------------LOGOUT AND EXIT---------------------//
        private void loggingoutbt_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Close();
            f1.Show();
        }
      
        private void exitbtn_Click(object sender, EventArgs e)
        {
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }

        //---------------------CLOCK---------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yy");
        }

        private void Order_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath.ToString() + @"\XML\Orders.xml") == true)
            {
                DataSet dsload = new DataSet();
                DataTable dt = new DataTable();
                var doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Orders.xml");
                var prices = from x in doc.Descendants("order").Descendants("pile").Where(x => (string)x.Element("Price") != "")
                             select new
                             {
                                 tempprice = x.Element("Price").Value
                             };
                foreach (var x in prices)
                {   
                    tempprice = Convert.ToDouble(x.tempprice);
                    price += tempprice;
                }
                totaltxt.Text = price.ToString();

                dt.Columns.Add("User", typeof(string));
                dt.Columns.Add("Type", typeof(string));
                dt.Columns.Add("Date and Time", typeof(string));
                dt.Columns.Add("Size", typeof(string));
                dt.Columns.Add("Sugar level", typeof(string));
                dt.Columns.Add("Product Name", typeof(string));
                dt.Columns.Add("Add-ons", typeof(string));
                dt.Columns.Add("Price", typeof(string));
               

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
            else
            {
                logoutbtn f2 = new logoutbtn();
                this.Close();
                f2.Show();
            }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tempprice = 0;
            price = 0;
            DataSet dsload = new DataSet();
            var doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Orders.xml");
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(Application.StartupPath.ToString() + @"\XML\Orders.xml");
            int check = Convert.ToInt32(doc1.SelectNodes("//pile").Count);
            if (doc != null)
            {                
                if (check >= 2)
                {
                    DataTable dt = new DataTable();
                    doc.Descendants("Orders").Descendants("order").Last().Element("pile").Elements().ToList().Remove();
                    doc.Descendants().Where(x => (x.Attributes().All(a => a.IsNamespaceDeclaration)) && string.IsNullOrWhiteSpace(x.Value)).Remove();

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
                    totaltxt.Text = price.ToString();

                    doc.Save(Application.StartupPath.ToString() + @"\XML\Orders.xml");
                    dt.Columns.Add("User", typeof(string));
                    dt.Columns.Add("Type", typeof(string));
                    dt.Columns.Add("Date and Time", typeof(string));
                    dt.Columns.Add("Size", typeof(string));
                    dt.Columns.Add("Sugar level", typeof(string));
                    dt.Columns.Add("Product Name", typeof(string));
                    dt.Columns.Add("Add-ons", typeof(string));
                    dt.Columns.Add("Price", typeof(string));
                    

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
                else
                {
                    File.Delete(Application.StartupPath.ToString() + @"\XML\Orders.xml");
                    logoutbtn f2 = new logoutbtn();
                    this.Close();
                    f2.Show();
                }

            }


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath.ToString() + @"\XML\Orders.xml");
            logoutbtn f2 = new logoutbtn();
            this.Close();
            f2.Show();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            this.Close();
            f4.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + @"\XML\Orders.xml";
            if (File.Exists(path))
            {
                File.Copy(Application.StartupPath.ToString() + @"\XML\Orders.xml", Application.StartupPath.ToString() + @"\XML\Orders\" + DateTime.Now.ToString("D") + DateTime.Now.ToString("FFFFFFF") + " " + DateTime.Now.ToString("dd") + ".xml");
                File.Delete(path);
                logoutbtn f2 = new logoutbtn();
                this.Close();
                f2.Show();
            }
            else
            {
                logoutbtn f2 = new logoutbtn();
                this.Close();
                f2.Show();
            }

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}