namespace Hellmade.Net
{
	public class ErrorInfo
	{
		public bool IsError { get; private set; }

		public bool IsNetworkError { get; private set; }

		public bool IsHTTPError { get; private set; }

		public string ErrorMsg { get; private set; }

		public ErrorInfo()
		{
		}

		public ErrorInfo(bool isNetworkError, bool isHTTPError, string errorMsg)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
