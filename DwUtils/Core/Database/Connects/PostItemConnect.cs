using System.IO;
using DwUtils.Core.Storage;
using WcApi.Xml;

namespace DwUtils.Core.Database.Connects
{
    public class PostItemConnect : FbConnect
    {

        public static PostItemConnect GetConnect()
        {
            if (!File.Exists(PathManager.PostItemConnectFile))
                return new PostItemConnect();
            return Serializer.Load<PostItemConnect>(PathManager.PostItemConnectFile);
        }

        public void Save()
        {
            Serializer.Save(PathManager.PostItemConnectFile, this);
        }
    }
}
