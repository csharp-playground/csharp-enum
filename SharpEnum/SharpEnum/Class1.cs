using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEnum
{
    public enum Letter { A, B }

    class Test
    {
        public String CheckEnum(bool input)
        {
            switch (input)
            {
                case true: return "Yes";
                case false:  return "No";
            }

            return "No";
        }
        public String GetValue1(Letter a)
        {
            if (a == Letter.A) return "a";
            else if (a == Letter.B) return "b";
            return "";
        }

        public String GetValue2(Letter a)
        {
            switch (a)
            {
                case Letter.A:
                    return "a";
                case Letter.B:
                    return "b";
                default:
                    return "z";
            }
        }

        public void ShouldCover()
        {
            var a = Letter.A;
            var b = Letter.B;
            var d = (Letter)100;
            var e = (Letter)200;
            var f = (Letter)300;
        }
    }
}
