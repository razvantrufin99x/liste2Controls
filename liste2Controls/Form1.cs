using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste2Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ListOfStrings los = new ListOfStrings();
        public ListOfStrings los2 = new ListOfStrings();
        public ListOfStrings los3 = new ListOfStrings();
        public ListOfStrings los4 = new ListOfStrings();
        public ListOfStrings los5 = new ListOfStrings();
        public ListOfStrings los6 = new ListOfStrings();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToString();
            for (int i = 0; i < 10; i++) los.addStrings(DateTime.Now.Millisecond.ToString());
            los.printListToForm(this);

            for (int i = 0; i < 10; i++) los2.addStrings(DateTime.Now.Millisecond.ToString());
            los2.positiony += 20;
            los2.printListToForm(this);

            for (int i = 0; i < 10; i++) los3.addStrings(DateTime.Now.Millisecond.ToString());
            los3.positiony += 40;
            los3.printListToForm(this);

            for (int i = 0; i < 10; i++) los4.addStrings(DateTime.Now.Millisecond.ToString());
            los4.positiony += 60;
            los4.printListToForm(this);

            for (int i = 0; i < 10; i++) los5.addStrings(DateTime.Now.Millisecond.ToString());
            los5.positiony += 80;
            los5.printListToForm(this);

            for (int i = 0; i < 10; i++) los6.addStrings(DateTime.Now.Millisecond.ToString());
            los6.positiony += 100;
            los6.printListToForm(this);
        }
    }
}
