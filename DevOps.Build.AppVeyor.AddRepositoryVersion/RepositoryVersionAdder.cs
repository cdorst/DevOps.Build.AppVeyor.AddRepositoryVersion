// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

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
            var entry = RepositoryVersionTableEntry(accountName, repositoryName, version);
            var operation = TableOperation.InsertOrReplace(entry);
            var table = await GetTable();
            await table.ExecuteAsync(operation);;
        }
    }
}
