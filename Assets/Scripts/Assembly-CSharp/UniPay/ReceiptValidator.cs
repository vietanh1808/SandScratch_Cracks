using UnityEngine;
using UnityEngine.Purchasing;

namespace UniPay
{
	public class ReceiptValidator : MonoBehaviour
	{
		public virtual bool CanValidate()
		{
			return false;
		}

		public virtual void Validate(Order order)
		{
		}

		public virtual void Validate(string receipt)
		{
		}
	}
}
