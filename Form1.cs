using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursorToBodyStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.ToolStripItems.Add("Insert Text And Position Cursor").Click += AddText_Click;
        }

        private void AddText_Click(object sender, EventArgs e)
        {
            HtmlElement thePtag = this.htmlEditControl1.InsertHTMLELement("p");
            thePtag.InnerText = "Some text in here";

            this.htmlEditControl1.MoveCursorToElement(thePtag, Zoople.HTMLEditControl.ELEM_ADJ.ELEM_ADJ_BeforeEnd);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.htmlEditControl1.DocumentHTML = "<br/><p>Signature</p><p>Signature</p><p>Signature</p>";
            this.htmlEditControl1.SetFocus();
            this.htmlEditControl1.MoveCursorToElement(this.htmlEditControl1.Document.Body, Zoople.HTMLEditControl.ELEM_ADJ.ELEM_ADJ_AfterBegin);

        }
    }
}
