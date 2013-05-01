using System;


namespace SRT {
  class Client {
    public int ClientNumber {get; set;}
    int client_value;

    public Client() {
      Random r = new Random();
      client_value = r.Next(1000000, 9000000);
    }

    /// <summary>
    /// Функция смены состояния готовности отправить ответ
    /// </summary>
    /// <returns></returns>
    public bool SendRequest() 
    {
        // Флаг смены состояния   
        bool IsReady = false;
        while (IsReady == false)
            if (new Random().Next(0, 100) > 98)            
                IsReady = true;            
        return IsReady;
    }
      /// <summary>
      /// Событие изменения состояния клиента - готов работать
      /// </summary>
    public event EventHandler ChangingState;

    /// <summary>
    /// Генератор события смены состояния
    /// </summary>
    /// <param name="args"></param>
    protected virtual void OnChangingState(EventArgs args)
    {
        this.SendRequest();
        this.ChangingState(this, args);
    }
  }
}
