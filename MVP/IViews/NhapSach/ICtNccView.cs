using System.Drawing;

namespace MVP.IViews
{
    public interface ICtNccView
    {
        public void Notification(string title, string description, Image img, bool flag);
    }
}
