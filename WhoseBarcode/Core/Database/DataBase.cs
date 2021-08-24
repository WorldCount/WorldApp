using System.Collections.Generic;
using System.Threading.Tasks;
using WhoseIsBarcode.Core.Database.Models;
using WhoseIsBarcode.Core.Database.Queryes;
using WhoseIsBarcode.Core.Database.Requests;

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
        public List<DbBarcode> GetBarcodes(string barcode)
        {
            List<DbBarcode> barcodes = new List<DbBarcode>();

            BarcodeQuery query = new BarcodeQuery(_connect, barcode, _debugMode);

            DbBarcode dbBarcode = query.Run();

            if(dbBarcode != null)
                barcodes.Add(dbBarcode);

            return barcodes;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public async Task<List<DbBarcode>> GetBarcodesAsync(string barcode)
        {
            return await Task.Run(() => GetBarcodes(barcode));
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

    }
}
