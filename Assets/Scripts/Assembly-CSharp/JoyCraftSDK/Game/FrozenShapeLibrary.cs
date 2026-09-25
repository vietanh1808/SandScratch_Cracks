using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	[CreateAssetMenu(fileName = "FrozenShapeLibrary", menuName = "GameSDK/FrozenShapeLibrary")]
	public class FrozenShapeLibrary : AFrozenShapeLibrary
	{
		[Tooltip("Danh sách hình băng. Add/remove qua panel thư viện trong LevelEditorWindow (nó cấp id) — KHÔNG dùng nút +/- ở đây.")]
		[SerializeField]
		private List<FrozenShapeDef> shapes;

		[Tooltip("ID sẽ cấp cho shape TIẾP THEO. Chỉ tăng, KHÔNG BAO GIỜ tái dùng (FL7). ĐỪNG sửa tay.")]
		[SerializeField]
		private int nextId;

		public override IReadOnlyList<FrozenShapeDef> Shapes => null;

		public override FrozenShapeDef GetById(int id)
		{
			return null;
		}

		public override bool IsIdInUse(int id)
		{
			return false;
		}

		public override FrozenShapeDef AddShape(FrozenShapeKind kind)
		{
			return null;
		}

		public override bool RemoveById(int id)
		{
			return false;
		}
	}
}
