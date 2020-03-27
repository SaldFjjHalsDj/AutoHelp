using AutoStruct.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStruct
{
    public class DataProcessing
    {
        public List<AutoData> GetInfo()
        {
            List<AutoData> data = new List<AutoData>();
            Storage storage = new Storage();
            data = storage.Load();

            var count = data
                .GroupBy(x => x.Mark)
                .Count();

            var res = data
                .GroupBy(x => x.Mark)
                .Count()
                .Select(m => m.Average(p => p.Price));
    }
}
