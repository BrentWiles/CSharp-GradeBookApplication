using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //inherits BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted) //call to base constructor
        {
            Type = GradeBookType.Standard;
        }
    }
}
