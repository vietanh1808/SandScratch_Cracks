using System;
using System.Collections.Generic;
using NorskaLib.Spreadsheets;

namespace JoyCraftSDK.Test
{
	[Serializable]
	public class TestSheetContent
	{
		[SpreadsheetPage("Unity Level Settings")]
		public List<MineData> In_Game_Data;
	}
}
