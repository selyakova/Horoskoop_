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
                Placeholder = "Введите свой знак зодиака"
            };

            calculateButton = new Button
            {
                Text = "Узнать временной период"
            };
            calculateButton.Clicked += OnCalculateButtonClicked;

            periodLabel = new Label
            {
                Text = "Ваш временной период будет отображен здесь",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "Введите свой знак зодиака:" },
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
            periodLabel.Text = $"Ваш временной период: {period}";
        }

        private string GetZodiacPeriod(string zodiacSign)
        {
            switch (zodiacSign.ToLower())
            {
                case "овен":
                    return "21 марта - 20 апреля";
                case "телец":
                    return "21 апреля - 20 мая";
                case "близнецы":
                    return "21 мая - 20 июня";
                case "рак":
                    return "21 июня - 22 июля";
                case "лев":
                    return "23 июля - 22 августа";
                case "дева":
                    return "23 августа - 22 сентября";
                case "весы":
                    return "23 сентября - 22 октября";
                case "скорпион":
                    return "23 октября - 21 ноября";
                case "стрелец":
                    return "22 ноября - 21 декабря";
                case "козерог":
                    return "22 декабря - 19 января";
                case "водолей":
                    return "20 января - 18 февраля";
                case "рыбы":
                    return "19 февраля - 20 марта";
                default:
                    return "Не удалось определить временной период";
            }
        }
    }
}

