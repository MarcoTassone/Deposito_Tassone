using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Pomeriggio.Es_DataExporter
{
    public interface IExportFormatter
    {
        void Format(Data file);
    }

    public class JsonExport : IExportFormatter
    {
        public void Format(Data file)
        {
            Console.WriteLine($"Esportazione del file {file}.");
        }
    }

    public class XmlExport : IExportFormatter
    {
        public void Format(Data file)
        {
            Console.WriteLine($"Esportazione del file {file}.");
        }
    }

    public class Data
    {
        public string? Name { get; set; }
        public int Id { get; set;}
    }
    
    public class DataExporter
    {
        public void Export(Data data, IExportFormatter formatter)
        {
            formatter.Format(data);
            Console.WriteLine($"{data} esportato.");
        }
    }
}