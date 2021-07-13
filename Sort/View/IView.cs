using Sort.Model;

namespace Sort.View
{
    public interface IView
    {
        public void Display();
        public void DisplayError(string message);
    }
}
