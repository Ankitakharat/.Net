using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public int Width { get; set; }

        public abstract string Draw();

        

    }
}
