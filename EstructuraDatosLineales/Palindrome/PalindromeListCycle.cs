using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatosLineales.Palindrome
{
    internal class PalindromeListCycle
    {

        private static PalindromeNode FindMiddle(PalindromeNode node)
        {
            PalindromeNode lowPointer = node;
            PalindromeNode fastPointer = node;

            while (fastPointer != null && fastPointer.Next != null)
            {
                lowPointer = lowPointer.Next;
                fastPointer = fastPointer.Next.Next;
            }

            return lowPointer;
        }

        // [0] => [1] => [9]
        private static PalindromeNode ReverseList(PalindromeNode node)
        {
            PalindromeNode previous = null;
            PalindromeNode current = node; 

            while (current != null)
            {
                // 1) nextTemp = [1]
                // 2) nextTemp = [9]
                // 3) nextTemp = null
                PalindromeNode nextTemp = current.Next;
                
                // 1) current.Next = null
                // 2) current.Next = [0]
                // 3) current.Nest = [1]
                current.Next = previous; 

                // 1) previous = [0]
                // 2) previous = [1]
                // 3) previous = [9]
                previous = current; 

                // 1) current = [1]
                // 2) current = [9]
                // 3) current = null
                current = nextTemp;
            }

            // in = [0] => [1] => [9]
            // output = 

            /*
                    ITERACION 1:
                    
                    [1] => [0]

                    ITERACION 2:

                    [9] => [1] => [0]
                    
             */

            return current;
        }

        public static bool isPalindrome(PalindromeNode node)
        {
            if (node is null) return false;

            PalindromeNode endFirstBlock = FindMiddle(node);
            PalindromeNode startEndBlock = ReverseList(node);

            bool isPalindrome = true;

            var pointer1 = node;
            var pointer2 = startEndBlock;


        }
    }
}
