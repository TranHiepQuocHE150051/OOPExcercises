using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class DocumentManager
    {
        private List<Document> documents;

        public DocumentManager()
        {
            this.documents = new List<Document>();
        }
        public void AddNewDocument(Document document)
        {
            this.documents.Add(document);
        }
        public void DeleteDocument(int documentId)
        {
            var document= this.documents.Where(d=>d.Id==documentId).FirstOrDefault();
            if (document != null)
            {
                this.documents.Remove(document);
                Console.WriteLine("Delete document success, Id: " + documentId);
            }
            else
            {
                Console.WriteLine("Document not found "); 
            }
        }
        public List<Document> GetDocuments()
        {
            return this.documents;
        }
        public List<int> GetDocumentsIdList()
        {
            List<int> ids = new List<int>();
            foreach(var document in this.documents)
            {
                ids.Add(document.Id);
            }
            return ids;
        }

    }
}
