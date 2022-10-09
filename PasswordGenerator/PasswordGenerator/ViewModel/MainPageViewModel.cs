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
                generatorModel.WebSiteName = _webSiteName;
            }
        }

        private int _keyLenght;
        public int KeyLenght
        {
            get => generatorModel.KeyLenght;
            set
            {
                Set(ref _keyLenght, value);
                generatorModel.KeyLenght = _keyLenght;
            }
        }

        private int _numberOfBlocks;
        public int NumberOfBlocks
        {
            get => generatorModel.NumberOfBlocks;
            set
            {
                Set(ref _numberOfBlocks, value);
                generatorModel.NumberOfBlocks = _numberOfBlocks;
            }
        }

        private string _result;
        public string Result
        {
            get => generatorModel.Result;
            set
            {
                Set(ref _result, value);
                generatorModel.Result = _result;
            }
        }


        //public void Shit<T>(T field, T value)
        //{
        //    if (Equals(field, value))
        //    {
        //        return;
        //    }
        //    //field = value;
        //    Equals(field);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj != null)
        //    {
        //        return generatorModel.WebSiteName == _webSiteName
        //            && generatorModel.KeyLenght == _keyLenght
        //            && generatorModel.NumberOfBlocks == _numberOfBlocks
        //            && generatorModel.Result == _result;
        //    }
        //    return false;
        //}
    }
}
