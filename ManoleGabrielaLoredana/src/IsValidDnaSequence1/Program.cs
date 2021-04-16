using System;

namespace IsValidDnaSequence1
{

    public class Program
    {
        public static bool VerificationDNA(string text)
        {
            if (text.Length != 1000) return false;
            char[] tochar = text.ToCharArray();
            int i;
            for (i = 0; i < text.Length; i++) if (tochar[i] != 'A' && tochar[i] != 'G' && tochar[i] != 'C' && tochar[i] != 'T') return false;
            return true;
        }

    }
}
