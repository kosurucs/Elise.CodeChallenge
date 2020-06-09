using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractResource;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResource
{
    public class ResourceOleDb : IResourceOleDb
    {
        public string GetConnection()
        {
            return "Resource OleDd - Connection is active now.";
        }
    }
}
