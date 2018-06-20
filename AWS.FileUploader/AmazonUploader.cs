using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWS.FileUploader
{
    public class AmazonUploader
    {
        public string SendMyFileToS3(string bucketName)
        {
            try
            {
                var s3Client = new AmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"], RegionEndpoint.USEast1);

                TransferUtility utility = new TransferUtility(s3Client);
                TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
                
                request.BucketName = bucketName;
                
                request.Key = "push-service-worker.min.js";
                request.FilePath = @"\push-service-worker.min.js";
                utility.Upload(request);

                return "Ok";
            }
            catch (Exception ex)
            {
                return bucketName;
            }
        }
    }
}
