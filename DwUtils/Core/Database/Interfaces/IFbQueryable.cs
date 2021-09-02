using DwUtils.Core.Database.Connects;

namespace DwUtils.Core.Database.Interfaces
{
    public interface IFbQueryable
    {
        string GetQuery();

        FbConnect GetConnect();
    }
}
