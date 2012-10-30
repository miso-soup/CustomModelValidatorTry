using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CustomModelValidatorTry
{
	public class CustomDataAnnotationsModelValidator : DataAnnotationsModelValidator
	{
		private readonly IServiceProvider serviceProvider;

		public CustomDataAnnotationsModelValidator(
			IServiceProvider serviceProvider, ModelMetadata metadata, ControllerContext context, ValidationAttribute attribute)
			: base(metadata, context, attribute)
		{
			this.serviceProvider = serviceProvider;
		}

		public override IEnumerable<ModelValidationResult> Validate(object container)
		{
			//IServiceProviderを設定する。
			ValidationContext context = new ValidationContext(container ?? Metadata.Model, serviceProvider, null);
			context.DisplayName = Metadata.GetDisplayName();

			ValidationResult result = Attribute.GetValidationResult(Metadata.Model, context);
			if (result != ValidationResult.Success)
			{
				yield return new ModelValidationResult
				{
					Message = result.ErrorMessage
				};
			}
		}
	}
}