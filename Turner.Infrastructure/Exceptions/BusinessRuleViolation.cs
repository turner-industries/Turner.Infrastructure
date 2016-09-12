namespace Turner.Infrastructure.Exceptions
{
    public class BusinessRuleViolation
    {
        public string Violation { private set; get; }

        public string PropertyName { private set; get; }

        public BusinessRuleViolation(string violation, string propertyName = "")
        {
            Violation = violation;
            PropertyName = propertyName;
        }
    }
}
