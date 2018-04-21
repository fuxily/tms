using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BuildingBlocks.EventBusRabbitMQ
{
    /// <summary>
    /// 建立持久化等rabbitmq连接的接口。
    /// </summary>
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        /// <summary>
        /// 是否已经建立连接。
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// 尝试创建连接。
        /// </summary>
        /// <returns></returns>
        bool TryConnect();

        /// <summary>
        /// 创建rabbitmq的model。
        /// </summary>
        /// <returns></returns>
        IModel CreateModel();
    }
}
