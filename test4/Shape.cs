using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Shape
    {
        private float canh;

        public float Canh { get => canh; set => canh = value; }
    }

    class Cricle : Shape
    {
        public float dienTichHinhTron()
        {
            return (float)(Canh * Canh * 3.14);
        }

    }

}
