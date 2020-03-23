using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadTest
{
    static class Data
    {
        public static EventHandler ValueChanged = delegate { };
        private static bool _A;
        public static bool A
        {
            get { return _A; }
            set
            {
                _A = value;
                ValueChanged(null, EventArgs.Empty);
            }
        }

    }
}
