using System.Collections.Generic;

namespace JoyCraftSDK.Test.UnitTestingData
{
	public interface ISampleDataVersion
	{
		int GetDataVersion();

		void SetDataVersion(int version);

		bool UpdateVersionIncremental(int currentVersion);

		List<ISampleDataVersion> GetSubDataVersionList();
	}
}
