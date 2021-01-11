using EierfarmBl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EierfarmUiClassic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            Huhn huhn = new Huhn("Neues Huhn");

            huhn.EigenschaftGeaendert += Tier_EigenschaftGeaendert;

            cbxTiere.Items.Add(huhn);
            cbxTiere.SelectedItem = huhn;

        }

        private void Tier_EigenschaftGeaendert(object sender, GefluegelEventArgs e)
        {
            //string a = "Hallo";
            //string b = "Welt";

            //string c = a + " " + b;

            //StringBuilder sb = new StringBuilder(a);
            //sb.Append(" ");
            //sb.Append(b);

            //string d = sb.ToString();

            //MessageBox.Show($"Tier {(sender as Gefluegel).Name} hat Eigenschaft {e.GeaenderteProperty} geändert.");

            pgdTier.SelectedObject = sender;

        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            IFresser gefluegel = cbxTiere.SelectedItem as IFresser; // SaveCast, liefert null, wenn Cast fehlschlägt

            if (gefluegel != null)
            {
                gefluegel.Fressen();
            }
        }

        private void btnEiLegen_Click(object sender, EventArgs e)
        {
            if (cbxTiere.SelectedItem is IEiLeger gefluegel)
            {
                gefluegel.EiLegen();
            }

        }

        private void cbxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTiere.SelectedItem;
        }

        private void btnSchnabeltier_Click(object sender, EventArgs e)
        {
            Schnabeltier schnabeltier = new Schnabeltier();
            schnabeltier.Gewicht = 2000;

            schnabeltier.EigenschaftGeaendert += Tier_EigenschaftGeaendert;

            cbxTiere.Items.Add(schnabeltier);
            cbxTiere.SelectedItem = schnabeltier;

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // Benutzer nach Speicherort fragen
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                RestoreDirectory = true,
                Filter = "Hühner|*.hn|Schnabeltiere|*.st|Alles|*.*",
                FilterIndex = 0
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tier dort speichern
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    XmlSerializer serializer = new XmlSerializer(cbxTiere.SelectedItem.GetType());
                    serializer.Serialize(writer, cbxTiere.SelectedItem);
                }

                MessageBox.Show("Tier erfolgreich gespeichert.");
            }
        }
    }
}
