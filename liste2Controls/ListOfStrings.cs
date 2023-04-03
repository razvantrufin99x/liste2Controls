using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste2Controls
{

    public class ListOfStrings
    {
        public int capacity = 0;
        public List<string> lista = new List<string>();
        public ListOfStrings() { }
        public int positionx = 10;
        public int positiony = 10;
        public void addStrings(string s) { lista.Add(s); capacity++; }
        public string printElementOfLista(int index)
        {
            return lista[index];

        }
        public string printList()
        {
            string s="";
            for (int i = 0; i < capacity; i++)
            {

                s += lista[i];
                s += ",";

            }
            return s;
        }
        public void printListToForm(Form f)
        {
            string s = "";

            int counter = f.Controls.Count;
            for (int i = 0; i < capacity; i++)
            {
                s = lista[i];
                f.Controls.Add(new TextBox());
                  counter++;
                f.Controls[counter-1].Text = s;
                f.Controls[counter-1].Left = positionx * (i + 1) * 10;
                f.Controls[counter-1].Top = positiony ;
             

            }
            
        }

        public string printListToString(Form f)
        {
            string s="";
          
           
            for (int i = 0; i < capacity; i++)
            {

                s += lista[i];
              
               


            }
            return s;
        }
    }































}
