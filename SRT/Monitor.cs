using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SRT {
  struct ClientInfo {
    public string status;
    public DateTime time;
    public int requestCount;
    public int lastTask;
    public int lastAnsw;
  }

  struct Request {
    public int n;
    public int task;
  }
  class Monitor {
    private static object lck = new object();
    private static bool isCreationMode = false;
    private static int clients = 0;
    private static int servers = 0;
    public static List<Request> queue = new List<Request>();
    public static List<int> results = new List<int>();
    public static Dictionary<int, EventWaitHandle> events = new Dictionary<int, EventWaitHandle>();
    public static List<ClientInfo> statuses = new List<ClientInfo>();
    public static List<Request> serverStat = new List<Request>();

    public static bool StartAddNewClient() {
      lock (lck) {
        if (isCreationMode == true)
          return false;
        
          
        if (clients < 5) {
          ClientInfo info = new ClientInfo();
          info.requestCount = 0;
          info.status = "работа";
          info.lastAnsw = info.lastTask = 0;
          statuses.Add(info);
          clients++;
          isCreationMode = true;
          return true;
        } else
          return false;
      }
    }
    public static bool StartAddNewServer() {
      lock (lck) {
        if (isCreationMode == true)
          return false;

        if (servers < 3) {
          servers++;
          isCreationMode = true;
          return true;
        } else
          return false;
      }
    }
    public static void EndAddNewObject() {
      lock (lck) {
        isCreationMode = false;
      }
    }
    public static void Report(int n, int flg) {
      lock (lck) {
        if (events.ContainsKey(n) == true) {
        } else {
          events.Add(n, new ManualResetEvent(true));
          ClientInfo stt = new ClientInfo();
          stt.status = "работа";
          stt.time = DateTime.Now;
          stt.requestCount = statuses[n].requestCount;
          statuses[n] = stt;

        }
      }
    }
    public static void SendRequest(int n, int task) {
      lock (lck) {
        events[n].Reset();
        Request rqst = new Request();
        rqst.n = n;
        rqst.task = task;
        queue.Add(rqst);
        ClientInfo stt = new ClientInfo();
        stt.status = "ожидание ответа";
        stt.time = DateTime.Now;
        stt.requestCount = statuses[n].requestCount + 1;
        stt.lastTask = task;

        statuses[n] = stt;
      }
    }
    // public SendResult(int
    public static bool CheckQueue() {
      lock (lck) {
        if (queue.Count() == 0)
          return false;
        return true;
      }
    }
    public static Request SolutionRequest() {
      int key;
      int val;
      lock (lck) {
        key = queue.First().n;
        val = queue.First().task;
        //queue.Remove(queue.First());

      }
      Request rqst = new Request();
      rqst.n = key;
      rqst.task = val;
      return rqst;
    }
    public static void SendResult(int n, int result) {
      results[n] = result;
      lock (lck) {
        queue.Remove(queue.First());
        events[n].Set();
        ClientInfo stt = new ClientInfo();
        stt.status = "работа";
        stt.time = DateTime.Now;
        stt.requestCount = statuses[n].requestCount;
        stt.lastAnsw = result;
        statuses[n] = stt;

      }
    }
    public static string[] GetStatuses() {
      lock (lck) {
        string[] stats = new string[5];
        for (int i = 0; i < 5; i++)
          stats[i] = statuses[i].status;
        return stats;
      }
    }
    public static List<Request> GetQueue() {
      lock (lck) {
        List<Request> q = new List<Request>();
        foreach (Request rqst in queue)
          q.Add(rqst);
        return q;
      }
    }
    public static Request GetServer() {
      lock (lck) {
        List<Request> s = new List<Request>();
        foreach (Request rqst in serverStat)
          s.Add(rqst);
        return serverStat.Last();
      }
    }
    public static void ReportServer(int status, int task) {
      lock (lck) {
        Request rqst = new Request();
        rqst.n = status;
        rqst.task = task;

        serverStat.Add(rqst);
      }
    }
  }
}
