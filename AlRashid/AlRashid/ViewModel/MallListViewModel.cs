using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;
namespace AlRashid.ViewModel
{
    class MallListViewModel
    {

        public IEnumerable<Malls> GetMallList()
        {

            if ("[language]" == Language.lang.english.ToString())
            {
                var malllist = new List<Malls>
            {
               new Malls{Title="ALRASHID MALL MADINA",Description="Madina Mall",IconImageUrl=""},
               new Malls{Title="ALRASHID MALL JIZAN",Description="Jizan Mall",IconImageUrl=""},
               new Malls{Title="ALRASHID MALL ABHA",Description="Abha Mall",IconImageUrl=""}
            };
                return malllist;
            }
            else if ("" == Language.lang.arabic.ToString())
            {
                var malllist = new List<Malls>
            {
               new Malls{Title="شششششششششش",Description="شؤء",IconImageUrl=""},
               new Malls{Title="لالالالالالالالالالا",Description="شلار",IconImageUrl=""},
               new Malls{Title="ؤؤؤؤؤؤؤؤؤؤ",Description="شلاري",IconImageUrl=""}
            };
                return malllist;
            }
            else
            {

                var malllist = new List<Malls>
            {
               new Malls{Title="Undefined",Description="Undefine",IconImageUrl=""},
               new Malls{Title="Undefined",Description="Undefine",IconImageUrl=""},
               new Malls{Title="Undefined",Description="Undefine",IconImageUrl=""}
            };
                return malllist;
            }


        }
    }


}
