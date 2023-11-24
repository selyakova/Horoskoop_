using System;
using Xamarin.Forms;

namespace Horoskoop
{
    public class TahemarkPage : ContentPage
    {
        DatePicker datePicker;
        Button calculateButton;
        Label resultLabel;

        public TahemarkPage()
        {
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now
            };

            calculateButton = new Button
            {
                Text = "Узнать знак зодиака"
            };
            calculateButton.Clicked += OnCalculateButtonClicked;

            resultLabel = new Label
            {
                Text = "Ваш знак зодиака будет отображен здесь",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "Выберите дату рождения:" },
                    datePicker,
                    calculateButton,
                    resultLabel
                }
            };
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Date;
            string zodiacSign = KirjutaTahemark(selectedDate);
            resultLabel.Text = $"Ваш знак зодиака: {zodiacSign}";
        }


        private string KirjutaTahemark(DateTime date)
        {
            if ((date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 19))
            {
                return "Овен";
            }
            else if ((date.Month == 4 && date.Day >= 20) || (date.Month == 5 && date.Day <= 20))
            {
                return "Телец";
            }
            else if ((date.Month == 5 && date.Day >= 21) || (date.Month == 6 && date.Day <= 20))
            {
                return "Близнецы";
            }
            else if ((date.Month == 6 && date.Day >= 21) || (date.Month == 7 && date.Day <= 22))
            {
                return "Рак";
            }
            else if ((date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 22))
            {
                return "Лев";
            }
            else if ((date.Month == 8 && date.Day >= 23) || (date.Month == 9 && date.Day <= 22))
            {
                return "Дева";
            }
            else if ((date.Month == 9 && date.Day >= 23) || (date.Month == 10 && date.Day <= 22))
            {
                return "Весы";
            }
            else if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 21))
            {
                return "Скорпион";
            }
            else if ((date.Month == 11 && date.Day >= 22) || (date.Month == 12 && date.Day <= 21))
            {
                return "Стрелец";
            }
            else if ((date.Month == 12 && date.Day >= 22) || (date.Month == 1 && date.Day <= 19))
            {
                return "Козерог";
            }
            else if ((date.Month == 1 && date.Day >= 20) || (date.Month == 2 && date.Day <= 18))
            {
                return "Водолей";
            }
            else if ((date.Month == 2 && date.Day >= 19) || (date.Month == 3 && date.Day <= 20))
            {
                return "Рыбы";
            }

            return "Не удалось определить знак зодиака";
        }

    }
}
