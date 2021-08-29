using System;
using System.Collections.Generic;
using System.IO;
using DiffPather.Core.Database.Models;
using DiffPather.Core.Database.Models.Repository;
using NLog;

namespace DiffPather.Core.Storage
{
    public static class RepositoryManager
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static RepoAppInfo CopyInRepository(AppVersion version)
        {
            if (version?.AppInfo != null)
            {
                try
                {
                    string destPath = Path.Combine(PathManager.RepoDir, version.AppInfo.Name, version.Version);
                    RepoAppVersion repoAppVersion = new RepoAppVersion { Files = new List<RepoAppFile>(), Version = version.Version };

                    RepoAppInfo repoAppInfo = new RepoAppInfo
                    {
                        CurrentVersion = version.Version,
                        Description = version.AppInfo.Description,
                        Name = version.AppInfo.Name,
                        DirectoryLocation = destPath,
                    };

                    foreach (AppFile appFile in version.Files)
                    {
                        string sourcePath = Path.Combine(version.AppInfo.DirectoryLocation, appFile.Location);

                        RepoAppFile repoFile = new RepoAppFile
                        {
                            Extension = appFile.Extension,
                            Hash = appFile.Hash,
                            Location = appFile.Location,
                            Name = appFile.Name
                        };

                        string finalPath = Path.Combine(destPath, repoFile.Location);

                        string dirPath = Path.GetDirectoryName(finalPath);

                        if (!string.IsNullOrEmpty(dirPath))
                            Directory.CreateDirectory(dirPath);

                        File.Copy(sourcePath, finalPath, true);
                        repoAppVersion.Files.Add(repoFile);
                    }

                    repoAppInfo.Versions = new List<RepoAppVersion> { repoAppVersion };

                    return repoAppInfo;
                }
                catch (Exception e)
                {
                    if(Properties.Settings.Default.DebugMode)
                        Logger.Error(e);
                    return null;
                }
            }

            return null;
        }
    }
}
