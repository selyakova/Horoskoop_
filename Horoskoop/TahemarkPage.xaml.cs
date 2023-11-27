using System;
using Xamarin.Forms;

namespace Horoskoop
{
    public class TahemarkPage : ContentPage
    {
        DatePicker datePicker;
        Button calculateButton;
        Label resultLabel;
        Image zodiacImage;

        public TahemarkPage()
        {
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now
            };

            calculateButton = new Button
            {
                Text = "Uuri välja tähemärk"
            };
            calculateButton.Clicked += OnCalculateButtonClicked;

            resultLabel = new Label
            {
                Text = "Teie tähemärk kuvatakse siin",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            zodiacImage = new Image
            {
                Aspect = Aspect.AspectFit, 
                HeightRequest = 100 
            };

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "Valige oma sünnikuupäev:" },
                    datePicker,
                    calculateButton,
                    resultLabel,
                    zodiacImage
                }
            };
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            DateTime selectedDate = datePicker.Date;
            string zodiacSign = KirjutaTahemark(selectedDate);
            resultLabel.Text = $"Teie tähemärk: {zodiacSign}";

            SetZodiacImage(zodiacSign);
        }

        private void SetZodiacImage(string zodiacSign)
        {
            string imageName = $"{zodiacSign.ToLower()}.png";
            zodiacImage.Source = ImageSource.FromFile(imageName);
        }

        private string KirjutaTahemark(DateTime date)
        {
            if ((date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 19))
            {
                return "Jäär - Tugevused: lootusrikas, aktiivne, energiline, aus, mitmekülgne, julge, " +
                    "seiklusjanuline, kirglik, lahke, rõõmsameelne, argumentatiivne, uudishimulik" +
                    "\r\nNõrkused: impulsiivne, naiivne, tahtejõuline, kannatamatu, sõjakas";
            }
            else if ((date.Month == 4 && date.Day >= 20) || (date.Month == 5 && date.Day <= 20))
            {
                return "Sõnn - Tugevused: romantiline, otsustav, loogiline, töökas, tulihingeline, " +
                    "kannatlik, kunstis andekas, järjepidev, lahke\r\nNõrkused: eelarvamuslik, sõltuv, " +
                    "kangekaelne";
            }
            else if ((date.Month == 5 && date.Day >= 21) || (date.Month == 6 && date.Day <= 20))
            {
                return "Kaksikud - Tugevused: mitmekesine, tähelepanelik, tark, rõõmsameelne, " +
                    "kiire taibuga, armulik, veetlev\r\nNõrkused: tujukas, tagarääkija";
            }
            else if ((date.Month == 6 && date.Day >= 21) || (date.Month == 7 && date.Day <= 22))
            {
                return "Vähk - Tugevused: tugev kuues meel, subjektiivne, õrn, kiire, " +
                    "hea kujutlusvõimega, hoolikas, pühendunud, vastupidav, lahke, hooliv" +
                    "\r\nNõrkused: ahne, omastav, sensitiivne, peenutsev";
            }
            else if ((date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 22))
            {
                return "Lõvi - Tugevused: uhke, lahke, mõtlik, lojaalne, entusistlik" +
                    "\r\nNõrkused: ennast täis, uhke, järeleandlik, raiskav, kangekaelne, endaga rahulolev";
            }
            else if ((date.Month == 8 && date.Day >= 23) || (date.Month == 9 && date.Day <= 22))
            {
                return "Neitsi - Tugevused: abivalmis, elegantne, perfektsionist, tagasihoidlik, " +
                    "praktiline, selge mõtlemisega\r\nNõrkused: valiv, uudishimulik, ahistav";
            }
            else if ((date.Month == 9 && date.Day >= 23) || (date.Month == 10 && date.Day <= 22))
            {
                return "Kaalud - Tugevused: idealistlik, õiglane, tugev suhtleja, esteetiline, " +
                    "veetlev, kunstlik, ilus, hea südamega\r\nNõrkused: kõhklev, ennast imetlev, laisk, " +
                    "hoolimatu, hooletu";
            }
            else if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 21))
            {
                return "Skorpion - Tugevused: müstiline, ratsionaalne, intelligentne, iseseisev, " +
                    "vaistlik, pühendunud, läbinägelik, veetlev, mõistlik\r\nNõrkused: ei usalda, " +
                    "fanaatiline, keeruline, omastav, ennast täis, ekstreemne, tahtejõuline";
            }
            else if ((date.Month == 11 && date.Day >= 22) || (date.Month == 12 && date.Day <= 21))
            {
                return "Ambur - Tugevused: taiplik, ratsionaalne, julge, ilus, elav, armas, " +
                    "optimistlik\r\nNõrkused: unustav, hooletu, tormakas";
            }
            else if ((date.Month == 12 && date.Day >= 22) || (date.Month == 1 && date.Day <= 19))
            {
                return "Kaljukits - Tugevused: eeskujulik, intelligent, praktiline, ustav, tähelepanelik, " +
                    "lahke, optimistlik, armas, järjepidev\r\nNõrkused: jonnakas, üksik, kahtlustav";
            }
            else if ((date.Month == 1 && date.Day >= 20) || (date.Month == 2 && date.Day <= 18))
            {
                return "Veevalaja - Tugevused: originaalne, tolerantne, rahulik, sõbralik, lahke, " +
                    "iseseisev, tark, praktiline\r\nNõrkused: muutuv, ei allu autoriteedile, liberaalne, " +
                    "ruttav, mässav";
            }
            else if ((date.Month == 2 && date.Day >= 19) || (date.Month == 3 && date.Day <= 20))
            {
                return "Kalad - Tugevused: teadlik, esteetiline, platooniline, pühendunud, lahke, " +
                    "rahulik meelelaad\r\nNõrkused: retsessiivne, sentimentaalne, otsustusvõimetu, " +
                    "ebarealistlik";
            }

            return "Ei suutnud tähemärki kindlaks teha";
        }

    }
}
