using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_TAM.structure
{
    public static class TAMSorter
    {
        private static void Swap(ref char[] TAMUK, int i, int j)
        {
            // Save index i element to temp and make the swap
            char temp = TAMUK[i];
            TAMUK[i] = TAMUK[j];
            TAMUK[j] = temp;
        }

        public static string Sort_TAM(char[] TAMUK)
        {
            // Initialize local variables
            int length = TAMUK.Length;
            int index = 0;

            // In case if the input string is just a
            // single letter, return the same and
            // don't run the loop
            if (length > 1)
            {
                // Iterate over the char array and swap the
                // elements in same char array to sort
                while (index < length)
                {
                    // If the char is T
                    if (TAMUK[index] == 'T')
                    {
                        // Run the below loop only if T is not at the
                        // starting index
                        if (index > 0)
                        {
                            // Swap the elements till the starting index
                            // to bring the T to front of array
                            for (int i = index; i > 0; i--)
                            {
                                TAMSorter.Swap(ref TAMUK, i, i - 1);
                            }
                        }

                        // Shift the focus on next index
                        index += 1;
                    }
                    //  If the char is M
                    else if (TAMUK[index] == 'M')
                    {
                        // Swap the elements to the last index
                        // to bring the M to end of array
                        for (int j = index; j < TAMUK.Length - 1; j++)
                        {
                            TAMSorter.Swap(ref TAMUK, j, j + 1);
                        }

                        // Do not shift the focus to next index and
                        // reduce the length, so that the M's that
                        // are already evaluated won't be evaluated
                        // again
                        length -= 1;
                    }
                    // If the char is A
                    else
                    {
                        // Just shift the focus to next index
                        index += 1;
                    }
                }
            }

            return new string(TAMUK);
        }
    }
}
