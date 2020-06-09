using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractResource;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractInterface
{
    public interface IResourceManager
    {
        IResourceSQLDB GetResourceSQLDB();

        IResourceThirdPartyFeed GetFeedResource();

        IResourceOleDb GetResourceOleDb();
    }
}
