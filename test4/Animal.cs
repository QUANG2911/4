using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    public class Animal
    {
        public virtual string MakeSoud()
        {
            return "totto";
        }
    }

    class Dog : Animal
    {
        public override string MakeSoud()
        {
            return "gaugau";
        }
    }

    class Cat : Animal
    {
        public override string MakeSoud()
        {
            return "meowmeow";
        }
    }

}
