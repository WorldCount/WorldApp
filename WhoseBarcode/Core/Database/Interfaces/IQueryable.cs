
namespace WhoseBarcode.Core.Database.Interfaces
{
    public interface IQueryable
    {
        string GetQuery();

        Connect GetConnect();
    }
}
