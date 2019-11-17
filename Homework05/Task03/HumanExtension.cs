using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    static class HumanExtension
    {
        public static void Evolve(this Human human)
        {
            human.MostImportantBodeParts = BodyParts.Arms;
        }
    }
}
