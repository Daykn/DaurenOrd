using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexserialization
{
    [Serializable]
    class complex
    {
        public int x, y;

        public complex(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x +" "+ y;
        }
    }
}
