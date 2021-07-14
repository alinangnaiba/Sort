using Sort.Model;

namespace Sort.View
{
    public interface IView
    {
        void Display();
        void DisplayError(string message);
    }
}
