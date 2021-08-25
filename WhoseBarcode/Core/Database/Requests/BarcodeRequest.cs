
namespace WhoseIsBarcode.Core.Database.Requests
{
    public class BarcodeRequest
    {
        public string Barcode { get; set; }
        public int RangeId { get; set; }

        public int Limit { get; set; }
    }
}
