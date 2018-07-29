using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;

namespace TestMTOM
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.ServiceModel.Activation;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Service1 : IService1
    {
        public ObservableCollection<Model.tootAMessage> Messages = new ObservableCollection<Model.tootAMessage>();
        private byte[] FileToByteArray(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        public Result GetData(string value)
        {
            return new Result
            {
                Message = string.Format("Hi {0}, File Received.", value),
                FileContent = this.FileToByteArray(@"C:\Testfiles\Dolomieten2015_SellaRonda.MOV") //3.4 GB   //(@"c:\sample.pdf")
            };
        }


        //public Stream GetLargeObject(string _filename)
        //{
        //    #region performance testing

        //    //in this test, the filename and location is given from the client, but that is not the real situation
        //    string filePath = (@"C:\Testfiles\test2.mp4");// Path.Combine(cFileSourceDirectory, _filename);
        //    Stopwatch sw = new Stopwatch(); //exlusively for measuring the performance
        //    sw.Start();
        //    //file info about  the given file
        //    //   FileInfo oFileInfo = new FileInfo(filePath);
        //    //   long filekilobytes = oFileInfo.Length;
        //    AppendToLog(string.Format("Start GetLargeObject at: {0}", DateTime.Now.ToString("G")));

        //    #endregion

        //    try
        //    {
        //        Console.WriteLine(filePath);
        //        FileStream imageFile = File.OpenRead(Path.Combine(cFileSourceDirectory, filePath));
        //        return imageFile;
        //    }

        //    catch (IOException ex)
        //    {
        //        AppendToLog(String.Format("An exception was thrown while trying to open file {0} Exception: {1}", filePath, ex.Message));

        //        throw;
        //    }
        //    finally
        //    {
        //        //    AppendToLog("End: GetLargeObject Duration: " + sw.Elapsed.TotalSeconds.ToString("#0.###") +
        //        //                " Filesize (mb): " + (filekilobytes * 0.000001).ToString("#0.###") + " Filename: " + filePath);
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_message">the message to be added</param>
        /// <param name="_severity">this way, the console can see what color it should be printed</param>
        /// <param name="_component">from which application is the message coming</param>
        /// <returns></returns>
        public bool SetMessage(string _message, string _severity, string _component)
        {
            try
            {
                Console.WriteLine(_message);

                Model.tootAMessage message = new Model.tootAMessage();
                message.Component = _component;
                message.Message = _message;
                message.Severity = _severity;

                Messages.Add(message);
                return true;
            }

            catch (IOException ex)
            {
                AppendToLog(String.Format("An exception was thrown while trying to add message. Exception: {0}", ex.Message));
                return false;
                throw;
            }

        }

        public List<Model.tootAMessage> getMessages()
        {
            try
            {
                List<Model.tootAMessage> result = new List<Model.tootAMessage>();



                //foreach (Model.tootAMessage item in Messages.Select(x => x.DownloadedByConsole == false).ToList<Model.tootAMessage>())
                //    {
                //    result.Add(item);
                //    item.DownloadedByConsole = true;
                //}

                foreach (Model.tootAMessage item in Messages)
                {
                    if (item.DownloadedByConsole == false)
                    {
                        result.Add(item);
                        item.DownloadedByConsole = true;
                    }
                }


                return result;
            }

            catch (IOException ex)
            {
                AppendToLog(String.Format("An exception was thrown while trying to get the messages. Exception: {0}", ex.Message));

                throw;
            }

        }

        #region AppendToLog
        private readonly string clogfile = ConfigurationManager.AppSettings["LogFile"]; //@"c:\temp\ServiceLog.txt";
        /// <summary>
        /// supersimple method to add a logging row to a log file
        /// </summary>
        /// <param name="_rowToBeAppended"></param>
        private void AppendToLog(string _rowToBeAppended)
        {
            using (StreamWriter w = File.AppendText(clogfile))
            {
                w.WriteLine(string.Format("Servicelog: {0} - {1}", DateTime.Now.ToString("u"), _rowToBeAppended));
                w.Flush();
                w.Close();
            }
        }

        #endregion

    }
}
