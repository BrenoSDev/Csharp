using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    public static class Forca
    {
        public static string CriarBoneco(int erros)
        {
            string bonecoForca = "X     :     V";
            bonecoForca += "X     :     V";
            bonecoForca += erros >= 1 ? "X    O     V" : "X";
            if (erros == 2)
            {
                bonecoForca += "       |     V";
            } else if (erros == 3)
            {
                bonecoForca += "      \\|    V";
            } else if (erros >= 4)
            {
                bonecoForca += "      \\|/    V";
            }

            if (erros == 5)
            {
                bonecoForca += "      /      V";
            } else if (erros == 6)
            {
                bonecoForca += "      / \\    V";
            }
            return bonecoForca;
        }
    }
}
