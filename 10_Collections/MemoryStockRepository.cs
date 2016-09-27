namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
        private long id = 0;
        public MemoryStockRepository()
        {

        }

        public long NextId()
        {
            id++;
            return id;
        }


    }
}
