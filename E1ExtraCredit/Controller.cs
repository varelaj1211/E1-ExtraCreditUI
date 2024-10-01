using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E1ExtraCredit
{
    public class Controller
    {
        private LibraryModel model;

        private delegate void UpdateLibrary(List<SerialNum> books);

        public Controller(LibraryModel m)
        {
            model = m;
        }

        public void GoToPgHandler(int page)
        { 
        
        }


        public void NextPgHandler()
        { 
        
        }
        public void PrevPgHandler()
        { 
        
        }


        public void GetBMHandler(int page)
        { 
        
        }
        public void RemoveBMHandler(int page)
        { 
        
        }
        public void SelectBMHandler(SerialNum serialNum)
        { 
        
        }

        public void SetUpdateLibrary(UpdateLibrary m)
        { 
        
        }


    }
}
