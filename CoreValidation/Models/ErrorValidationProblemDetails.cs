using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation.Models
{
    public class ErrorValidationProblemDetails : ProblemDetails
    {
        public ICollection<ValidationError> ValidationErrors { get; set; }
    }

    public class ValidationError
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}