using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{

    class Movie : IComparable
    {
        private string _title;
        private string _category;
        public Movie(string title, string category)
        {

        _title = title;
        _category = category;
    
        }
        public string GetGenre()
        {
            return _category;
        }

        public string GetTitle()
        {
            return _title;
        }
        public int CompareTo(object obj)
        {
            //compare the title of the incoming object with 'this' object
           return this._title.CompareTo(((Movie)obj)._title);
           
        }
    }
}
