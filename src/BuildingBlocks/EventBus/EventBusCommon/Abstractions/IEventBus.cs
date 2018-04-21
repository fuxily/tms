using System;
using System.Collections.Generic;
using System.Text;
using Zh.BuildingBlocks.EventBusCommon.EventModels;

namespace Zh.BuildingBlocks.EventBusCommon.Abstractions
{
    public interface IEventBus
    {
        void Publish(IntegrationEventModel @event);

        void Subscribe<T, TH>()
            where T : IntegrationEventModel
            where TH : IIntegrationEventHandler<T>;

        void SubscribeDynamic<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;

        void UnsubscribeDynamic<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;

        void Unsubscribe<T, TH>()
            where TH : IIntegrationEventHandler<T>
            where T : IntegrationEventModel;
    }
}
