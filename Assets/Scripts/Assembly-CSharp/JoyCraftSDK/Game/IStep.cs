namespace JoyCraftSDK.Game
{
	public interface IStep
	{
		bool IsComplete { get; set; }

		void Play();

		void Stop();

		void Next();
	}
}
