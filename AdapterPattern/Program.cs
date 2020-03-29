using AdapterPattern.avaFilters;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.apply(new CaramelFilter(new Caramel()));
        }
    }
}
