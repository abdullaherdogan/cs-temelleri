namespace interfaces
{
    public class Focus : ICar
    {
        public Brand WhichBrand(Brand brand)
        {
            return brand;
        }

        public Color WhichColor(Color color)
        {
            return color;
        }
    }
}