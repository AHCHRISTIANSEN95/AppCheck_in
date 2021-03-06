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
	/// <summary>Aktivitet</summary>
	[PublishedContentModel("aktivitet")]
	public partial class Aktivitet : PublishedContentModel, IBaseConent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aktivitet";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Aktivitet(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Aktivitet, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Event Contact Img
		///</summary>
		[ImplementPropertyType("eventContactImg")]
		public IPublishedContent EventContactImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("eventContactImg"); }
		}

		///<summary>
		/// Event contact name
		///</summary>
		[ImplementPropertyType("eventContactName")]
		public string EventContactName
		{
			get { return this.GetPropertyValue<string>("eventContactName"); }
		}

		///<summary>
		/// Event Contact Position
		///</summary>
		[ImplementPropertyType("eventContactPosition")]
		public string EventContactPosition
		{
			get { return this.GetPropertyValue<string>("eventContactPosition"); }
		}

		///<summary>
		/// Event Date and Time
		///</summary>
		[ImplementPropertyType("eventDateAndTime")]
		public DateTime EventDateAndTime
		{
			get { return this.GetPropertyValue<DateTime>("eventDateAndTime"); }
		}

		///<summary>
		/// Event Description
		///</summary>
		[ImplementPropertyType("eventDescription")]
		public string EventDescription
		{
			get { return this.GetPropertyValue<string>("eventDescription"); }
		}

		///<summary>
		/// Event Email
		///</summary>
		[ImplementPropertyType("eventEmail")]
		public string EventEmail
		{
			get { return this.GetPropertyValue<string>("eventEmail"); }
		}

		///<summary>
		/// Event Google Maps Link
		///</summary>
		[ImplementPropertyType("eventGoogleMapsLink")]
		public string EventGoogleMapsLink
		{
			get { return this.GetPropertyValue<string>("eventGoogleMapsLink"); }
		}

		///<summary>
		/// Event Headline
		///</summary>
		[ImplementPropertyType("eventHeadline")]
		public string EventHeadline
		{
			get { return this.GetPropertyValue<string>("eventHeadline"); }
		}

		///<summary>
		/// Event Info Headline
		///</summary>
		[ImplementPropertyType("eventInfoHeadline")]
		public string EventInfoHeadline
		{
			get { return this.GetPropertyValue<string>("eventInfoHeadline"); }
		}

		///<summary>
		/// Event Info Text
		///</summary>
		[ImplementPropertyType("eventInfoText")]
		public string EventInfoText
		{
			get { return this.GetPropertyValue<string>("eventInfoText"); }
		}

		///<summary>
		/// Event Location
		///</summary>
		[ImplementPropertyType("eventLocation")]
		public string EventLocation
		{
			get { return this.GetPropertyValue<string>("eventLocation"); }
		}

		///<summary>
		/// Event Phone
		///</summary>
		[ImplementPropertyType("eventPhone")]
		public string EventPhone
		{
			get { return this.GetPropertyValue<string>("eventPhone"); }
		}

		///<summary>
		/// Event Previous Activities Img
		///</summary>
		[ImplementPropertyType("eventPreviousActivitiesImg1")]
		public IPublishedContent EventPreviousActivitiesImg1
		{
			get { return this.GetPropertyValue<IPublishedContent>("eventPreviousActivitiesImg1"); }
		}

		///<summary>
		/// Event Previous Activities Img2
		///</summary>
		[ImplementPropertyType("eventPreviousActivitiesImg2")]
		public IPublishedContent EventPreviousActivitiesImg2
		{
			get { return this.GetPropertyValue<IPublishedContent>("eventPreviousActivitiesImg2"); }
		}

		///<summary>
		/// Event Sub Headline
		///</summary>
		[ImplementPropertyType("eventSubHeadline")]
		public string EventSubHeadline
		{
			get { return this.GetPropertyValue<string>("eventSubHeadline"); }
		}

		///<summary>
		/// Event Top img
		///</summary>
		[ImplementPropertyType("eventTopImg")]
		public IPublishedContent EventTopImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("eventTopImg"); }
		}

		///<summary>
		/// Content sub text
		///</summary>
		[ImplementPropertyType("contentSubText")]
		public string ContentSubText
		{
			get { return Umbraco.Web.PublishedContentModels.BaseConent.GetContentSubText(this); }
		}

		///<summary>
		/// Content text
		///</summary>
		[ImplementPropertyType("contentText")]
		public IHtmlString ContentText
		{
			get { return Umbraco.Web.PublishedContentModels.BaseConent.GetContentText(this); }
		}

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.BaseConent.GetPageTitle(this); }
		}
	}
}
