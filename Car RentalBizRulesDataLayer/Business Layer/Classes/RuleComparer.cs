using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Business_Layer.Classes;

namespace Business_Layer
{
    // class must be public when evaluating the biz rules
    public class RuleComparer : IComparer
    {
        public int Compare(object value1, object value2)
        {
            if (IsNumeric(value1) && IsNumeric(value2))
            {
                return ((new CaseInsensitiveComparer()).Compare(
                    Double.Parse(value1.ToString()),
                    Double.Parse(value2.ToString()))
                );
            }
            return ((new CaseInsensitiveComparer()).Compare(value1, value2));
        }

        public bool IsNumeric(object value)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(value.ToString());
        }

        public bool EvaluateRules<T>(T item, List<BusinessRule<T>> rules)
        {
            bool success = true;

            foreach (var rule in rules)
            {
                var value = item.GetType().GetProperty(rule.Property).GetValue(item);
                int result = 0;

                switch (rule.Comparer)
                {
                    case RuleOperator.GreaterThan:
                        result = Compare(value, rule.Value);
                        rule.Success = result > 0;
                        success = success & result > 0;
                        break;
                    case RuleOperator.LessThan:
                        result = Compare(value, rule.Value);
                        rule.Success = result < 0;
                        success = success & result < 0;
                        break;
                    case RuleOperator.Equal:
                        result = Compare(value, rule.Value);
                        rule.Success = result.Equals(0);
                        success = success & result.Equals(0);
                        break;
                    case RuleOperator.NotEqual:
                        result = Compare(value, rule.Value);
                        rule.Success = !result.Equals(0);
                        success = success & !result.Equals(0);
                        break;
                    case RuleOperator.Contains:
                        rule.Success = false;
                        foreach (var itm in rule.Items)
                        {
                            var propValue = itm.GetType()
                                .GetProperty(rule.Property)
                                .GetValue(itm);

                            if (Compare(propValue, value).Equals(0))
                            {
                                rule.Success = true;
                            }
                        }
                        success = success & (bool)rule.Success;
                        break;
                    case RuleOperator.NotContains:
                        rule.Success = true;
                        foreach (var itm in rule.Items)
                        {
                            var propValue = itm.GetType()
                                .GetProperty(rule.Property)
                                .GetValue(itm);
                            if (Compare(propValue, value).Equals(0))
                            {
                                rule.Success = false;
                                break;
                            }
                        }
                        success = success & (bool)rule.Success;
                        break;
                }
            }
            return success;
        }// End EvaluateRules<T> method
    }
}
