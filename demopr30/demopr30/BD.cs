using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopr30
{
    internal class BD
    {
        private static demkapr30Entities _db;
        public static demkapr30Entities db
        {
            get
            {
                if (_db == null)
                    _db = new demkapr30Entities();
                return _db; //привязка бд к wpf
            }
        }
    }
}
