using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BerestenDS.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            var arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr) == value;
        }
    }
}
