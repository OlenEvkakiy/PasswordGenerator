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
        Generator generatorModel = new();

        private string _webSiteName;
        public string WebSiteName { get => _webSiteName; set => Set(ref _webSiteName, value); }

        private string _keyLenght;
        public string KeyLenght { get => _keyLenght; set => Set(ref _keyLenght, value); }

        private string _numberOfBlocks;
        public string NumberOfBlocks { get => _numberOfBlocks; set => Set(ref _numberOfBlocks, value); }

        private string _result;
        public string Result { get => _result; set => Set(ref _result, value); }

        generatorModel.



    }
}
