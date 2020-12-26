using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class TShirt
    {
        Color color;
        Size size;
        Fabric fabric;

        public TShirt(Color c,Size s,Fabric f)
        {
            color = c;
            size = s;
            fabric = f;
        }

        public int Cost()
        {
            var c = (int)color;
            var s = (int)size;
            var f = (int)fabric;

            return c + s + f;
        }
            
    }
}
