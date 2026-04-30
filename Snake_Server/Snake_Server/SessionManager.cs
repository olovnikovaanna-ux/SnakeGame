using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace Snake_Server
{
    internal class SessionManager
    {
        private static readonly ConcurrentDictionary<Guid, WebSocketGameSession> _sessions = new();

        public static int ActiveCount => _sessions.Count;

        // <param name="webSocket">WebSocket подключение клиента</param>
        // <returns>Идентификатор сессии (для последующего удаления)</returns>
        public static Guid Register(WebSocket webSocket)
        {
            var session = new WebSocketGameSession(webSocket);
            if (_sessions.TryAdd(session.Id, session))
            {
                session.Start();
                return session.Id;
            }
            throw new InvalidOperationException("Не удалось зарегистривать сессию");
        }
       
        // Удаляет сессию и освобождает ресурсы.
        
        public static void Unregister(Guid sessionId)
        {
            if (_sessions.TryRemove(sessionId, out var session))
                session.Dispose();
        }

       
        // Корректно останавливает все сессии (при остановке сервера).
       
        public static void StopAll()
        {
            foreach (var id in _sessions.Keys.ToArray())
                Unregister(id);
        }
    }
}