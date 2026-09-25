using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UniPay.SimpleJSON;
using UnityEngine;

namespace UniPay
{
	public class DBManager : MonoBehaviour
	{
		public const string prefsKey = "UniPay_data";

		public const string oldPrefsKey = "SIS_data";

		public const string persistentFileExt = ".dat";

		public StorageTarget storageTarget;

		public EncryptionType encryptionType;

		public string obfuscKey;

		[CompilerGenerated]
		private static Action<string> m_dataUpdateEvent;

		[CompilerGenerated]
		private static Action<string> m_itemSelectedEvent;

		[CompilerGenerated]
		private static Action<string> m_itemDeselectedEvent;

		public const string currencyKey = "Currency";

		public const string contentKey = "Content";

		public const string selectedKey = "Selected";

		public const string playerKey = "Player";

		private bool keepLegacy;

		private JSONNode gameData;

		public static DBManager Instance { get; private set; }

		public static event Action<string> dataUpdateEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> itemSelectedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> itemDeselectedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Init()
		{
		}

		private void InitDB()
		{
		}

		public static int GetPurchase(string productID)
		{
			return 0;
		}

		public static bool IsPurchased(string productID)
		{
			return false;
		}

		public static void SetPurchase(string productID, int amount = 1)
		{
		}

		public static int AddPurchase(string productID, int amount)
		{
			return 0;
		}

		public static void ConsumePurchase(string productID, int amount = 0)
		{
		}

		public static JSONNode GetPlayerData(string keyID)
		{
			return null;
		}

		public static bool IsPlayerData(string keyID)
		{
			return false;
		}

		public static void SetPlayerData(string keyID, JSONData data)
		{
		}

		public static int AddPlayerData(string keyID, int amount)
		{
			return 0;
		}

		public static void ConsumePlayerData(string keyID, int amount = 0)
		{
		}

		public static int GetCurrency(string currencyID)
		{
			return 0;
		}

		public static void SetCurrency(string currencyID, int amount)
		{
		}

		public static int AddCurrency(string currencyID, int amount)
		{
			return 0;
		}

		public static int ConsumeCurrency(string currencyID, int amount)
		{
			return 0;
		}

		public static bool IsRequirementMet(IAPRequirement req)
		{
			return false;
		}

		public static bool CanPurchaseVirtual(IAPProduct product)
		{
			return false;
		}

		public static void PurchaseVirtual(IAPProduct product)
		{
		}

		public static List<string> GetAllPurchased(bool withUpgrades = false)
		{
			return null;
		}

		public static Dictionary<string, int> GetCurrencies()
		{
			return null;
		}

		public static Dictionary<string, List<string>> GetAllSelected()
		{
			return null;
		}

		public static List<string> GetSelectedGroup(string groupName)
		{
			return null;
		}

		public static bool SetSelected(string productID, bool single)
		{
			return false;
		}

		public static bool IsSelected(string id)
		{
			return false;
		}

		public static void SetDeselected(string productID)
		{
		}

		public static string Read()
		{
			return null;
		}

		public static void Save(string key = "")
		{
		}

		public static void Overwrite(string otherData)
		{
		}

		public static string GetJSON(string key)
		{
			return null;
		}

		public static void Clear(string data)
		{
		}

		public static void ClearAll()
		{
		}

		private string Encrypt(string toEncrypt)
		{
			return null;
		}

		private string Decrypt(string toDecrypt)
		{
			return null;
		}

		public static string GetDeviceId()
		{
			return null;
		}
	}
}
