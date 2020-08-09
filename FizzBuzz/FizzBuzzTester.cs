using System;

namespace FizzBuzz
{
    public class FizzBuzzTester
    {
        public string NumberTester(int inputNumber, 
            bool useCustomWordforTwoMultiples = false,
            string multipleOfTwoWord = "fuzz",
            string multipleOfThreeWord = "fizz") {
            string returnValue = inputNumber.ToString();
            int remainderResultOf2, remainderResultOf3, remainderResultOf5, remainderResultOf7;
            bool ResultOf2 = false, ResultOf3 = false, ResultOf5 =false, ResultOf7 =false;
            Math.DivRem(inputNumber, 2, out remainderResultOf2);
            Math.DivRem(inputNumber, 3, out remainderResultOf3);
            Math.DivRem(inputNumber, 5, out remainderResultOf5);
            Math.DivRem(inputNumber, 7, out remainderResultOf7);
            if (remainderResultOf2 == 0)
            {
                ResultOf2 = true;
            }
            if (remainderResultOf3 == 0) {
                ResultOf3 = true;
            }
            if (remainderResultOf5 == 0)
            {
                ResultOf5 = true;
            }
            if (remainderResultOf7 == 0)
            {
                ResultOf7 = true;
            }
            
            if (ResultOf3 && ResultOf5 && ResultOf7) { return multipleOfThreeWord + " buzz pop"; }
            if (ResultOf5 && ResultOf7) { return "buzz pop"; }
            if (ResultOf3 && ResultOf7) { return multipleOfThreeWord + " pop"; }
            if (ResultOf3 && ResultOf5) { return multipleOfThreeWord + " buzz"; }
            if (ResultOf2 && ResultOf3) { return multipleOfTwoWord + " " + multipleOfThreeWord; }
            if (ResultOf5) { return "buzz"; }
            if (ResultOf7) { return "pop"; }
            if (ResultOf2 && useCustomWordforTwoMultiples) { return multipleOfTwoWord; }
            if (ResultOf3) { return multipleOfThreeWord; }
            
            bool isNormal = double.IsNormal(inputNumber);
            if (isNormal){
                return inputNumber.ToString();
            }




            return returnValue;

        }


    }
}
