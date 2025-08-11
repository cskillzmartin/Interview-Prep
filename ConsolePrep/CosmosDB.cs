using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentPal.App.Data
{
    public class CosmosDB
    {
        public CosmosDB(string connectionString, string dataBase, string container)
        {
            _ConnectionString = connectionString;
            _Database = dataBase;
            _Container = container;
        }

        private string _ConnectionString { get; set; }

        private string _Container { get; set; }
        private string _Database{ get; set; }

        public async Task<bool> Exists(string id)
        {
            try
            {
                using (CosmosClient client = new CosmosClient(_ConnectionString))
                {
                    var db = client.GetDatabase(_Database);
                    var container = db.GetContainer(_Container);
                    await container.ReadItemAsync<dynamic>(id, new PartitionKey(id));
                };
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> CreateAsync<T>(object param)
        {
            try
            {
                using (CosmosClient client = new CosmosClient(_ConnectionString))
                {
                    var db = client.GetDatabase(_Database);
                    var container = db.GetContainer(_Container);
                    await container.UpsertItemAsync((T)param);
                };
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public void Read(object param)
        {
            
        }
        
        

        public async Task<bool> Update<T>(string id, string pKey, List<PatchOperation> ops) 
        {
            try
            {
                using (CosmosClient client = new CosmosClient(_ConnectionString))
                {
                    var db = client.GetDatabase(_Database);
                    var container = db.GetContainer(_Container);
                    await container.PatchItemAsync<T>(id, new PartitionKey(pKey), ops);
                };
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public void Delete(object param)
        {

        }
    }
}
