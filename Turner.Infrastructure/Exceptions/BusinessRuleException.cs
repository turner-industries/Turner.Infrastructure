using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Turner.Infrastructure.Exceptions
{
    [Serializable]
    public class BusinessRuleException : Exception
    {
        public ICollection<BusinessRuleViolation> Violations { get; protected set; }

        public BusinessRuleException(ICollection<BusinessRuleViolation> violations)
        {
            Violations = violations;
        }
    
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("Violations", Violations, typeof(ICollection));
        }
    }
}
