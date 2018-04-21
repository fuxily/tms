using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zh.BuildingBlocks.EventBusCommon.EventModels;

namespace Zh.BuildingBlocks.EventBusCommon.Abstractions
{

    /// <summary>
    /// 集成事件处理器泛型接口。
    /// </summary>
    /// <typeparam name="TIntegrationEvent">此类型参数必须是IntegrationEventModel类的实例。</typeparam>
    public interface IIntegrationEventHandler<in TIntegrationEventModel> : IIntegrationEventHandler
        where TIntegrationEventModel : IntegrationEventModel
    {
        /// <summary>
        /// 处理事件。
        /// </summary>
        /// <param name="event">事件数据。</param>
        /// <returns></returns>
        Task Handle(TIntegrationEventModel @event);
    }

    /// <summary>
    /// 集成事件处理器接口。
    /// </summary>
    public interface IIntegrationEventHandler
    {
    }
}
