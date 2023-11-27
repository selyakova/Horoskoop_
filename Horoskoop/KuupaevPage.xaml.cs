using System;
using Xamarin.Forms;

namespace Horoskoop
{
    public class KuupaevPage : ContentPage
    {
        Entry zodiacSignEntry;
        Button calculateButton;
        Label periodLabel;

        public KuupaevPage()
        {
            zodiacSignEntry = new Entry
            {
                Placeholder = "Sisestage oma tähhemärk"
            };

            calculateButton = new Button
            {
                Text = "Uuri välja ajavahemik"
            };
            calculateButton.Clicked += OnCalculateButtonClicked;

            periodLabel = new Label
            {
                Text = "Teie ajavahemik kuvatakse siin",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "Sisestage oma sodiaagimärk:" },
                    zodiacSignEntry,
                    calculateButton,
                    periodLabel
                }
            };
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            string inputZodiacSign = zodiacSignEntry.Text.Trim();
            string period = GetZodiacPeriod(inputZodiacSign);
            periodLabel.Text = $"Teie ajavahemik: {period}";
        }

        private string GetZodiacPeriod(string zodiacSign)
        {
            switch (zodiacSign.ToLower())
            {
                case "jäär":
                    return "Märts 21 - Aprill 19";
                case "sõnn":
                    return "Aprill 20 – Mai 20";
                case "kaksikud":
                    return "Mai 21 – Juuni 21";
                case "vähk":
                    return "Juuni 22 – Juuli 22";
                case "lõvi":
                    return "Juuli 23 – August 22";
                case "neitsi":
                    return "August 23 – September 22";
                case "kaalud":
                    return "September 23 – Oktoober 23";
                case "skorpion":
                    return "Oktoober 24 – November 22";
                case "ambur":
                    return "November 23 – Detsember 21";
                case "kaljukits":
                    return "Detsember 22 – Jaanuar 19";
                case "veevalaja":
                    return "Jaanuar 20 – Veebruar 18";
                case "kalad":
                    return "Veebruar 19 – Märts 20";
                default:
                    return "Ajavahemikku ei olnud võimalik kindlaks määrata";
            }
        }
    }
}

