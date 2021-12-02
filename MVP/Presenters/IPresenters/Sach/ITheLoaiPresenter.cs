namespace MVP.Presenters
{
    public interface ITheLoaiPresenter
    {
        public void Add(string tenTheLoai);
        public void Update(string id, string tenTheLoai);
        public void Delete(string id);        
        public void GetsAll();
    }
}
