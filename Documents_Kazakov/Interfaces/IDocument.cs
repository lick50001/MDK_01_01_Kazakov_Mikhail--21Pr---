using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Documents_Kazakov.Model;

namespace Documents_Kazakov.Interfaces
{
    public interface IDocument
    {
        void Save(bool Update = false);
        List<Documents.Classes.DocumentContext> AllDocuments();
        void Delete();
    }
}
