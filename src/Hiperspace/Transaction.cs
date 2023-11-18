namespace Hiperspace
{
    public class Transaction : IDisposable
    {
        private HiperSpace _space;
        public Transaction(HiperSpace space) 
        { 
            _space = space;
        }

        public void Dispose()
        {
            _space.EndTransaction();
        }
    }
}
