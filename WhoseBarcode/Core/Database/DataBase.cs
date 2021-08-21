using System.Collections.Generic;
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

        public List<DbBarcode> GetBarcodes(string barcode)
        {
            List<DbBarcode> barcodes = new List<DbBarcode>();

            BarcodeQuery query = new BarcodeQuery(_connect, barcode, _debugMode);

            DbBarcode dbBarcode = query.Run();

            if(dbBarcode != null)
                barcodes.Add(dbBarcode);

            return barcodes;
        }
    }
}
