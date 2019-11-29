using System;
namespace Task02
{
    class ClassForTryingAttributes
    {
        [Myattribute("First")]
        public void DoMeAFavor()
        {
            Console.WriteLine("Hello");
        }
        [Myattribute("Second", 2)]
        private void WontDoItAgaine()
        {
            Console.WriteLine("Nononono");
        }
    }
}
