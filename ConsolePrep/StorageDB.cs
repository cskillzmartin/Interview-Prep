using Azure.Storage.Blobs;
using ContentPal.App.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ContentPal.App.Data
{
    public class StorageDB
    {
        public StorageDB(string connectionString, string containerName)
        {
            _ConnectionString = connectionString;
            _ContainerName = containerName;

            Container = new BlobContainerClient(_ConnectionString, _ContainerName);
            Container.CreateIfNotExists();
        }
        private string _ConnectionString { get; set; }
        private string _ContainerName { get; set; }
        private BlobContainerClient Container { get; set; }

        public async Task<bool> UploadBlobAsync(string blobName, Stream model)
        {
            try
            {
                var client = Container.GetBlobClient(blobName);
                using (model)
                {
                    await client.UploadAsync(model);
                }
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> UploadURLAsync(string blobName, string url)
        {
            try
            {
                var client = Container.GetBlobClient(blobName);
                await client.StartCopyFromUriAsync(new Uri(url));
            }
            catch (Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteBlob(string blobName)
        {
            try
            {
                var client = Container.GetBlobClient(blobName);
                await client.DeleteAsync();
            }
            catch (System.Exception)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }


        public async Task<Stream> GetFileAsync(string blobName)
        {
            try
            {
                var client = Container.GetBlobClient(blobName);
                return await client.OpenReadAsync();
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
