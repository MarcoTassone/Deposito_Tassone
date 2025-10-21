using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Mattina.Es_StorageService
{
    public interface IStorageService
    {
        void Salva(string message);
    }

    public class MemoryService : IStorageService
    {
        public void Salva(string message)
        {
            Console.WriteLine($"File salvato su {message}");
        }
    }

    public class DiskService : IStorageService
    {
        public void Salva(string message)
        {
            Console.WriteLine($"File salvato su {message}");
        }
    }

    public class FileUploader
    {
        public IStorageService StorageService { get; set; }
        
        public void Salvataggio(string text, string metodo)
        {
            if (StorageService == null)
            {
                Console.WriteLine("StorageService non impostato.");
                return;
            }
            Console.WriteLine($"{text}");
            StorageService.Salva(metodo);
        }
    }
}
