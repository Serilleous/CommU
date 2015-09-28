using Newtonsoft.Json;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommU_DAL
{
    public class Program
    {
        DocumentStore docStore;
        public void newThing()
        {

            docStore = new DocumentStore
            {
                ConnectionStringName = "RavenHQ"
            };
            docStore.Initialize();
        }
        public void makeDoc()
        {
        }
    }
}