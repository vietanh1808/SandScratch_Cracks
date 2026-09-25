using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class ColorJarData : JBase
	{
		[Tooltip("Màu jar (key match — cast (int) == SandMaterialId).")]
		[SerializeField]
		private GameObjectColor color;

		[Tooltip("Số pixel jar chứa được trước khi đầy.")]
		[SerializeField]
		[Min(1f)]
		private int capacity;

		[Tooltip("HIDDEN BOX: sinh ra mang material ẩn, giấu màu — chỉ LỘ khi jar lên hàng đầu (head). THUẦN VISUAL: màu thật vẫn dùng để route cát như thường. Jar ở hàng đầu lúc build thì lộ ngay (đã ở head).")]
		[SerializeField]
		private bool hidden;

		[Tooltip("CONNECTOR: id nhóm nối N>=2 box (0 = box thường, không nối). Mọi jar CÙNG id = 1 nhóm CHAIN và BẮT BUỘC ở CỘT KHÁC nhau đôi một. Box đang nối bị KHÓA: lên head vẫn ĐÓNG nắp, không nhận cát, booster không swap được — chỉ RELEASE khi TẤT CẢ box trong nhóm cùng lên head. Release 1 CHIỀU (rồi là box thường mãi).")]
		[SerializeField]
		[Min(0f)]
		private int connectorId;

		[Tooltip("WIDE BOX: box to chiếm 2 cột (cột này + cột bên PHẢI) cùng depth. Chỉ là 1 entry ở cột TRÁI; runtime/editor chèn ngầm slot cùng depth vào cột phải (resolver ColorJarLayout). Luật: không ở cột cuối · cột phải phải có >= depth jar · không kiêm connector — sai thì fail-open thành box thường + LogError. Kết hợp với Tall -> box 2x2 (chiếm thêm 1 hàng bên dưới).")]
		[SerializeField]
		private bool wide;

		[Tooltip("2x2 BOX: chỉ có ý nghĩa khi Wide=true (box chiếm 2 cột x 2 hàng thay vì 2 cột x 1 hàng). Tall=true mà Wide=false -> bị BỎ QUA, coi như box thường (resolver không báo lỗi). Luật/validate y hệt Wide (không ở cột cuối · cột phải đủ jar · không kiêm connector) — sai thì fail-open thành box thường.")]
		[SerializeField]
		private bool tall;

		public GameObjectColor Color => GameObjectColor.None;

		public int Capacity => 0;

		public bool Hidden => false;

		public int ConnectorId => 0;

		public bool Wide => false;

		public bool Tall => false;

		public void SetHidden(bool value)
		{
		}

		public void SetWide(bool value)
		{
		}

		public void SetTall(bool value)
		{
		}

		public void SetConnectorId(int value)
		{
		}

		public void SetCapacity(int value)
		{
		}

		public void SetColor(GameObjectColor value)
		{
		}

		public ColorJarData()
		{
		}

		public ColorJarData(GameObjectColor color, int capacity, bool hidden = false, int connectorId = 0, bool wide = false, bool tall = false)
		{
		}
	}
}
