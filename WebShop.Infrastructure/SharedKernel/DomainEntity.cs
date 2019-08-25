namespace WebShop.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        public bool Istransient()
        {
            return Id.Equals(default(T));
        }
    }
}