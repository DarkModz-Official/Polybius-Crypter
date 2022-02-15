using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matriz;


namespace Polybius_DeCrypt
{
    public partial class Form1 : Form
    {

        public string UserKeyword;
        public string UserText;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetVariable(){
            string UserKeywordTemp;
            string UserTextTemp;

            UserKeywordTemp = tB_Keyword.Text.ToString();   
            UserKeyword = UserKeywordTemp.ToUpper();
            // Keyword Variable aus TextBox auslesen und zum String umwandeln und temporär speichern
            // Temporäre KeyWord Variable in CAPS umwandeln!
            // Beispiel:
            // Eingabe = "HalloWelt"
            // Ausgabe = "HALLOWELT"

            UserTextTemp = tB_Input.Text.ToString();        
            UserText = UserTextTemp.ToUpper();

            // Text aus TextBox auslesen und zum String umwandeln und temporär speichern
            // Text in CAPS umwandeln!
            // Beispiel:
            // Eingabe: "Hallo Mein Name ist Gandalf"
            // Ausgabe: "HALLO MEIN NAME IST GANDALF"

        }

        private void Encrypt(object sender, EventArgs e)    //VerschlüsselButton
        {
            GetVariable(); // Holt die Aktuellen werte der Textboxen
            Matrix matrix = new Matrix(UserKeyword); // Erstellt das Matrix Objekt
            tB_Output.Text = matrix.Encrypt(UserText); // Convertiert und Gibt das Ergebnis aus

        }

        private void Decrypt(object sender, EventArgs e)    //EntschlüsselButton
        {
            GetVariable(); // Holt die Aktuellen werte der Textboxen
            Matrix matrix = new Matrix(UserKeyword); // Erstellt das Matrix Objekt
            tB_Output.Text = matrix.Decrypt(UserText); // Convertiert und Gibt das Ergebnis aus
        }
    }
}
