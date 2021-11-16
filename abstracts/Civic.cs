namespace abstracts
{
    public class Civic : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.honda ;
        }
        public override Color WhichColor()
        {
            return Color.black;
        }
    }
}