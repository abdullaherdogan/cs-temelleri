namespace abstracts
{
    public abstract class Car
    {
        public int NumberOfDoor()
        {
            return 4;
        }
        public virtual Color WhichColor(){
            return Color.white;
        }
        public abstract Brand WhichBrand();
    }
}