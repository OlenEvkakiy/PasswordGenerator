using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Model
{
    public class ChangeWebSiteName
    {
        private int smallCharPercent;
        private string webSiteName;
        private char[] arrWebsiteName = new char[] { };


        public string Converter(string name)
        {
            webSiteName = name;
            ConverterToChar();
            PercentageCalculation(arrWebsiteName.Length);
            RandomHighChar();
            return ConvertToString();
        }

        private string ConvertToString()
        {
            webSiteName = new string(arrWebsiteName);
            return webSiteName;
        }

        private char[] ConverterToChar()
        {
            arrWebsiteName = webSiteName.ToCharArray();
            return arrWebsiteName;
        }


        private void RandomHighChar()
        {
            Random random = new Random();
            int RandomNumber;


            for (int i = 0; i < smallCharPercent; ++i)
            {
                RandomNumber = random.Next(0, arrWebsiteName.Length);
                arrWebsiteName[RandomNumber] = Char.ToUpper(arrWebsiteName[RandomNumber]);
            }

        }

        private int PercentageCalculation(int numbers)
        {
            double result = numbers * 0.3;
            smallCharPercent = Convert.ToInt32(result);
            return smallCharPercent;
        }
    }
}
