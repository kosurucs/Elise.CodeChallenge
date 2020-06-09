using Elise.CodeChallenge.PartOne.AbstractResource;
using Elise.CodeChallenge.PartOne.AbstractInterface;
using Elise.CodeChallenge.PartOne.ConcreteResource;

namespace Elise.CodeChallenge.PartOne.ConcreteResourceFactory
{
    public class ResourceFactory : IResourceManager
    {
        public IResource GetResource()
        {
            return new Resource();
        }
    }
}
