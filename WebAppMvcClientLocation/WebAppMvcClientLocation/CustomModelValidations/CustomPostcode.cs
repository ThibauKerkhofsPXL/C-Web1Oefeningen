using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;

namespace WebAppMvcClientLocation.CustomModelValidations
{
    public class CustomPostcode : Attribute, IModelValidator
    {
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var lst = new List<ModelValidationResult>();
            var postcodeLst = new List<string>();
            postcodeLst.Add("3500");
            postcodeLst.Add("3600");
            postcodeLst.Add("3990");

            if (context.Model != null)
            {
                // Kan niet foutgerekend worden maar met een List werken is veel beter en efficienter voor uitbreiding !!
                //if (!context.Model.ToString().Equals("3500") && !context.Model.ToString().Equals("3600") && !context.Model.ToString().Equals("3990"))
                //{
                //    lst.Add(new ModelValidationResult("", "Postcode can only be 3500, 3600, 3990!"));
                //}
                if (!postcodeLst.Contains(context.Model.ToString()))
                {
                    lst.Add(new ModelValidationResult("", "Postcode can only be 3500, 3600, 3990!"));
                }
            }
            else
            {
                lst.Add(new ModelValidationResult("", "Not a valid Postcode"));
            }
            return lst;
        }
    }
}
