using PasswordGenerator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Model
{
    public class Generator:BaseViewModel
    {
        private string _webSiteName = "lol";
        public string WebSiteName { get => _webSiteName; set => Set(ref _webSiteName, value); }

        private int _keyLenght = 3;
        public int KeyLenght { get => _keyLenght; set => Set(ref _keyLenght, value); }

        private int _numberOfBlocks = 3;
        public int NumberOfBlocks { get => _numberOfBlocks; set => Set(ref _numberOfBlocks, value); }

        private string _result;
        public string Result { get => _result; set => Set(ref _result, value); }

       // MainPageViewModel mainPageViewModel= new MainPageViewModel();
        ChangeWebSiteName changeWebSiteName = new ChangeWebSiteName();
        string [] RandomFillingOfBlocks;
        //int KeyLenght;
        string bufferOne;
        string bufferTwo;
        //int NumberOfBlocks;
        //string WebSiteName;
        //string GeneratorOutput;
        string iPass = "";
        string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B",
                            "C", "D", "F", "G", "H", "J", "K", "L", "M", "N",
                            "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b",
                            "c", "d", "f", "g", "h", "j", "k", "m", "n", "p",
                            "q", "r", "s", "t", "v", "w", "x", "z", "A", "E",
                            "U", "Y", "a", "e", "i", "o", "u", "y" };

        public void MethodCaller()
        {
            GetWebSiteName();
            GetKeyLenght();
            GetBlocksLenght();
            GeneratePass();
            NameBlender();
            OutputValueBlender();
        }

        //string BAZA()
        //{
        //    
        //    RandomFillingOfBlocks = new string[NumberOfBlocks];
        //}



        void NameBlender()
        {

            Random random = new Random();

            int RandomChoose = random.Next(0, NumberOfBlocks);


            //алгоритм случайным образом впихивающий переменную WebSiteName
            for (int l = RandomChoose - 1; l < RandomChoose; l++)
            {
                RandomFillingOfBlocks[RandomChoose] = WebSiteName;
            }

        }


        //через цикл фор выводим значения массива после блендинга
        void OutputValueBlender()
        {

            for (int i = 0; i < RandomFillingOfBlocks.Length; i++)
            {
                bufferOne = RandomFillingOfBlocks[i];
                bufferTwo = bufferTwo + bufferOne;

            }
            Result = bufferTwo;
        }


        //получаем название сайта
        void GetWebSiteName()
        {
            
            WebSiteName = WebSiteName;
            WebSiteName = changeWebSiteName.Converter(WebSiteName);
        }

        void GetKeyLenght()
        {
           
            KeyLenght = Convert.ToInt32(KeyLenght);
        }

        void GetBlocksLenght()
        {
            NumberOfBlocks = Convert.ToInt32(NumberOfBlocks);
            RandomFillingOfBlocks = new string[NumberOfBlocks];

        }



        //генерируем случайные символы для блока пароля
        void GeneratePass()
        {
            Random rnd = new Random();
            for (int i = 0; i <= NumberOfBlocks - 1; i++)
            {
                for (int j = 0; j < KeyLenght; j++)
                {
                    iPass = iPass + arr[rnd.Next(0, arr.Length)];

                }
                RandomFillingOfBlocks[i] = iPass;
                iPass = null;
            }



        }

    }
}
