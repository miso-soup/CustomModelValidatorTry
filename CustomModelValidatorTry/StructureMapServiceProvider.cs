using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace CustomModelValidatorTry
{
	/// <summary>
	/// StructureMapを使ったサービスプロバイダです
	/// </summary>
	public class StructureMapServiceProvider : IServiceProvider
	{
		/// <summary>
		/// 指定した型のサービス オブジェクトを取得します。
		/// </summary>
		/// <param name="serviceType">取得対象となるサービスの型を指定するオブジェクト。</param>
		/// <returns>
		///   <paramref name="serviceType"/> 型のサービス オブジェクト。または<paramref name="serviceType"/> 型のサービス オブジェクトがない場合は null。
		/// </returns>
		public object GetService(Type serviceType)
		{
			return ObjectFactory.GetInstance(serviceType);
		}
	}
}