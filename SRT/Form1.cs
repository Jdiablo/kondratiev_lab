using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRT
{
    struct Info
    {
        public int n;
    }
    public partial class Form1 : Form
    {
        static bool theEnd = false;
        static int threadN = 0;
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Lowest;
            Info info = (Info)e.Argument;
            int RequestWish = 0;
            Monitor.EndAddNewObject();
            while (theEnd != true)
            {
                Monitor.Report(info.n, 1);
                while (RequestWish < 98)
                {
                    RequestWish = rnd.Next(0, 100);
                    System.Threading.Thread.Sleep(100);
                }
                Monitor.SendRequest(info.n, rnd.Next(1000000,9000000));
                worker.ReportProgress(info.n);
                //System.Threading.Thread.Sleep(100);
                Monitor.events[info.n].WaitOne();
            }

            //Monitor.DeleteObject(info.n);
        }

        private void backgroundWorker_DoServerWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Lowest;
            Monitor.EndAddNewObject();
            while (theEnd != true)
            {
                if (Monitor.CheckQueue() == false)
                {
                    System.Threading.Thread.Sleep(100);
                    Monitor.ReportServer(0, 0);
                }
                else
                {
                    Request rqst = new Request();
                   // System.Threading.Thread.Sleep(500);
                    System.Threading.Thread.Sleep(2000);
                    rqst = Monitor.SolutionRequest();
                    Monitor.ReportServer(1, rqst.task);
                    worker.ReportProgress(10);
                    Monitor.SendResult(rqst.n, rqst.task + 49517537);
                    //worker.ReportProgress(20);
                }
                    //
            }

        }
        void backgroundWorker_ServerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Request stat = Monitor.GetServer();
            /*foreach (Request rqst in stat)
            {*/
                if (stat.n == 0)
                {
                    this.dataGVServers.Rows[0].Cells[0].Value = "сон";
                }
                else
                {
                    this.dataGVServers.Rows[0].Cells[0].Value = "обработка";
                    this.dataGVServers.Rows[1].Cells[0].Value = stat.task.ToString() + " + 49517537";
                }
           // }
            string[] stats = Monitor.GetStatuses();
            for (int i = 0; i < 5; i++)
                this.dataGVClients.Rows[0].Cells[i].Value = stats[i];

            List<Request> queue = Monitor.GetQueue();
            this.dataGVQueue.Rows.Clear();
            int j = 0;
            foreach (Request rqst in queue)
            {
                this.dataGVQueue.Rows.Add();
                this.dataGVQueue.Rows[j].Cells[0].Value = rqst.n.ToString();
                this.dataGVQueue.Rows[j].Cells[1].Value = rqst.task.ToString();
                j++;
            }
        }
        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;
            string[] stats = Monitor.GetStatuses();
            List<ClientInfo> info = Monitor.statuses;
            //for (int i = 0; i < 5; i++)
            //{
                this.dataGVClients.Rows[0].Cells[i].Value = info[i].status;
                this.dataGVClients.Rows[1].Cells[i].Value = info[i].requestCount;
                if (info[i].requestCount > this.dataGVClients.RowCount-3)
                {
                    this.dataGVClients.Rows.Add();
                    //this.dataGVClients.Rows.Add();
                    //this.dataGVClients.Rows.Add();

                }
                this.dataGVClients.Rows[info[i].requestCount+1].Cells[i].Value = info[i].lastTask;
                //this.dataGVClients.Rows[info[i].requestCount].Cells[i].Value = info[i].lastAnsw;
            //}
            /*
            List<Request> queue = Monitor.GetQueue();
            this.dataGVQueue.Rows.Clear();
            int j = 0;
            foreach (Request rqst in queue)
            {
                this.dataGVQueue.Rows.Add();
                this.dataGVQueue.Rows[j].Cells[0].Value = rqst.n.ToString();
                this.dataGVQueue.Rows[j].Cells[1].Value = rqst.task.ToString();
                j++;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGVClients.Rows.Add();
            this.dataGVServers.Rows.Add();
            this.dataGVServers.Rows.Add();
            for (int i = 0; i < 1; i++)
            {
                Monitor.StartAddNewServer();
                BackgroundWorker t = new BackgroundWorker();
                t.WorkerReportsProgress = true;
                t.WorkerSupportsCancellation = false;
                t.DoWork += new DoWorkEventHandler(backgroundWorker_DoServerWork);
                t.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ServerProgressChanged);
                // ClientInfo info = new ClientInfo();
                //info.n = threadN++;
                t.RunWorkerAsync();
                Monitor.EndAddNewObject();
            }

            for (int i = 0; i < 5; i++)
            {
                threadN = i;
                Monitor.StartAddNewClient();
                BackgroundWorker t = new BackgroundWorker();
                t.WorkerReportsProgress = true;
                t.WorkerSupportsCancellation = false;
                t.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                t.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                Info info = new Info();
                info.n = i;
                Monitor.events.Add(info.n,new System.Threading.ManualResetEvent(true));
                ClientInfo clientInfo = new ClientInfo();
                clientInfo.status = "работа";
                clientInfo.requestCount = 0;
                Monitor.statuses.Add(clientInfo);
                Monitor.results.Add(0);
                t.RunWorkerAsync(info);
                
            }
        }

           /* string[] stats = Monitor.GetStatuses();
            for (int i = 0; i < 5; i++)
                this.dataGVClients.Rows[0].Cells[i].Value = stats[i];
            
            List<Request> queue = Monitor.GetQueue();
            this.dataGVQueue.Rows.Clear();
            int j=0;
            foreach (Request rqst in queue)
            {
                this.dataGVQueue.Rows.Add();
                this.dataGVQueue.Rows[j].Cells[0].Value = rqst.n.ToString();
                this.dataGVQueue.Rows[j].Cells[1].Value = rqst.task.ToString();
                j++;
            }

            List<Request> stat = Monitor.GetServer();
            foreach (Request rqst in stat)
            {
                if (rqst.n == 0)
                {
                    this.dataGVServers.Rows[0].Cells[0].Value = "сон";
                }
                else
                {
                    this.dataGVServers.Rows[0].Cells[0].Value = "обработка";
                    this.dataGVServers.Rows.Add(rqst.task.ToString(), " ", " ");
                }
            }*/

    }
}
