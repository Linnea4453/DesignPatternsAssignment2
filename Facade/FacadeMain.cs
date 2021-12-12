namespace Assignment2.Facade
{
    internal class FacadeMain
    {
        public void Run()
        {
            // Write a facade to make it easier to save and load words

            Word word = new();

            word.SaveWord();
            word.LoadWord();
        }
    }
}