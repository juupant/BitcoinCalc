using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BitcoinCalculatorAlanMarkusUnt
{
    public class BitcoinRates
    {
        public Data Data { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BTCEUR
    {
        public int CCSEQ { get; set; }
        public double PRICE { get; set; }
        public string PRICE_FLAG { get; set; }
        public int PRICE_LAST_UPDATE_TS { get; set; }
        public int PRICE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class BTCGBP
    {
        public int CCSEQ { get; set; }
        public double PRICE { get; set; }
        public string PRICE_FLAG { get; set; }
        public int PRICE_LAST_UPDATE_TS { get; set; }
        public int PRICE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class BTCUSD
    {
        public int CCSEQ { get; set; }
        public double PRICE { get; set; }
        public string PRICE_FLAG { get; set; }
        public int PRICE_LAST_UPDATE_TS { get; set; }
        public int PRICE_LAST_UPDATE_TS_NS { get; set; }
    }

    public class Data
    {
        [JsonProperty("BTC-USD")]
        public BTCUSD BTCUSD { get; set; }

        [JsonProperty("BTC-EUR")]
        public BTCEUR BTCEUR { get; set; }

        [JsonProperty("BTC-GBP")]
        public BTCGBP BTCGBP { get; set; }
    }

    public class Err
    {
    }

    public class Root
    {
        public Data Data { get; set; }
        public Err Err { get; set; }
    }
}
