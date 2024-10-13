using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexEditor
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            tbContenido.Text = "Sr(a) Medina Noemí, El despacho JURÍDICO GUTIERREZ & ASOCIADOS, mediante el";
            tbPatron.Text = "(Sr\\(a\\))([ a-zA-Záéíóú]+)";
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            string contenido = tbContenido.Text;
            string patron=tbPatron.Text;

            

            tbResultado.Text = "";
            Match m=Regex.Match(contenido, patron);

            if(m.Success==false)
                tbResultado.Text = "no hay resultado";

            while (m.Success)
            {
                if (chx.Checked==false)
                {
                    tbResultado.Text = m.Value;
                }
                else
                {                 
                    for(int n=1;n<m.Groups.Count;n++)
                    {
                        tbResultado.Text += m.Groups[n].Value+"\r\n";
                    }
                }
                m = m.NextMatch();
            }
           
            /*
            Regex regex = new Regex(contenido, RegexOptions.IgnoreCase);

            Match m = regex.Match(patron);
            if (m.Success)
            { 
                m.NextMatch
            }
            */
        }
    }
}
