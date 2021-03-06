﻿using Sitecore.ContentSearch;
using Synthesis.FieldTypes.Interfaces;
using Synthesis.Synchronization;

namespace Synthesis.Tests.Fixtures.ContentSearch.Data
{
	[RepresentsSitecoreTemplate("{1930BBEB-7805-471A-A3BE-4858AC7CF696}", "DN8cOiiO0ckeD/NPjd9Q8nJuPSk=")]
	internal interface ISearchTemplateItem : IStandardTemplateItem
	{
		[IndexField("__bucketable")]
		IBooleanField BooleanField { get; }
		[IndexField("_templatesimplemented")]
		IItemReferenceListField MultilistField { get; }
		[IndexField("__smallupdateddate")]
		IDateTimeField Timestamp { get; }
		[IndexField("_template")]
		IItemReferenceField Lookup { get; }
		[IndexField("_templatename")]
		ITextField Text { get; }
	}
}
