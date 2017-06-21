using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Listing3_3_RunningManualValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }

        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();
            var context = new validationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, results);
            return results;
        }
    }
}
