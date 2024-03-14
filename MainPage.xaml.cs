using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization.DateTimeFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace Age2minutes
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // Funzione per calcolare l'età in mesi, giorni, ore, minuti e secondi
            void Button_Click(object sender, RoutedEventArgs e)
            {
            new DateTimeFormatter("longdate").Format(DateTime.Now);
            DateTime dateTime = DateTime.Now;
            new BinaryReader(new MemoryStream());
            DateTime birthdate = BirthdatePicker.Date.DateTime;

            // Funzione per Convertire datepicker in datetime
            
            TimeSpan timeSpan = dateTime - birthdate;
            TimeSpan difference = timeSpan;

            int months = Convert.ToInt32(difference.TotalDays / 30);
            int days = Convert.ToInt32(timeSpan.TotalDays);
            int minutes = Convert.ToInt32(timeSpan.TotalMinutes);
            int hours = Convert.ToInt32(timeSpan.TotalHours);
            long seconds = Convert.ToInt64(timeSpan.TotalSeconds);

            ResultTextBox.Text = ("you have a..     " + months + "   months   " + days + "   days   " + hours + "   hours   " + minutes + "   minutes   " + seconds + "   second                !!!!!");
            }

        // Funzione per aprire una finestra di stampa per i risultati
        void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();

        }
        // Funzione per cancellare i dati

        void Button_Click_3(object sender, RoutedEventArgs e)

        {
            ResultTextBox.Text = "";
            
        }

        void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Funzione per chiudere l'applicazione
            Application.Current.Exit();
        }
        private void TextBox_Text(object sender, TextChangedEventArgs e)
        {
         // Funzione per controllare che l'età sia un numero
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                if (text.Length > 0)
                {
                    int value = int.Parse(text);
                    if (value < 0)
                    {
                        textBox.Text = "0";
                    }
                    else if (value > 120)
                    {
                        textBox.Text = "120";
                    }
                }
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}