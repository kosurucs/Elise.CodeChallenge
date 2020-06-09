using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractInterface;
using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractResource;
using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResource;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResourceFactory
{
    public class ResourceFactory : IResourceManager
    {
        public IResourceSQLDB GetResourceSQLDB()
        {
            return new ResourceSQLDB();
        }

        public IResourceThirdPartyFeed GetFeedResource()
        {
            return new ResourceThirdPartyFeed();
        }

        public IResourceOleDb GetResourceOleDb()
        {
            return new ResourceOleDb();
        }
    }
}
