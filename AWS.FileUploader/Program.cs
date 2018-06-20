﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AWS.FileUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            AmazonUploader myUploader = new AmazonUploader();
            var repository = new CustomerRespository();

             var buckets = repository.GetCustomerDns();

             foreach (var item in buckets)
            {
                string bucketName = $"{item}.soclminer.com.br";

                myUploader.SendMyFileToS3(bucketName);

            }

            Console.ReadKey();
        }
    }
}