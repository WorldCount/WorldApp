using System.Collections.Generic;
using System.Threading.Tasks;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Queryes;
using WhoseIsBarcode.Core.Database.Requests;
using WhoseIsBarcode.Core.Database.Response;

namespace WhoseIsBarcode.Core.Database
{
    public class DataBase
    {
        private readonly Connect _connect;
        private readonly bool _debugMode;

        public DataBase(Connect connect, bool debugMode = false)
        {
            _connect = connect;
            _debugMode = debugMode;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<DbBarcode> GetBarcodes(BarcodeRequest request)
        {
            BarcodeQuery query = new BarcodeQuery(_connect, request, _debugMode);
            return query.Run();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public async Task<List<DbBarcode>> GetBarcodesAsync(BarcodeRequest request)
        {
            return await Task.Run(() => GetBarcodes(request));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<DbRange> GetRanges(RangeRequest request)
        {
            RangeQuery query = new RangeQuery(_connect, request, _debugMode);
            return query.Run();
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public async Task<List<DbRange>> GetRangesAsync(RangeRequest request)
        {
            return await Task.Run(() => GetRanges(request));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public List<DbFirm> GetFirms()
        {
            FirmQuery query = new FirmQuery(_connect, _debugMode);
            return query.Run();
        }

        public async Task<List<DbFirm>> GetFirmsAsync()
        {
            return await Task.Run(GetFirms);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public RangeData GetRangeData(int rangeId)
        {
            RangeDataQuery query = new RangeDataQuery(_connect, rangeId, _debugMode);
            return query.Run();
        }

        public async Task<RangeData> GetCountAsync(int rangeId, int state = 0)
        {
            return await Task.Run(() => GetRangeData(rangeId));
        }

    }
}
