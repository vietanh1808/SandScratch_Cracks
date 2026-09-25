namespace JTD.Generated
{
	public static class JTDEventParams
	{
		public static class Tutorial
		{
			public const string Step = "step";
		}

		public static class GameStart
		{
			public const string GameMode = "game_mode";

			public const string ID = "ID";

			public const string LevelId = "level_id";

			public const string Attempts = "attempts";

			public const string GameMissionId = "game_mission_id";

			public const string MetaInfo = "meta_info";
		}

		public static class GameOver
		{
			public const string GameMode = "game_mode";

			public const string ID = "ID";

			public const string LevelId = "level_id";

			public const string GameMissionId = "game_mission_id";

			public const string TimeSpent = "time_spent";

			public const string Context = "context";

			public const string LevelAbandoned = "level_abandoned";

			public const string Attempts = "attempts";

			public const string LoseCause = "lose_cause";

			public const string Score = "score";

			public const string MetaInfo = "meta_info";
		}

		public static class BiResourceEvent
		{
			public const string FlowType = "flow_type";

			public const string From = "from";

			public const string To = "to";

			public const string VirtualCurrencyName = "virtual_currency_name";

			public const string Value = "value";

			public const string LevelId = "level_id";

			public const string Balance = "balance";
		}

		public static class BiBusinessEvent
		{
			public const string ProductName = "product_name";

			public const string ProductId = "product_id";

			public const string Quantity = "quantity";

			public const string Price = "price";

			public const string Currency = "currency";

			public const string Value = "value";

			public const string PaymentGateway = "payment_gateway";

			public const string TransactionId = "transaction_id";

			public const string ReceiptData = "receipt_data";

			public const string IapPrice = "iap_price";

			public const string IapCurrency = "iap_currency";
		}

		public static class BiAdValue
		{
			public const string AdPlatform = "ad_platform";

			public const string AdSource = "ad_source";

			public const string AdPlatformUnitId = "ad_platform_unit_id";

			public const string AdSourceUnitId = "ad_source_unit_id";

			public const string AdFormat = "ad_format";

			public const string AdPlacement = "ad_placement";

			public const string EstimateValueCurrency = "estimate_value_currency";

			public const string EstimateValue = "estimate_value";

			public const string EstimateValueInUsd = "estimate_value_in_usd";

			public const string LevelId = "level_id";

			public const string MetaInfo = "meta_info";

			public const string RewardedCompleted = "rewarded_completed";
		}

		public static class AdImpression
		{
			public const string AdPlatform = "ad_platform";

			public const string AdSource = "ad_source";

			public const string AdPlatformUnitId = "ad_platform_unit_id";

			public const string AdSourceUnitId = "ad_source_unit_id";

			public const string AdFormat = "ad_format";

			public const string AdPlacement = "ad_placement";

			public const string LevelId = "level_id";

			public const string MetaInfo = "meta_info";
		}

		public static class SessionStart
		{
			public const string InstallDate = "install_date";

			public const string IsFirstSession = "is_first_session";

			public const string Language = "language";
		}

		public static class SessionEnd
		{
			public const string SessionDurationSec = "session_duration_sec";

			public const string LevelsPlayed = "levels_played";

			public const string AdImpressionsCount = "ad_impressions_count";
		}

		public static class InstallAttributed
		{
			public const string MediaSource = "media_source";

			public const string Campaign = "campaign";

			public const string Adset = "adset";

			public const string CreativeId = "creative_id";

			public const string CostUsd = "cost_usd";

			public const string AgeBucket = "age_bucket";

			public const string Gender = "gender";

			public const string Placement = "placement";

			public const string AttributionSdk = "attribution_sdk";
		}

		public static class ConsentUpdate
		{
			public const string ConsentGranted = "consent_granted";

			public const string Region = "region";

			public const string Scope = "scope";

			public const string TriggerSource = "trigger_source";
		}
	}
}
