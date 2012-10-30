using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomModelValidatorTry.Models
{
	/// <summary>
	/// Twitterに登録されているユーザ名かどうかの検証属性です。
	/// </summary>
	public class TwitterUserNameAttribute : ValidationAttribute
	{
		private IPersonNameValidator validator;

		/// <summary>
		/// 現在の検証属性に対して、指定した値を検証します。
		/// </summary>
		/// <param name="value">検証対象の値。</param>
		/// <param name="validationContext">検証操作に関するコンテキスト情報。</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.DataAnnotations.ValidationResult"/> クラスのインスタンス。
		/// </returns>
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			validator = validationContext.GetService(typeof(IPersonNameValidator)) as IPersonNameValidator;
			
			return base.IsValid(value, validationContext);
		}

		/// <summary>
		/// 指定したオブジェクトの値が有効かどうかを判断します。
		/// </summary>
		/// <param name="value">検証するオブジェクトの値。</param>
		/// <returns>
		/// 指定された値が有効な場合は true。それ以外の場合は false。
		/// </returns>
		public override bool IsValid(object value)
		{
			if (value == null)
				return true;
			
			return validator.IsValid(value.ToString());
		}
	}
}