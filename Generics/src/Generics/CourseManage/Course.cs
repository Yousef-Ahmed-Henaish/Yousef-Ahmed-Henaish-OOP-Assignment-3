namespace Generics.CourseManage;

internal class Course : IHasId
{
    public int Id {  get; set; }
    public string Title { get; set; }
    private decimal _price;

    public decimal Price 
    {
        get => _price;

        set
        {
            if (value <= 0)
                throw new ArgumentException("Invalid input !");

            _price = value;
        }
    }

}
