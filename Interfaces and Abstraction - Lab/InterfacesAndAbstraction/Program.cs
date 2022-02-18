using System;
using System.Collections.Generic;

namespace InterfacesAndAbstraction
{
    public interface IPrintable
    {
        void Print();
        void PrintInPdf();
    }
    public interface ISavable
    {
        void SaveToFile(string fileName);
    }
    public interface IDocument : ISavable, IPrintable
    {
        void CreateNewDocument();
    }

    public class PdfDocument : IDocument
    {
        public void CreateNewDocument()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void PrintInPdf()
        {
            throw new NotImplementedException();
        }

        public void SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
    public class Document : IDocument, IPrintable, ISavable
    {
        public void CreateNewDocument()
        {
            
        }

        public void Print()
        {

        }
        public void PrintInPdf()
        {

        }

        public void SaveToFile(string fileName)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDocument document = new Document();
            document.CreateNewDocument();

            WriteAllElementsToConsole(new List<string>());
        }

        static void WriteAllElementsToConsole(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
