using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusRabbitMQ
{
    //RabbitMQ持久化连接接口
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        //是否已经建立连接。
        bool IsConnected { get; }

        //创建创建连接。
        bool TryConnect();

        //创建消息通道。
        IModel CreateModel();
    }
}
