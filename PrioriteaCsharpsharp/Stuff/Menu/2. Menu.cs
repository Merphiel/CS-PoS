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


/// <summary>
/// TODO (BY PRIORITY)
/// 2. connect username to xmlfile
/// </summary>

namespace PrioriteaCsharpsharp
{
    public partial class logoutbtn : Form
    {
        public logoutbtn()
        {
            InitializeComponent();
        }
        //------------------FUNCTIONS------------------//
        public void disableeverything()
        {
            //Disables everything to prevent stacking
            mtlayout.Visible = false;
            mtlayout.Enabled = false;
            frappelayout.Visible = false;
            frappelayout.Enabled = false;
            fruittealayout.Visible = false;
            fruittealayout.Enabled = false;
            oreolayout.Visible = false;
            oreolayout.Enabled = false;
            cheesecakelayout.Visible = false;
            cheesecakelayout.Enabled = false;
            icedblendedlayout.Visible = false;
            icedblendedlayout.Enabled = false;
            yakultlayout.Enabled = false;
            yakultlayout.Visible = false;
            ibradio.Visible = false;
            ibradio.Enabled = false;
            ibradio.Checked = false;
        }
        public void addondisable()
        {
            tsink.Checked = false;
            cjsink.Checked = false;
            nsink.Checked = false;
            pbsink.Checked = false;
            epsink.Checked = false;
            rssink.Checked = false;          
            ibradio.Checked = false;
            sssize.Checked = true;
            osugar.Checked = true;
        }
        public void mtdisable()
        {
            mt1.Click -= mthandler;
            mt2.Click -= mthandler;
            mt3.Click -= mthandler;
            mt4.Click -= mthandler;
            mt5.Click -= mthandler;
            mt6.Click -= mthandler;
            mt7.Click -= mthandler;
            mt8.Click -= mthandler;
            mt9.Click -= mthandler;
            mt10.Click -= mthandler;
            mt11.Click -= mthandler;
            mt12.Click -= mthandler;
            mt13.Click -= mthandler;
            mt14.Click -= mthandler;
            mt15.Click -= mthandler;
        }
        public void frdisable()
        {
            fr1.Click -= frhandler;
            fr2.Click -= frhandler;
            fr3.Click -= frhandler;
            fr4.Click -= frhandler;
            fr5.Click -= frhandler;
            fr6.Click -= frhandler;
            fr7.Click -= frhandler;
            fr8.Click -= frhandler;
            fr9.Click -= frhandler;
            fr10.Click -= frhandler;
        }
        public void ftdisable()
        {
            ft1.Click -= fthandler;
            ft2.Click -= fthandler;
            ft3.Click -= fthandler;
            ft4.Click -= fthandler;
            ft5.Click -= fthandler;
            ft6.Click -= fthandler;
            ft7.Click -= fthandler;
            ft8.Click -= fthandler;
        }
        public void ordisable()
        {
            or1.Click -= orhandler;
            or2.Click -= orhandler;
            or3.Click -= orhandler;
            or4.Click -= orhandler;
            or5.Click -= orhandler;
            or6.Click -= orhandler;
        }
        public void csdisable()
        {
            cs6.Click -= cshandler;
            cs1.Click -= cshandler;
            cs2.Click -= cshandler;
            cs3.Click -= cshandler;
            cs4.Click -= cshandler;
            cs5.Click -= cshandler;
            cs6.Click -= cshandler;
            cs7.Click -= cshandler;
        }
        public void ibdisable()
        {
            ib1.Click -= ibhandler;
            ib2.Click -= ibhandler;
            ib3.Click -= ibhandler;
            ib4.Click -= ibhandler;
        }
        public void ydisable()
        {
            y1.Click -= yhandler;
            y2.Click -= yhandler;
            y3.Click -= yhandler;
            y4.Click -= yhandler;
            y5.Click -= yhandler;
            y6.Click -= yhandler;
            y7.Click -= yhandler;
            y8.Click -= yhandler;

        }

        

        public string type = "";
        public double currentprice = 0;
        public string pricetostring;
        public string currentuser;
        public int idnum = 0;
        public double addons = 0;
        double pricesd = 0;
        int temppval = 0;
        public bool fromorder = false;
        //---------------------COMPUTATIONS/EVALUAION/TRANSFORMATIONS---------------------//
        private void addonadd()
        {
            addonlabel.Text = "";
            sugarlevel.Text = "";
            sizelbl.Text = "";
            if (ttsize.Checked == true)
            {
                adata.adding += adata.addons[0];
                addons += adata.addons[0];
                sizelbl.Text += "22 oz";
            }
            else
            {
                sizelbl.Text += "16 oz";
            }
            if (osugar.Checked == true)
            {
                sugarlevel.Text += "0%";
            }else if(tfsugar.Checked == true)
            {
                sugarlevel.Text += "20%";
            }else if(ftsugar.Checked == true)
            {
                sugarlevel.Text += "50%";
            }else if(sfsugar.Checked == true)
            {
                sugarlevel.Text += "75%";
            }else if(ohsugar.Checked == true)
            {
                sugarlevel.Text += "100%";
            }
            if (ibradio.Checked == true)
            {
                adata.adding += adata.addons[0];
                addons += adata.addons[0];
                addonlabel.Text += "IB ";
            }
            if (tsink.Checked == true)
            {
                adata.adding += adata.addons[0];
                addons += adata.addons[0];
                addonlabel.Text += "TP ";
            }       
            if(cjsink.Checked == true)
            {
                adata.adding += adata.addons[1];
                addons += adata.addons[1];
                addonlabel.Text += "CJ ";
            }      
            if (nsink.Checked == true)
            {
                adata.adding += adata.addons[2];
                addons += adata.addons[2];
                addonlabel.Text += "NC ";
            }         
            if (epsink.Checked == true)
            {
                adata.adding += adata.addons[3];
                addons += adata.addons[3];
                addonlabel.Text += "EP ";
            }     
            if (rssink.Checked == true)
            {
                adata.adding += adata.addons[4];
                addons += adata.addons[4];
                addonlabel.Text += "RSnC ";
            }    
            if (pbsink.Checked == true){
                adata.adding += adata.addons[5];
                addons += adata.addons[5];
                addonlabel.Text += "PB";
            }
            if (addonlabel.Text == "")
            {
                addonlabel.Text = "N/A";
            }
        }
        private void totstring()
        {
            addonadd();            
                    XmlDocument getuser = new XmlDocument();
               
                    string path = Directory.GetCurrentDirectory() + @"\XML\Orders.xml";
                    
                    tot.totalquantity = mtdata.valqua + frdata.valqua + ftdata.valqua + ordata.valqua + csdata.valqua + ibdata.valqua + ydata.valqua + temppval;
                    tot.totalprice = mtdata.priceval + frdata.priceval + ftdata.priceval + ordata.priceval + csdata.priceval + ibdata.priceval + ydata.priceval + adata.adding + pricesd;
                    string quantitytext = tot.totalquantity.ToString();
                    string pricetext = tot.totalprice.ToString();                    
                    quantity.Text = quantitytext;
                    price.Text = "PhP " + pricetext;
                    currentprice += addons;
                    pricetostring = currentprice.ToString();
                    idnum += 1;

                    getuser.Load(Directory.GetCurrentDirectory() + @"\XML\tempcreds.xml");                   

                    string cstype = Convert.ToString(type);
                    string csdate = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy" + " " + "HH:mm:ss"));
                    string cssize = Convert.ToString(sizelbl.Text);
                    string cssugar = Convert.ToString(sugarlevel.Text);
                    string csproductname = Convert.ToString(dname.Text);
                    string csaddons = Convert.ToString(addonlabel.Text);
                    string csprice = Convert.ToString(pricetostring);
                    string csnum = Convert.ToString(idnum);
                    string csuser = Convert.ToString(getuser.SelectSingleNode("//user").InnerText);
                    XmlDocument xdoc = new XmlDocument();
                   
                    if (File.Exists(path) == true)
                    {
                        xdoc.Load(path);
                    }
                    else
                    {
                        XDocument xdoctemp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("Orders"));
                        xdoctemp.Save(path);
                        xdoc.Load(path);
                    }
                    XmlNode orderings = xdoc.CreateElement("order");
                    XmlNode ordering = xdoc.CreateElement("pile");

                    XmlNode etype = xdoc.CreateElement("Type");
                    etype.InnerText = cstype.ToString();
                    ordering.AppendChild(etype);
                    orderings.AppendChild(ordering);
                    XmlNode edate = xdoc.CreateElement("Date_and_Time");
                    edate.InnerText = csdate.ToString();
                    ordering.AppendChild(edate);
                    orderings.AppendChild(ordering);
                    XmlNode esize = xdoc.CreateElement("Size");
                    esize.InnerText = cssize.ToString();
                    ordering.AppendChild(esize);
                    orderings.AppendChild(ordering);
                    XmlNode esugar = xdoc.CreateElement("Sugar_level");
                    esugar.InnerText = cssugar.ToString();
                    ordering.AppendChild(esugar);
                    orderings.AppendChild(ordering);
                    XmlNode eproductname = xdoc.CreateElement("Product_name");
                    eproductname.InnerText = csproductname.ToString();
                    ordering.AppendChild(eproductname);
                    orderings.AppendChild(ordering);
                    XmlNode eaddons = xdoc.CreateElement("Add-ons");
                    eaddons.InnerText = csaddons.ToString();
                    ordering.AppendChild(eaddons);
                    orderings.AppendChild(ordering);
                    XmlNode eprice = xdoc.CreateElement("Price");
                    eprice.InnerText = csprice.ToString();
                    ordering.AppendChild(eprice);
                    orderings.AppendChild(ordering);
                    XmlNode euser = xdoc.CreateElement("User");
                    euser.InnerText = csuser.ToString();
                    ordering.AppendChild(euser);
                    orderings.AppendChild(ordering);
                    xdoc.DocumentElement.AppendChild(ordering);
                    orderings.AppendChild(ordering);
                    xdoc.DocumentElement.AppendChild(orderings);
                    xdoc.Save(path);
                    addondisable();
                    currentprice = 0;
                    addons = 0;    
        }
        
        //------------------DECLARATIONS------------------//
        milkteadata mtdata = new milkteadata(58, 0, 0);
        frappedata frdata = new frappedata(90, 0, 0);
        fruitteadata ftdata = new fruitteadata(58, 0, 0);
        oreomixesdata ordata = new oreomixesdata(80, 0, 0);
        cheesecakedata csdata = new cheesecakedata(90, 0, 0);
        icedblendedcoffeedata ibdata = new icedblendedcoffeedata(60, 0, 0);
        yakultmixesdata ydata = new yakultmixesdata(75, 0, 0);
        addonsdata adata = new addonsdata(0);
        totals tot = new totals(0, 0);
        //-----------------------------------------------//
        public int mtstuck = 0;
        public int frstuck = 0;
        public int ftstuck = 0;
        public int orstuck = 0;
        public int csstuck = 0;
        public int ibstuck = 0;
        public int ystuck = 0;
        //------------------DROPDOWN BOX------------------//
        private void beverage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (beverage.SelectedIndex)
            {    
                //milktea
                case 0:
                    if (mtstuck >= 1)
                    {
                        mtdisable();
                        mtstuck = 0;
                    }                        
                       mt1.Click += mthandler;
                       mt2.Click += mthandler;
                       mt3.Click += mthandler;
                       mt4.Click += mthandler;
                       mt5.Click += mthandler;
                       mt6.Click += mthandler;
                       mt7.Click += mthandler;
                       mt8.Click += mthandler;
                       mt9.Click += mthandler;
                       mt10.Click += mthandler;
                       mt11.Click += mthandler;
                       mt12.Click += mthandler;
                       mt13.Click += mthandler;
                       mt14.Click += mthandler;
                       mt15.Click += mthandler;
                    mtstuck += 1;
                    disableeverything();
                    mtlayout.Enabled = true;
                    mtlayout.Visible = true;             
                    break;                 
                //frappe
                case 1:
                        if (frstuck >= 1)
                        {
                            frdisable();
                            frstuck = 0;
                        }
                        fr1.Click += frhandler;
                        fr2.Click += frhandler;
                        fr3.Click += frhandler;
                        fr4.Click += frhandler;
                        fr5.Click += frhandler;
                        fr6.Click += frhandler;
                        fr7.Click += frhandler;
                        fr8.Click += frhandler;
                        fr9.Click += frhandler;
                        fr10.Click += frhandler;
                    frstuck += 1;
                    disableeverything();
                    frappelayout.Enabled = true;
                    frappelayout.Visible = true;                    
                    break;
                //fruit tea
                case 2:
                    if (ftstuck >= 1)
                    {
                        ftdisable();
                        ftstuck = 0;
                    }
                        ft1.Click += fthandler;
                        ft2.Click += fthandler;
                        ft3.Click += fthandler;
                        ft4.Click += fthandler;
                        ft5.Click += fthandler;
                        ft6.Click += fthandler;
                        ft7.Click += fthandler;
                        ft8.Click += fthandler;
                    ftstuck += 1;
                    disableeverything();                  
                    ibradio.Enabled = true;
                    ibradio.Visible = true;
                    fruittealayout.Enabled = true;
                    fruittealayout.Visible = true;
                    break;
                //oreo mixes
                case 3:
                        if (orstuck >= 1)
                        {
                            ordisable();
                            orstuck = 0;
                        }
                        or1.Click += orhandler;
                        or2.Click += orhandler;
                        or3.Click += orhandler;
                        or4.Click += orhandler;
                        or5.Click += orhandler;
                        or6.Click += orhandler;
                    orstuck += 1;
                    disableeverything();  
                    oreolayout.Enabled = true;
                    oreolayout.Visible = true;
                    break;
                //cheescake series
                case 4:
                        if (csstuck >= 1)
                        {
                            csdisable();
                            csstuck = 0;
                        }
                        cs1.Click += cshandler;    
                        cs2.Click += cshandler;
                        cs3.Click += cshandler;
                        cs4.Click += cshandler;
                        cs5.Click += cshandler;
                        cs6.Click += cshandler;
                        cs7.Click += cshandler;
                    csstuck += 1;
                    disableeverything();
                    cheesecakelayout.Enabled = true;
                    cheesecakelayout.Visible = true;
                    break;
                //ice blended coffee
                case 5:
                        if (ibstuck >= 1)
                        {
                            ibdisable();
                            ibstuck = 0;
                        }
                        ib1.Click += ibhandler;    
                        ib2.Click += ibhandler;
                        ib3.Click += ibhandler;
                        ib4.Click += ibhandler;
                    ibstuck += 1;
                    disableeverything();
                    icedblendedlayout.Enabled = true;
                    icedblendedlayout.Visible = true;
                    break;
                //yakult mixes
                case 6:
                        if (ystuck >= 1)
                        {
                            ydisable();
                            ystuck = 0;
                        }
                        y1.Click += yhandler;
                        y2.Click += yhandler;
                        y3.Click += yhandler;
                        y4.Click += yhandler;
                        y5.Click += yhandler;
                        y6.Click += yhandler;
                        y7.Click += yhandler;
                        y8.Click += yhandler;
                    ystuck += 1;
                    disableeverything();
                    ibradio.Enabled = true;
                    ibradio.Visible = true;
                    yakultlayout.Enabled = true;
                    yakultlayout.Visible = true;
                    break;

                default:
               
                    disableeverything();
                    break;
            }               
        }
        //------------------ALL HANDLERS------------------//
        private void mthandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mtdata.valqua += 1;
            mtdata.priceval += mtdata.price;
            type = "Milk Tea";
            currentprice += mtdata.price;
            dname.Text = button.Text + " Milk Tea";
            totstring();
        }
        private void frhandler(object sender, EventArgs e)
        {
            frdata.valqua += 1;
            frdata.priceval += frdata.price;
            type = "Frappe";
            currentprice += frdata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Frappe";
            totstring();

        }
        private void fthandler(object sender, EventArgs e)
        {
            ftdata.valqua += 1;
            ftdata.priceval += ftdata.price;
            type = "Fruit Tea";
            currentprice += ftdata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Fruit Tea";
            totstring();

        }
        private void orhandler(object sender, EventArgs e)
        {
            ordata.valqua += 1;
            ordata.priceval += ordata.price;
            type = "Oreo Mix";
            currentprice += ordata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Oreo Mix";
            totstring();
        }
        private void cshandler(object sender, EventArgs e)
        {
            csdata.valqua += 1;
            csdata.priceval += csdata.price;
            type = "Cheesecake Series";
            currentprice += csdata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Cheesecake Series";
            totstring();
        }
        private void ibhandler(object sender, EventArgs e)
        {
            ibdata.valqua += 1;
            ibdata.priceval += ibdata.price;
            type = "Ice Blended Coffee";
            currentprice += ibdata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Iced Blended Coffee";
            totstring();            
        }
        private void yhandler(object sender, EventArgs e)
        {
            ydata.valqua += 1;
            ydata.priceval += ydata.price;
            type = "Yakult Mix";
            currentprice += ydata.price;
            Button button = (Button)sender;
            dname.Text = button.Text + " Yakult Mix";
            totstring();            
        }
        //---------------------CLOCK---------------------//
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yy");
        }
        //---------------------CLEAR---------------------//
        private void clearbtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\XML\Orders.xml";

            mtdata.valqua = 0;
            mtdata.priceval = 0;
            frdata.valqua = 0;
            frdata.priceval = 0;
            ftdata.valqua = 0;
            ftdata.priceval = 0;
            ordata.valqua = 0;
            ordata.priceval = 0;
            csdata.valqua = 0;
            csdata.priceval = 0;
            ibdata.valqua = 0;
            ibdata.priceval = 0;
            ydata.valqua = 0;
            ydata.priceval = 0;
            adata.adding = 0;
            tot.totalquantity = 0;
            tot.totalprice = 0;
            price.Text = "";
            quantity.Text = "";
            tsink.Checked = false;
            cjsink.Checked = false;
            nsink.Checked = false;
            pbsink.Checked = false;
            epsink.Checked = false;
            rssink.Checked = false;
            ibradio.Checked = false;
            File.Delete(path);
        }
        //---------------------EXIT---------------------//
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void orderbtn_Click(object sender, EventArgs e)
        {           
            if(File.Exists(Application.StartupPath.ToString() + @"\XML\Orders.xml") == false)
            {
                MessageBox.Show("No data to input!");
            }
            else
            {
                PrioriteaCsharpsharp.Stuff.Order f3 = new PrioriteaCsharpsharp.Stuff.Order();
                this.Close();
                f3.Show();
            }
        }
        private void vieworderbtn_Click(object sender, EventArgs e)
        {
            PrioriteaCsharpsharp.Stuff.Order f3 = new PrioriteaCsharpsharp.Stuff.Order();
            this.Close();
            f3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            this.Close();
            f1.Show();
        }
        private void logoutbtn_Load(object sender, EventArgs e)
        { 
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            this.Close();
            f4.Show();
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Print Receipt Immediately?", "CONFIRM ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && File.Exists(Application.StartupPath.ToString() + @"\XML\Orders.xml") == true){
                File.Copy(Application.StartupPath.ToString() + @"\XML\Orders.xml", Application.StartupPath.ToString() + @"\XML\Orders\" + DateTime.Now.ToString("D") + DateTime.Now.ToString("FFFFFFF") + " " + DateTime.Now.ToString("dd") + ".xml");
                string path = Application.StartupPath.ToString() + @"\XML\Orders.xml";
                MessageBox.Show("Receipt printed. Data Saved.");
                if (File.Exists(path))
                {

                    File.Delete(path);
                }

            }
            else
            {
                MessageBox.Show("No data to input!");
            }
        }
    }
}
