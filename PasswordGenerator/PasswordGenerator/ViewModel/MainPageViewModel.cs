using PasswordGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.ViewModel
{

    public class MainPageViewModel : BaseViewModel
    {
        Generator generatorModel = new Generator();

        private string _webSiteName;
        public string WebSiteName
        {
            get => generatorModel.WebSiteName;
            set 
            { 
                Set(ref _webSiteName, value);
                WebSiteName = _webSiteName; 
            }
        }

        private int _keyLenght;
        public int KeyLenght { get => generatorModel.KeyLenght; set => Set(ref _keyLenght, value); }

        private int _numberOfBlocks;
        public int NumberOfBlocks { get => generatorModel.NumberOfBlocks; set => Set(ref _numberOfBlocks, value); }

        private string _result;
        public string Result { get => generatorModel.Result; set => Set(ref _result, value); }

        public void Shit()
        {
            WebSiteName = _webSiteName;
            KeyLenght = _keyLenght;
            NumberOfBlocks = _numberOfBlocks;
            Result = _result;
        }     

    }
}
