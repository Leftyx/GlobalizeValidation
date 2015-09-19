using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalizeValidation.Infrastructure
{
    public static class ModelStateExtensions
    {
        public static IEnumerable Errors(this ModelStateDictionary modelState)
        {
            return (modelState.ToDictionary(kvp => kvp.Key, kvp =>
                kvp.Value.Errors
                    .Select(e => e.ErrorMessage).ToArray())
                    .Where(m => m.Value.Count() > 0).Select(f => f.Value).ToList());
        }
    }
}