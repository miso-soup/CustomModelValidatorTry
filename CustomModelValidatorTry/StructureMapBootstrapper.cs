using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using CustomModelValidatorTry.Models;

namespace CustomModelValidatorTry
{
	public static class StructureMapBootstrapper
	{
		public static void ConfigureDependencies()
		{
			ObjectFactory.Configure(x =>
			{
				x.For<IPersonNameValidator>().Use<TwitterUserNameValidator>();
			});
		}
	}
}