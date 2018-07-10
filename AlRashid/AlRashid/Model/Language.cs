using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AlRashid
{
    public class Language
    {
      [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string SelectedLanguage { get; set; }


        public  enum lang
        {
            english,arabic
        }

    }
   
}
