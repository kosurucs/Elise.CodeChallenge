using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractResource;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResource
{
    public class ResourceThirdPartyFeed : IResourceThirdPartyFeed
    {
        public string GetConnection()
        {
            return "Resource B - Instance now active.";
        }
    }
}
