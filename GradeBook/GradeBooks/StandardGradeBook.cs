using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //inherits BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name) //call to base constructor
        {
            Type = GradeBookType.Standard;
        }
    }
}
