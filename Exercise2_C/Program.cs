using System;

namespace Exercise2_C
{
    class Program
    {
        String palindrome;
        public Program(String text)
        {
            this.palindrome = text;
        }

        public Program()
        {

        }

        public void executionMethod()
        {
            String reverse = "";
            String isPalindrome = "";
            for(int i = palindrome.Length-1; i >= 0; i--)
            {
                reverse = reverse + palindrome[i];
            }
            if (reverse.Equals(palindrome))
            {
                isPalindrome = "It is palindrome";
            }
            else
            {
                isPalindrome = "It is not palindrome";
            }
            Console.WriteLine(isPalindrome);
        }

        public void executionMethod(int n)
        {
            // arr[][] will store the pattern matrix
            int [,]arr = new int[n,n] ;
            int p = 1;
            int k, j, x;
     
            for (int i = 0; i < n; i++) {
                j = i;
                k = 0;
                while (j >= 0) {
                    arr[k,j] = p;
                    p++;
                    k = k + 1;
                    j = j - 1;
                }
            }
     
            for (int i = 1; i < n; i++) {
                k = i;
                j = n - 1;
                x = i;
                while (j >= x) {
                    arr[k,j] = p;
                    p++;
                    k = k + 1;
                    j = j - 1;
                }
            }
     
            for (int i = 0; i < n; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write(arr[i,j] + " ") ;
                }
                Console.WriteLine() ;
            }

        }



        static void Main(string[] args)
        {
            Program one = new Program("recononcer"); //Constructor overloading
            one.executionMethod(); //Method overloading
            Program two = new Program(); //Constructor overloading
            two.executionMethod(4); //Method overloading
        }

    }
}
