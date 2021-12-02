namespace MVP.Presenters
{
    public interface ITacGiaPresenter
    {
        public void Add(string tentg, string butdanh);
        public void Update(string id, string tentg, string butdanh);
        public void Delete(string id);
        public void GetsAll();
    }
}
