using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	[Serializable]
	public class FeatureChecklistEntry : JBase
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private ChecklistSource source;

		[SerializeField]
		private List<string> categories;

		[SerializeField]
		private string title;

		[TextArea(2, 6)]
		[SerializeField]
		private string description;

		[SerializeField]
		private int order;

		[SerializeField]
		private string flowKey;

		[SerializeField]
		private string note;

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ChecklistSource Source
		{
			get
			{
				return ChecklistSource.Sdk;
			}
			set
			{
			}
		}

		public List<string> Categories => null;

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Order
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string FlowKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Note
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
