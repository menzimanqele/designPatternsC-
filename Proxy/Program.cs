// See https://aka.ms/new-console-template for more information


using Proxy;

IServer server = new NewServerProxy();

server.ProcessPayment("http://localhost:5000");