using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.AbstractInterface;
using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResource;
using Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.ConcreteResourceFactory;
using System;
using static Elise.CodeChallenge.PartOne.ExampleWithMultipleResource.Enumuration;

namespace Elise.CodeChallenge.PartOne.ExampleWithMultipleResource
{
    public class Module
    {
        public void Client()
        {
            var dbInstance = GetInstance(new ResourceFactory(), DbResourceType.OleDb);
            if(dbInstance!=null)
            {
                var oleDbInstances = dbInstance as ResourceOleDb;
                Console.WriteLine(oleDbInstances.GetConnection());
            }
        }

        public object GetInstance(IResourceManager resourceManager, DbResourceType resourceType)
        {
            switch (resourceType)
            {
                case DbResourceType.OleDb:
                    return resourceManager.GetResourceOleDb();

                case DbResourceType.SQLDB:
                    return resourceManager.GetResourceSQLDB();

                case DbResourceType.ThirdPartyFeed:
                    return resourceManager.GetFeedResource();
                    
                default:
                    return null;
            }
        }
    }
}
