using System;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace React.SortBDay.Common
{
	internal class FileIO : IDisposable
	{
		public string FilePath { get; private set; }
		private readonly Log log;
		private bool disposedValue;

		internal FileIO(string fullFilePath, Log logger)
		{
			FilePath = fullFilePath;
			log = logger;
		}

		internal BirthdayList LoadBirthdays()
		{
			try
			{
				if (File.Exists(FilePath))
				{
					string jsonFile = File.ReadAllText(FilePath);
					return JsonSerializer.Deserialize<BirthdayList>(jsonFile);
				}
				else
				{
					return new BirthdayList();
				}
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(LoadBirthdays));
				throw;
			}
		}

		internal async Task<BirthdayList> LoadBirthdaysAsync()
		{
			try
			{
				using (Stream jsonFile = File.OpenRead(FilePath))
				{
					return await JsonSerializer.DeserializeAsync<BirthdayList>(jsonFile).ConfigureAwait(false);
				}
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(LoadBirthdaysAsync));
				throw;
			}
		}

		internal async Task<bool> SaveBirthdays(BirthdayList birthdays)
		{
			try
			{
				using (FileStream jsonFile = File.OpenWrite(FilePath))
				{
					await JsonSerializer.SerializeAsync(jsonFile, birthdays).ConfigureAwait(false);
					return true;
				}
			}
			catch (Exception ex)
			{
				log.LogInstance.Error(ex, nameof(SaveBirthdays));
				return false;
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				disposedValue = true;
			}
		}

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~FileIO()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}