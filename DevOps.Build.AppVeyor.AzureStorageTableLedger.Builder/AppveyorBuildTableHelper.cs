// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Build.AppVeyor.AzureStorageTableLedger.Builder
{
    /// <summary>Function returns an instance of AppveyorBuildTable</summary>
    public static class AppveyorBuildTableHelper
    {
        /// <summary>Returns an instance of AppveyorBuildTable</summary>
        public static AppveyorBuildTable BuildTableEntry(string name, string version, string dependencies = null, string fileHashes = null) => new AppveyorBuildTable(name, version, dependencies, fileHashes);
    }
}
