using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorolevES.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = value;
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    str =str.Replace(c, item);
                }            
            }
            return str;
        }
    }
}
