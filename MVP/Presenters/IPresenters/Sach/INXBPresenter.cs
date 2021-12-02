namespace MVP.Presenters
{
    public interface INXBPresenter
    {
        public void Add(string tennxb, string viettat);
        public void Update(string id, string tennxb, string viettat);
        public void Delete(string id);
        public void GetsAll();
    }
}
