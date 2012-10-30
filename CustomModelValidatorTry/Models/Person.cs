using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomModelValidatorTry.Models
{
	public class Person
	{
		[Display(Name = "お名前")]
		[TwitterUserName(ErrorMessage="{0} は Twitter のユーザ名を指定して下さい。")]
		[Required(ErrorMessage = "{0} は必ず入力して下さい。")]
		public String Name { get; set; }
	}
}