//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Værested</summary>
	[PublishedContentModel("vaerested")]
	public partial class Vaerested : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "vaerested";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Vaerested(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Vaerested, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Adresse
		///</summary>
		[ImplementPropertyType("vAdresse")]
		public string VAdresse
		{
			get { return this.GetPropertyValue<string>("vAdresse"); }
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("vEmail")]
		public string VEmail
		{
			get { return this.GetPropertyValue<string>("vEmail"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("vImg")]
		public IPublishedContent VImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("vImg"); }
		}

		///<summary>
		/// Landsdel
		///</summary>
		[ImplementPropertyType("vLandsdel")]
		public string VLandsdel
		{
			get { return this.GetPropertyValue<string>("vLandsdel"); }
		}

		///<summary>
		/// Navn
		///</summary>
		[ImplementPropertyType("vName")]
		public string VName
		{
			get { return this.GetPropertyValue<string>("vName"); }
		}

		///<summary>
		/// Telefon
		///</summary>
		[ImplementPropertyType("vTelefon")]
		public string VTelefon
		{
			get { return this.GetPropertyValue<string>("vTelefon"); }
		}
	}
}
