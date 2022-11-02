namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input) {
            bool isTrue = true;
            string returnString = "";


            if (input % 3 == 0) {
                isTrue = false;
                returnString += "Foo";
            }
            
            if (input % 5 == 0) {
                isTrue = false;
                returnString += "Bar";
            }

            if (input % 7 == 0) {
                isTrue = false;
                returnString += "Qix";
            }
            
            if (isTrue) {
            return input.ToString();
            } else {
                return returnString;
            }
        }
    }
}
