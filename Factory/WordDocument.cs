namespace DesignPatternsImplementation.Factory
{
    //Word Documents implementation of IDocument
    public class WordDocument : IDocument
    {
        public void print()
        {
            Console.WriteLine("Printing Word Documents");
        }
    }
}
