using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Classification_Sample_1ML.Model
{
    public static class ModelOutputExtensions
    {
        public static Dictionary<string, float> ToDictionary(this ModelOutput self, DataViewSchema columns, string targetColumn)
        {
            // See https://stackoverflow.com/questions/53266283/ml-net-0-7-get-scores-and-labels-for-multiclassclassification

            var labelNames = new List<string>();
             
            var column = columns.GetColumnOrNull(targetColumn);
            if (column.HasValue)
            {
                VBuffer<ReadOnlyMemory<char>> vbuffer = new VBuffer<ReadOnlyMemory<char>>();
                column.Value.GetKeyValues(ref vbuffer);

                foreach (ReadOnlyMemory<char> denseValue in vbuffer.DenseValues())
                    labelNames.Add(denseValue.ToString());
            }

            return labelNames.Select((string label, int index) =>
            {
                return new
                {
                    label,
                    index
                };
            })
            .OrderByDescending(x => self.Score[x.index])
            .ToDictionary(x => x.label, x => self.Score[x.index]);
        }
    }
}
