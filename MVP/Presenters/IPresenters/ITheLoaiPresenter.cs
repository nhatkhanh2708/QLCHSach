namespace MVP.Presenters
{
    public interface ITheLoaiPresenter
    {
        public void AddCategory(string tenTheLoai);
        public void UpdateCategory(string id, string tenTheLoai);
        public void DeleteCategory(string id);        
        public void GetsAll();
    }
}
