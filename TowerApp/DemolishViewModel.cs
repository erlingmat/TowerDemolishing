using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace TowerApp
{
   public class DemolishViewModel
    {
        public string InputNumbersText { get; set; }

        public string OutputNumbersText { get; set; }
       private ICommand _zapCommand = null;

       public void zapFunction(Object o)
       {
           OutputNumbersText = "OUTPUT!";
       }

       public ICommand ZapCommand
       {
           get
           {
               if (_zapCommand == null) _zapCommand = new RelayCommand(zapFunction);
               return _zapCommand;
           }
       }
    }
}
