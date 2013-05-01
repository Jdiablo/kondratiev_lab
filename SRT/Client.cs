using System;


namespace SRT {
  class Client {
    public int ClientNumber {get; set;};
    int client_value;

    public Client() {
      Random r = new Random();
      client_value = r.Next(1000000, 9000000);
    }

    public bool SendRequest() {
      Random r = new Random();
      if (r.Next(0, 100) > 98) {
        return true;
      }
      return false;
    }
  }
}
