using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1cois2020
    //Lauren Sisson Dales
    //0751195
   //March 7th 2022
   //COIS 2020 ASSIGNMENT 1 QUESTION 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CStack alist = new CStack();//create array list
            string ch;//holds search characters 
            string word = "sees";//value for search
            bool isPalindrome = true;//bool to mark if it is a match
            for (int x = 0; x < word.Length; x++)//search through word for its length
                alist.push(word.Substring(x, 1));
            int pos = 0;
            while (alist.count > 0)// loop until the list is at 0
            {
                ch = alist.pop().ToString();//pop char off stack  
                if (ch != word.Substring(pos, 1))// see if it does not match
                {
                    isPalindrome = false; // if it does not match
                    break;//break
                }
                pos++;// if it does match
            }
            if (isPalindrome)
                Console.WriteLine(word + " is a palindrome.");//write this
            else
                Console.WriteLine(word + " is not a palindrome.");//else write this
            Console.Read();
        }
    }
}
class CStack
{
    private int p_index;
    public ArrayList list;//create array list
    public CStack()
    {
        list = new ArrayList();
        p_index = -1;// create index for how to iterate through
    }

    public int count
    {
        get
        {
            return list.Count;//use count function
        }
    }
    public void push(object item)
    {
        list.Add(item);//push item onto list
        p_index++;
    }
    public object pop()//pop off list
    {
        object obj = list[p_index];
        list.RemoveAt(p_index);
        p_index--;
        return obj;
    }
    public void clear()//clear list
    {
        list.Clear();
        p_index = -1;
    }
    public object peek()// peek then return list
    {
        return list[p_index];
    }
}
