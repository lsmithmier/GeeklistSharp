﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace GeeklistSharp.Model
{
	[DataContract]
	public class Response<T> 
	{
		[DataMember(Name = "status")]
		public string Status { get; set; }

		[DataMember(Name = "data")]
		public T Data { get; set; }
	}
}
