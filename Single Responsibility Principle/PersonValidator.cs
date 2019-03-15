namespace Single_Responsibility_Principle
{
    public class PersonValidator
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirtName))
            {
                StandardMessages.DisplayValidadeError("Nome");                
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayValidadeError("Sobrenome");
                return false;
            }

            return true;
        }
    }
}
