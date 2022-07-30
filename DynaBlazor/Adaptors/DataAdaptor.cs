namespace DynaBlazor.Adaptors
{
    public abstract class DataAdaptor
    {
        public virtual Task<DataObject> Get(DataSettings settings)
        {
            return Task.FromResult<DataObject>(default);
        }
    }
}
