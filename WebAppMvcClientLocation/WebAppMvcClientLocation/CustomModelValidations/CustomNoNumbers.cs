using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebAppMvcClientLocation.CustomModelValidations
{
    public class CustomNoNumbers : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var lst = new List<ModelValidationResult>();

            if (context.Model != null)
            {
                if (!context.Model.ToString().All(char.IsLetter))
                {
                    lst.Add(new ModelValidationResult("", "Name cannot contain any numbers!"));
                }
            }
            else
            {
                lst.Add(new ModelValidationResult("", "Not a valid ClientName!"));
            }
            return lst;
        }
    }
}
