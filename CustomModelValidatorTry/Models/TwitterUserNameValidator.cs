using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomModelValidatorTry.Models
{
	/// <summary>
	/// Twitterより名前を検証します。
	/// </summary>
	public class TwitterUserNameValidator : IPersonNameValidator
	{
		/// <summary>
		/// 名前が有効かどうかを返します。
		/// </summary>
		/// <param name="name">名前</param>
		/// <returns></returns>
		public bool IsValid(string name)
		{
			//ここで実際に検証

			return false;
		}
	}
}