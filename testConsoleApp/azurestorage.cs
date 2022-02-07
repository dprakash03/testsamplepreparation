using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    public static class azurestorage
    {
        const string StorageAccountName = "prakashstorageaccount";
        const string StorageAccountKey = "dO+Tq1cwT1bff+EthXRlZcHyKCeCIUDuYUKykeqBW48VZRFEqf362Z5bo3VDxbDRrU3NkP5CtAfmJWR4fOah1Q==";

        public static void GetQueueMessages()
        {
            var storageAccount = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(StorageAccountName, StorageAccountKey), true);

            var storageclient = storageAccount.CreateCloudQueueClient();

            var queueref = storageclient.GetQueueReference("prakashqueue");

            while (true)
            {
                var quemsg = queueref.GetMessageAsync();

                if (quemsg.Result == null )
                    break;

                var msgtxt = quemsg.Result.AsString;
               
                Console.WriteLine(msgtxt+"-Processed");
                queueref.DeleteMessageAsync(quemsg.Result);
            }
        }

        public static void InsertQueueMessages()
        {
            var storageAccount = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(StorageAccountName, StorageAccountKey), true);

            var storageclient = storageAccount.CreateCloudQueueClient();


            var queueref = storageclient.GetQueueReference("prakashqueue");
            queueref.CreateIfNotExistsAsync();
            for(int i =0;i<6;i++)
            {
                var quemsg = queueref.AddMessageAsync(new Microsoft.WindowsAzure.Storage.Queue.CloudQueueMessage("Hello"+i));

            }
        }


    }
}
