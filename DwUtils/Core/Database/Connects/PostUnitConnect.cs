using System.IO;
using DwUtils.Core.Storage;
using WcApi.Xml;

namespace DwUtils.Core.Database.Connects
{
    public class PostUnitConnect : FbConnect
    {
        public static PostUnitConnect GetConnect()
        {
            if (!File.Exists(PathManager.PostUnitConnectFile))
                return new PostUnitConnect();
            return Serializer.Load<PostUnitConnect>(PathManager.PostUnitConnectFile);
        }

        public void Save()
        {
            Serializer.Save(PathManager.PostUnitConnectFile, this);
        }
    }
}
