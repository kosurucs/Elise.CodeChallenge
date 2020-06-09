using Elise.CodeChallenge.PartOne.AbstractInterface;
using Elise.CodeChallenge.PartOne.ConcreteResourceFactory;
using System;

namespace Elise.CodeChallenge.PartOne
{
    public class Module
    {
        public void Client()
        {
            GetInstance(new ResourceFactory());
        }

        public void GetInstance(IResourceManager resourceManager)
        {
            var resource = resourceManager.GetResource();
            Console.WriteLine(resource.Display());

            Console.ReadLine();
        }
    }
}
