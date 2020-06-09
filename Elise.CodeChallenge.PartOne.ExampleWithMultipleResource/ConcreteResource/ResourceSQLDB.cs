using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractResource;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResource
{
    public class ResourceSQLDB : IResourceSQLDB
    {
        public string GetConnection()
        {
            return "Resource A - Instance now active.";
        }
    }
}
