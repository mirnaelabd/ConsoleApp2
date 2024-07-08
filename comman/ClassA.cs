namespace comman
{
    public class typeA
    {
        private int x; // assessiable with in it scope 
        internal int y; //assessiable with in it scope and its project . 

        public int z;//assessiable with in it scope and project . 


        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
