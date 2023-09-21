using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace WpfAppToolBar.Pages
{
 
    public partial class Vorbereitungskosten : Page
    {

        public Vorbereitungskosten(string gewichtText)
        {
            InitializeComponent();

            if (int.TryParse(gewichtText, out int laufmeter))
            {
                string zuschwer;

                if (laufmeter >= 500)
                {
                    zuschwer = "Die Eingaben wurden überprüft. Die Laufmeter des Bauteils sind zu schwer für die Produktion!";
                }
                else
                {
                    zuschwer = "Die Eingaben wurden überprüft. Die Laufmeter des Bauteils können durch die Produktion abgedeckt werden";
                }

                txt_boxVorbereitungoben.Text = zuschwer;
            }
            else
            {
                // Fehlerbehandlung, wenn die Eingabe in der Textbox "Gewicht" keine gültige Zahl ist
                MessageBox.Show("Bitte geben Sie eine gültige Zahl in das Feld 'Gewicht' ein.");
            }
        }


    }
}
