using System.Text;

namespace Personal
{

    public class Person
    {
        #region Variables.
        private const int Population = 66000000;
        private const double Weight = 68.88;
        private const decimal MonthlySalary = 4.99M;
        private readonly string _name;
        private const char Gender = 'M';
        private const bool IsMarried = true;
        private const char NewLine = '\n';
        #endregion

        public Person(string name)
        {
            _name = name;
        }
        #region Methods
        public override string ToString()
        {
            var personDetails = new StringBuilder(1024);
            personDetails.Append($"The Population of UK is {Population:N0}");
            personDetails.Append(NewLine);
            personDetails.Append($"Your name is {_name} and you are {Gender}");
            personDetails.Append(NewLine);
            personDetails.Append($"You are {Weight} Kgs weight and your salary is {MonthlySalary:C}");
            personDetails.Append(NewLine);
            personDetails.Append($"You are {IsMarried} person.");

            return personDetails.ToString();
        }
        #endregion
    }


}
