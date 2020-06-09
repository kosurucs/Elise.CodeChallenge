using Elise.CodeChallenge.PartOne.AbstractResource;

namespace Elise.CodeChallenge.PartOne.ConcreteResource
{
    public class Resource : IResource
    {
        public string Display()
        {
            return "Resource A - Instance is ready to use.";
        }
    }
}
