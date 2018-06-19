using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook //Inherits BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name) //call to base constructor
        {
            Type = GradeBookType.Ranked;
        }
    }
}
