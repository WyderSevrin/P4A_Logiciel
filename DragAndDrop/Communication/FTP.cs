using CoreFtp;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Communication
{
    public static class ftpPaths
    {
        //public static String pathMobile = System.IO.Path.Combine((string)Android.OS.Environment.ExternalStorageDirectory, Android.OS.Environment.DirectoryDownloads) + "/";
    }


    public class FTP
    {
        //private string mobilePath =  "file:///android_asset/Livres/";  /data/user/0/com.companyname/files
        // private string mobilePath = "data/data/";

        String str = "storage/emulated/0/Download/"; //Android.OS.Environment.ExternalStorageDirectory

        private String pcPath = "";



        private string raspPath = "/home/pi/Desktop/Projet4A_livresPDF/" /*+ "Au_Soleil_Maupassant.pdf"*/; 

        private string rasp_Host = "10.3.141.1";

        /// <summary>
        /// Upload
        /// File with extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task upload_Async(string file)
        {
            using (var ftpClient = new CoreFtp.FtpClient(new FtpClientConfiguration
            {
                Host = rasp_Host,
                Username = "pi",
                Password = "pi"
            }))
            {
                
                var fileinfo = new FileInfo(file);
                
                if (fileinfo.Exists)
                {
                    await ftpClient.LoginAsync();

                    using (var writeStream = await ftpClient.OpenFileWriteStreamAsync(raspPath+ fileinfo.Name))
                    {
                        var fileReadStream = fileinfo.OpenRead();
                        await fileReadStream.CopyToAsync(writeStream);
                    }
                }
            }
        }


        /// <summary>
        /// Download
        /// File with extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task download_Async(string file)
        {
            using (var ftpClient = new CoreFtp.FtpClient(new FtpClientConfiguration
            {
                Host = rasp_Host,
                Username = "pi",
                Password = "pi"
            }))
            {
                var tempFile = new FileInfo(pcPath + file);
                await ftpClient.LoginAsync();
                using (var ftpReadStream = await ftpClient.OpenFileReadStreamAsync(raspPath + file))
                {
                    using (var fileWriteStream = tempFile.OpenWrite())
                    {
                        await ftpReadStream.CopyToAsync(fileWriteStream);
                    }
                }
            }
        }


        public void download(string file)
        {
            // create an FTP client
            FluentFTP.FtpClient client = new FluentFTP.FtpClient("192.168.0.14");

            client.Credentials = new NetworkCredential("pi", "pi");
            client.Connect();

            if (client.FileExists(raspPath + file))
            {
                Console.WriteLine("\n\n========================== YEEEPPPP========== "+ raspPath + file );
                Console.WriteLine("\n\n========================== YEEEPPPP========== " + pcPath + file);

                client.DownloadFile(pcPath + file, raspPath + file);
            }
            else
            {
                Console.WriteLine("\n\n========================== NOOOPPP========== " + raspPath + file);
            }

            

            if (client.FileExists(pcPath + file))
            {
                Console.WriteLine("\n\n========================== YEEEPPPP========== " + pcPath + file);
            }
            else
            {
                Console.WriteLine("\n\n========================== NOOOPPP========== " + pcPath + file);
            }



            client.Disconnect();
            Console.WriteLine("\n\n=======FINISHED===========\n\n");
        }


        public void dowload2(string file)
        {
            string inputfilepath = this.pcPath + file;
            string ftphost = "10.3.141.1";
            string ftpfilepath = this.raspPath + file; 

            string ftpfullpath = "ftp://" + ftphost +"/"+ ftpfilepath;

            using (WebClient request = new WebClient())
            {
                request.Credentials = new NetworkCredential("pi", "pi");
                byte[] fileData = request.DownloadData(ftpfullpath);

               
                using (FileStream fil = File.Create(inputfilepath))
                {

                   
                    fil.Write(fileData, 0, fileData.Length);
                    fil.Close();
                }
            }
            //test if file exists
            if (File.Exists(pcPath + file))
            {
                Console.WriteLine("\n\n========================== YEEEPPPP========== " + pcPath + file);
            }

        }

        public void upload2(string file)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.3.141.1" + this.raspPath+ file);
            request.Credentials = new NetworkCredential("pi", "pi");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            Console.WriteLine("\n ftp://192.168.0.14" + this.raspPath + "Au_Soleil_Maupassant.pdf \n");

            Console.WriteLine("\n"+file);

            using (Stream fileStream = File.OpenRead(file))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }

        }



        public String getWritableAssetPath()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string webPath = Path.Combine(docPath, "Livres");

            return webPath;
        }

        public string getFilePath(string tab, string slug)
        {
            var root = this.getWritableAssetPath();
            var path = Path.Combine(root, "local-content", tab, slug + ".pdf");

            if (File.Exists(path))
            {
                var filePath = path;
                return filePath;
            }

            return "no file: " + path;
        }
    }
}
