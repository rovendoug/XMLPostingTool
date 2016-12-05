using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace XMLPostForm {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();            
            cboTestAdfXml.DataSource = GenerateTestADF();
            cboTestAdfXml.DisplayMember = "Text";
            cboTestAdfXml.SelectedIndex = 0;

            cboEnvironmentSelection.DataSource = PopulatePOSTUrl();
            cboEnvironmentSelection.DisplayMember = "Text";
            cboEnvironmentSelection.SelectedIndex = 0;
        }

        public class MyPolicy : ICertificatePolicy {
            public bool CheckValidationResult(
                  ServicePoint srvPoint
                , X509Certificate certificate
                , WebRequest request
                , int certificateProblem) {

                //Return True to force the certificate to be accepted.
                return true;

            } // end CheckValidationResult
        } // class MyPolicy        

        private void btnPostADFXMLLocal_Click(object sender, EventArgs e) {
            string adfXML = txtAdfXml.Text;
            string txtResponse = "";
            string postURL = cboEnvironmentSelection.Text;

            WebRequest request = null;
            WebResponse response = null;

            try {

                request = WebRequest.Create(postURL);
                request.Method = "POST";
                request.ContentType = "text/xml";

                StreamWriter writer = new StreamWriter(request.GetRequestStream());

                writer.WriteLine(adfXML);

                writer.Close();

                response = request.GetResponse();
                txtResponse = "XML Sent as " + adfXML;

                MessageBox.Show(txtResponse);

                StreamReader xmlResponse = new StreamReader(response.GetResponseStream());
                string xmlResponseParsed = xmlResponse.ReadToEnd();
                txtResponse = xmlResponseParsed;
            } catch (Exception ex) {
                txtResponse = ex.Message;
                txtResponse += "\n" + ex.StackTrace.ToString();
            } finally {
                if (request != null) {
                    request.GetRequestStream().Close();
                }
                if (response != null) {
                    response.GetResponseStream().Close();
                }
            }
            MessageBox.Show(txtResponse);
        }

        private void cboTestAdfXml_SelectedIndexChanged(object sender, EventArgs e) {
            ListViewItem item = cboTestAdfXml.SelectedItem as ListViewItem;
            txtAdfXml.Text = item.ImageKey;
        }

        public List<ListViewItem> GenerateTestADF() {
            List<ListViewItem> objTestADFXML = new List<ListViewItem>();
            objTestADFXML.Add(new ListViewItem("Please select a Test ADF to POST", "Or Input your own here!"));
            ResourceManager manager = new ResourceManager(typeof(TestADFXml));
            ResXResourceReader reader = new ResXResourceReader(ConfigurationManager.AppSettings["ADFXMLResource"].ToString());
            reader.UseResXDataNodes = true;
            IDictionaryEnumerator dict = reader.GetEnumerator();
            while (dict.MoveNext()) {
                ResXDataNode node = (ResXDataNode)dict.Value;
                objTestADFXML.Add(new ListViewItem(node.Comment, manager.GetString(node.Name)));
            }
            return objTestADFXML;
        }

        public List<ListViewItem> PopulatePOSTUrl() {
            List<ListViewItem> lstPOSTUrl = new List<ListViewItem>();
            lstPOSTUrl.Add(new ListViewItem("http://kohdevelopment.com/ADFXMLVerification"));
            return lstPOSTUrl;
        }
    }
}