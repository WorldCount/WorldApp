using System.Collections.Generic;
using System.Threading.Tasks;
using WhoseBarcode.Core.Database.Models;
using WhoseBarcode.Core.Database.Queryes;

namespace WhoseBarcode.Core.Database
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
        public List<DbRange> GetRanges(int rangeId)
        {
            List<DbRange> ranges = new List<DbRange>();

            RangeQuery query = new RangeQuery(_connect, rangeId, _debugMode);
            DbRange dbRange = query.Run();

            if(dbRange != null)
                ranges.Add(dbRange);

            return ranges;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public async Task<List<DbRange>> GetRangesAsync(int rangeId)
        {
            return await Task.Run(() => GetRanges(rangeId));
        }

    }
}
