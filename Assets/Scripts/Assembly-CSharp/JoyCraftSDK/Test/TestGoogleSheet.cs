using NorskaLib.Spreadsheets;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	[CreateAssetMenu(fileName = "TestGoogleSheet", menuName = "Game/Google Sheet Editor/TestGoogleSheet")]
	public class TestGoogleSheet : SpreadsheetsContainerBase
	{
		[SpreadsheetContent]
		[SerializeField]
		private TestSheetContent content;

		public TestSheetContent Content => null;
	}
}
