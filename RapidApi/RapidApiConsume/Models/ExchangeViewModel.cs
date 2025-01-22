﻿namespace RapidApiConsume.Models
{
    public class ExchangeViewModel
    {
        public Data data { get; set; }
        public class Data
        {
            public Exchange_Rates[] exchange_rates { get; set; }

            public class Exchange_Rates
            {
                public string currency { get; set; }
                public string exchange_rate_buy { get; set; }
            }
        }
    }
}
