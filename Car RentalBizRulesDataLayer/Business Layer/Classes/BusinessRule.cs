using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Classes
{
    public enum RuleOperator
    {
        GreaterThan,
        LessThan,
        Equal,
        NotEqual,
        Contains,
        NotContains
    }

    public class BusinessRule<T>
    {
        public string Property { get; set; }
        public object Value { get; set; }
        public IEnumerable<T> Items { get; set; }
        public RuleOperator Comparer { get; set; }
        public bool? Success { get; set; }

    }
}
