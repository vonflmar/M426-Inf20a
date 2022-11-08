namespace FooBarQix
{
    public class FooBarQixDeterminer {
        public string determine(int number) {
            string result = "";
            if((number % 3) == 0) {
                result += "Foo";
            } else if((number % 5) == 0) {
                result += "Bar";
            } else if((number % 7) == 0) {
                result += "Qix";
            } else {
                result += number;
            } 
            return result;
        }

    }
}