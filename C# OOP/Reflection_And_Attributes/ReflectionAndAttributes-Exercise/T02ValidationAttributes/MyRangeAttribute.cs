

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        
        public override bool IsValid(object obj)
        {
            int result = (int) obj;
            if (result >= minValue && result <=maxValue)
            {
                return true;
            }

            return false;
        }
       
    }
}
