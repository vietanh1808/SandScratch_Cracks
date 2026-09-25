using System;

namespace UniPay
{
	[Serializable]
	internal struct ReceiptRequest
	{
		public string store;

		public string bid;

		public string pid;

		public string type;

		public string user;

		public string receipt;
	}
}
