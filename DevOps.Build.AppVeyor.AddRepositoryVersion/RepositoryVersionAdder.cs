using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder.RepositoryVersionTableHelper;
using static DevOps.Build.AppVeyor.GetAzureTable.AzureTableGetter;

namespace DevOps.Build.AppVeyor.AddRepositoryVersion
{
    /// <summary>Function adds the given repository build information to an Azure Storage Table ledger</summary>
    public static class RepositoryVersionAdder
    {
        /// <summary>Adds a table entry to an Azure Table named "appveyor"</summary>
        public static async Task AddRepositoryVersionAsync(string accountName, string repositoryName, string version)
        {
            var entry = RepositoryVersionTableEntry(accountName, repositoryName, version); var operation = TableOperation.InsertOrReplace(entry); var table = await GetTable(); await table.ExecuteAsync(operation);
        }
    }
}
