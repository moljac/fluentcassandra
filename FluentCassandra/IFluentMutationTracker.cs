﻿using System;
using System.Collections.Generic;
namespace FluentCassandra
{
	public interface IFluentMutationTracker
	{
		IFluentRecord ParentRecord { get; }
		void ColumnMutated(MutationType type, IFluentColumn column);
		void Clear();
		IEnumerable<FluentMutation> GetMutations();
	}
}
