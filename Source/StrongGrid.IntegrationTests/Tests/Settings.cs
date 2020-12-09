using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StrongGrid.IntegrationTests.Tests
{
	public class Settings : IIntegrationTest
	{
		public async Task RunAsync(IBaseClient client, TextWriter log, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested) return;

			await log.WriteLineAsync("\n***** SETTINGS *****\n").ConfigureAwait(false);

			var partnerSettings = await client.Settings.GetAllPartnerSettingsAsync(25, 0, null, cancellationToken).ConfigureAwait(false);
			await log.WriteLineAsync($"All partner settings retrieved. There are {partnerSettings.Length} settings").ConfigureAwait(false);
			foreach (var partnerSetting in partnerSettings)
			{
				await log.WriteLineAsync($"  - {partnerSetting.Title}: {(partnerSetting.Enabled ? "Enabled" : "Not enabled")}").ConfigureAwait(false);
			}

			var trackingSettings = await client.Settings.GetAllTrackingSettingsAsync(25, 0, null, cancellationToken).ConfigureAwait(false);
			await log.WriteLineAsync($"All tracking settings retrieved. There are {trackingSettings.Length} settings").ConfigureAwait(false);
			foreach (var trackingSetting in trackingSettings)
			{
				await log.WriteLineAsync($"  - {trackingSetting.Title}:  {(trackingSetting.Enabled ? "Enabled" : "Not enabled")}").ConfigureAwait(false);
			}

			var mailSettings = await client.Settings.GetAllMailSettingsAsync(25, 0, null, cancellationToken).ConfigureAwait(false);
			await log.WriteLineAsync($"All mail setting retrieved. There are {mailSettings.Length} settings").ConfigureAwait(false);
			foreach (var mailSetting in mailSettings)
			{
				await log.WriteLineAsync($"  - {mailSetting.Title}: {(mailSetting.Enabled ? "Enabled" : "Not enabled")}").ConfigureAwait(false);
			}
		}
	}
}
