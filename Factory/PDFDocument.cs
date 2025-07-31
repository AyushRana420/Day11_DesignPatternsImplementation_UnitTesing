using System;

namespace DesignPatternsImplementation.Factory
{
    //PDF document implementation of IDocument.
    public class PDFDocument : IDocument
    {
        public void print()
        {
            Console.WriteLine("Printing PDF Document");
        }
    }
}
