﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class for manga user updates collection.
	/// </summary>
	public class MangaUserUpdates
	{
		/// <summary>
		/// Collection of manga user updates.
		/// </summary>
		[JsonProperty(PropertyName = "users")]
		public ICollection<MangaUserUpdate> Updates { get; set; }
	}
}