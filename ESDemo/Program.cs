using System;
using System.Collections.Generic;
using Elasticsearch.Net;
using Elasticsearch.Net.Diagnostics;
using Nest;
using Newtonsoft.Json;

namespace ESDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = new Uri[]
            {
                new Uri("http://localhost:9200")
            };
            var pool = new StaticConnectionPool(nodes);

            var settings = new ConnectionSettings(pool).DefaultIndex("crm.base.log");

            var client = new ElasticClient(settings);

            //for (int i = 200; i < 500; i++)
            //{
            //    var log = new CreateRequest<CRMLog>(Guid.NewGuid());
            //    CRMLog tempDoc = new CRMLog();
            //    tempDoc.LogLevel = i;
            //    tempDoc.HttpMethod = "POST";
            //    tempDoc.OnlyKey = Guid.NewGuid().ToString("N");
            //    tempDoc.IPAddress = "0.0.0.0";
            //    log.Document = tempDoc;
            //    client.Create<CRMLog>(log);
            //}


            //  client.Delete(new DeleteRequest("crm.base.log", "4bd0ffb9-f5fc-4748-94f6-b41c706cc4ca"));
            //    var result=  client.Delete<CRMLog>(new DocumentPath<CRMLog>("e949fcc6-4ada-4643-b8cd-c6d4d52cced2"));



            //var bulkDel = new BulkRequest() { Operations = new List<IBulkOperation>() };
            //bulkDel.Operations.Add(new BulkDeleteOperation<CRMLog>("4bd0ffb9-f5fc-4748-94f6-b41c706cc4ca"));
            //bulkDel.Operations.Add(new BulkDeleteOperation<CRMLog>("aca1f759-43ec-4c2c-b9ce-fe0f6c644a48"));
            //var resultDel = client.Bulk(bulkDel);



            //IUpdateRequest<CRMLog, CRMLog> request = new UpdateRequest<CRMLog, CRMLog>("7d8ebbcc-b80a-4104-a974-519474563fc2")
            //{
            //    Doc = new CRMLog()
            //    {
            //        LogLevel = 6,
            //        HttpMethod = "test4update........"
            //    }
            //};
            //var resp = client.Update<CRMLog, CRMLog>(request);


            //var bulkUpdate = new BulkRequest() { Operations = new List<IBulkOperation>() };
            //bulkUpdate.Operations.Add(new BulkUpdateOperation<CRMLog, CRMLog>("6cfb5050-d175-4fb1-8f8d-c6d88cb0e2a4") { Doc = new CRMLog() { HttpMethod = "xiugai" } });
            //bulkUpdate.Operations.Add(new BulkUpdateOperation<CRMLog, CRMLog>("aca1f759-43ec-4c2c-b9ce-fe0f6c644a48") { Doc = new CRMLog() { HttpMethod = "xiugai1" } });
            //var result = client.Bulk(bulkUpdate);


            //var modUser = client.Get<CRMLog>("ef6c9de4-196e-46b1-bfd4-ecfcae5ecb32");
            //var tweet = JsonConvert.SerializeObject(modUser.Source);
            //Console.WriteLine(tweet);


            //var ts = client.Search<CRMLog>(s => s
            //.From(0)
            //.Size(1000)
            //.Query(q =>
            //          q.Match(m => m.Field(f => f.LogLevel).Query("318")))).Documents;

            //foreach (var t in ts)
            //{
            //    Console.WriteLine("LogLevel:{0},HttpMethod:{1}", t.LogLevel, t.HttpMethod);
            //}


            // client.Search<CRMLog>.(s=>s.Query(q => q.Match(m => m.Field(f => f.Type).Query(type)))).Documents;


            // var modList = client.Search<CRMLog>(s => s
            //.From(0)
            //.Size(10)
            //.Query(q =>
            //        q.Term(t => t.HttpMethod, "www.b.com")
            //        || q.Match(mq => mq.Field(f => f.HttpMethod).Query("Get"))
            //    )
            // );
            // var tweet = JsonConvert.SerializeObject(modList);
            Console.WriteLine("Hello World!");
        }
    }
}