using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PrioriteaCsharpsharp
{   
    
    public partial class LogIn : Form{
        public LogIn()
        {            
            InitializeComponent();            
        }

        public string FromXML_user = "";
        public string FromXML_pass = "";

//----------------------------------------------------------------------//

        private void button1_Click(object sender, EventArgs e){
            
            logoutbtn f2 = new logoutbtn();
            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Credentials.xml");

            var selected_user = from x in doc.Descendants("credentials").Where
                                (x => (string)x.Element("username") == UsernameField.Text)
                                select new
                                {
                                    XMLusername = x.Element("username").Value,
                                    XMLpassword = x.Element("password").Value
                                };
                    foreach(var x in selected_user)
                    {
                        FromXML_user = x.XMLusername;
                        FromXML_pass = x.XMLpassword;
                    }
            if (UsernameField.Text == "" || PasswordField.Text == "" || SecretCodeField.Text == "")
            {
                error.Text = "ERROR! Please fill all prompts.";
                error.Visible = true;
            }
            else if (FromXML_user == UsernameField.Text && FromXML_pass == PasswordField.Text && SecretCodeField.Text == "qualitea")
            {
                if (File.Exists(Directory.GetCurrentDirectory() + @"\XML\tempcreds.xml") != true)
                {
                    string csooser = Convert.ToString(UsernameField.Text);

                    XmlDocument xdoc1 = new XmlDocument();
                    string path = Directory.GetCurrentDirectory() + @"\XML\tempcreds.xml";
                    XDocument xdoctemp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                              new XElement("Credenstemp"));
                    xdoctemp.Save(path);
                    xdoc1.Load(path);

                    XmlNode creds = xdoc1.CreateElement("creds");

                    XmlNode ooser = xdoc1.CreateElement("user");
                    ooser.InnerText = csooser.ToString();
                    creds.AppendChild(ooser);

                    xdoc1.DocumentElement.AppendChild(creds);

                    xdoc1.Save(path);

                    this.Hide();
                    f2.ShowDialog();
                }
                else
                {
                    File.Delete(Directory.GetCurrentDirectory() + @"\XML\tempcreds.xml");

                    string csooser = Convert.ToString(UsernameField.Text);

                    XmlDocument xdoc1 = new XmlDocument();
                    string path = Directory.GetCurrentDirectory() + @"\XML\tempcreds.xml";
                    XDocument xdoctemp = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                              new XElement("Credenstemp"));
                    xdoctemp.Save(path);
                    xdoc1.Load(path);

                    XmlNode creds = xdoc1.CreateElement("creds");

                    XmlNode ooser = xdoc1.CreateElement("user");
                    ooser.InnerText = csooser.ToString();
                    creds.AppendChild(ooser);

                    xdoc1.DocumentElement.AppendChild(creds);

                    xdoc1.Save(path);

                    this.Hide();
                    f2.ShowDialog();
                }
            }
            else
            {
                error.Text = " One of the prompts is/are\nincorrect Please try again!";
                UsernameField.Text = "";
                PasswordField.Text = "";
                SecretCodeField.Text = "";
                error.Visible = true;
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Credentials.xml");

            var selected_user = from x in doc.Descendants("credentials").Where
                             (x => (string)x.Element("username") == UsernameField.Text)
                                select new
                                {
                                    XMLusername = x.Element("username").Value,
                                    XMLpassword = x.Element("password").Value
                                };
            foreach (var x in selected_user)
            {
                FromXML_user = x.XMLusername;
                FromXML_pass = x.XMLpassword;
            }
            if (UsernameField.Text == "" || PasswordField.Text == "" || PasswordField.Text == "")
            {
                error.Text = "ERROR! Please fill all prompts.";
                error.Visible = true;
            }
            else if (UsernameField.Text != "" || PasswordField.Text != "" || PasswordField.Text == "qualitea")
            {
                if (FromXML_user == UsernameField.Text)
                {
                    error.Text = "ERROR! User is already registered";
                    error.Visible = true;
                }
                else
                {
                    string csusername = Convert.ToString(UsernameField.Text);
                    string cspassword = Convert.ToString(PasswordField.Text);

                    XmlDocument xdoc1 = new XmlDocument();

                    string path = Directory.GetCurrentDirectory() + @"\XML\Credentials.xml";
                    xdoc1.Load(path);
                    XmlNode credentials = xdoc1.CreateElement("credentials");

                    XmlNode username = xdoc1.CreateElement("username");
                    username.InnerText = csusername.ToString();
                    credentials.AppendChild(username);

                    XmlNode password = xdoc1.CreateElement("password");
                    password.InnerText = cspassword.ToString();
                    credentials.AppendChild(password);
                    xdoc1.DocumentElement.AppendChild(credentials);

                    xdoc1.Save(path);

                    error.Text = "   User added successfuly!";
                    error.Visible = true;
                }
            }
         }
        private void enterbtn_Click(object sender, EventArgs e)
        {
            string csusername = Convert.ToString(UsernameField.Text);
            string cspassword = Convert.ToString(PasswordField.Text);
            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Credentials.xml");
            XDocument xdoc1 = XDocument.Load(Application.StartupPath.ToString() + @"\XML\Credentials.xml");
            

            var selected_user = from x in doc.Descendants("credentials").Where
                           (x => (string)x.Element("username") == olduser.Text)
                                select new
                                {
                                    XMLusername = x.Element("username").Value,
                                    XMLpassword = x.Element("password").Value
                                };

            var queryxml = xdoc1.Descendants()?.Elements("username")?.
                                Where(x => x.Value == olduser.Text)?.Ancestors("credentials");
            var changeuser = queryxml.Elements("username").FirstOrDefault();
            var changepass = queryxml.Elements("password").FirstOrDefault();

            foreach (var x in selected_user)
            {
                FromXML_user = x.XMLusername;
                FromXML_pass = x.XMLpassword;
            }
            if (newuser.Text == "" || newpass.Text == "" || olduser.Text == "" || oldpass.Text == "")
            {

                error.Text = "No input found \n Please try again!";
                error.Visible = true;
            }else if (FromXML_user == newuser.Text)
            {
                error.Text = "That username is already taken!";
                error.Visible = true;
            }
            else if (FromXML_user == olduser.Text && FromXML_pass == oldpass.Text)
            {
                if (changepass != null)
                {
                    changeuser.Value = newuser.Text;
                    changepass.Value = newpass.Text;                    

                    xdoc1.Save(Application.StartupPath.ToString() + @"\XML\Credentials.xml");

                    error.Visible = true;
                    error.Text = "          Username/Password \n         Successfully changed!";
                    newuser.Text = "";
                    newpass.Text = "";
                    olduser.Text = "";
                    oldpass.Text = "";
                }
                    
            }
            else
            {
                error.Text = "Username/Password is incorrect \n Please try again!";
                error.Visible = true;
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            UsernameField.Location = new System.Drawing.Point(11,UsernameField.Location.Y);
            PasswordField.Location = new System.Drawing.Point(11,PasswordField.Location.Y);
            SecretCodeField.Location = new System.Drawing.Point(11, SecretCodeField.Location.Y);
            Useless1.Location = new System.Drawing.Point(57,Useless1.Location.Y);
            Useless2.Location = new System.Drawing.Point(57,Useless2.Location.Y);       
            secretcodelbl.Location = new System.Drawing.Point(33,secretcodelbl.Location.Y);
            LogInCheckbtn.Location = new System.Drawing.Point(11,LogInCheckbtn.Location.Y);
            signupbtn.Location = new System.Drawing.Point(85, LogInCheckbtn.Location.Y);
            enterbtn.Visible = true;
            lastuserlbl.Visible = true;
            lastpasslbl.Visible = true;
            newuserlbl.Visible=true;
            newpasslbl.Visible=true;
            secretcodelbl.Visible = true;
            olduser.Visible = true;
            oldpass.Visible = true;
            newuser.Visible = true;
            newpass.Visible = true;         
        }    

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.ToString() + @"\XML\Orders.xml";
            if (File.Exists(path))
            {

                File.Delete(path);
            }
            
        }
    }
}
