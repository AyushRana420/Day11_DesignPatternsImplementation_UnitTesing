namespace DesignPatternsImplementation.Factory
{
    //Factory class responsible for creating document objects.
    public static class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "pdf":
                    return new PDFDocument();
                case "word":
                    return new WordDocument();
                default:
                    throw new ArgumentException("Invalid document type.");
            }
        }
    }
}

