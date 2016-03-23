﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class StoreUnionFromSortedSets
		: IHasStringId
	{
		public StoreUnionFromSortedSets()
		{
			this.FromSetIds = new List<string>();
		}

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public List<string> FromSetIds { get; set; }
	}

	[DataContract]
	public class StoreUnionFromSortedSetsResponse
	{
		public StoreUnionFromSortedSetsResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}