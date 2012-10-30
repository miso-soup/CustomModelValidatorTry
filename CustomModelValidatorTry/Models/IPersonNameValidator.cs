using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomModelValidatorTry.Models
{
	/// <summary>
	/// 名前の検証を行います
	/// </summary>
	public interface IPersonNameValidator
	{
		/// <summary>
		/// 名前が有効かどうかを返します。
		/// </summary>
		/// <param name="name">名前</param>
		/// <returns></returns>
		bool IsValid(String name);
	}
}