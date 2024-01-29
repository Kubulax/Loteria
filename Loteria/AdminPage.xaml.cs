using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Diagnostics;
using Loteria.Classes;

namespace Loteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }


        void SendMail(string receiver, string title, string description)
        {
            MailMessage message = new MailMessage("loteriaJK@outlook.com", receiver, title, description);
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("loteriaJK@outlook.com", "loteria12345");
            client.UseDefaultCredentials = false;
            client.Send(message);
        }

        private void Draw(object sender, EventArgs e)
        {
            int winsCounter = 0;
            Random rand = new Random();
            string result = "";
            for (int i = 0; i < 9; i++)
            {
                result += rand.Next(0, 10);
            }

            List<Player> playersList = App.DataBase.ReadObjects<Player>();
            foreach (Player player in playersList)
            {
                if (player.Code == result)
                {
                    SendMail(player.Email, "Gratuluję wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                    winsCounter++;
                }
            }

            Score score = new Score(DateTime.Now, result, winsCounter);
            App.DataBase.SaveObject(score);
            lotteryDate.Text = "Data losowania: " + score.LotteryDate.ToString();
            numberOfWins.Text = "Ilosc wygranych: " + winsCounter.ToString();
            winningCode.Text = "Wygrany code: " + result;
        }

        private void EverybodyWins(object sender, EventArgs e)
        {
            int winsCounter = 0;
            string result = "Każdy wygrywa";

            List<Player> playersList = App.DataBase.ReadObjects<Player>();
            foreach (Player player in playersList)
            {
                SendMail(player.Email, "Gratuluję wygranej!", "Proszę o kontakt pod adresem Limanowa 22. \nPozdrawiamy zespół lotto.");
                winsCounter++;
            }

            Score score = new Score(DateTime.Now, result, winsCounter);
            App.DataBase.SaveObject(score);
            lotteryDate.Text = "Data losowania: " + score.LotteryDate.ToString();
            numberOfWins.Text = "Ilość wygranych: " + winsCounter.ToString();
            winningCode.Text = "Wygrany kod: " + result;
        }
    }
}