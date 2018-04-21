using System;
using System.Collections.Generic;
using System.Text;
using Zh.BuildingBlocks.EventBusCommon.Abstractions;
using Zh.BuildingBlocks.EventBusCommon.EventModels;

namespace Zh.BuildingBlocks.EventBusCommon
{
    public interface IEventBusSubscriptionsManager
    {
        bool IsEmpty { get; }
        event EventHandler<string> OnEventRemoved;
        void AddDynamicSubscription<TH>(string eventName)
           where TH : IDynamicIntegrationEventHandler;

        void AddSubscription<T, TH>()
           where T : IntegrationEventModel
           where TH : IIntegrationEventHandler<T>;

        void RemoveSubscription<T, TH>()
             where TH : IIntegrationEventHandler<T>
             where T : IntegrationEventModel;
        void RemoveDynamicSubscription<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;

        bool HasSubscriptionsForEvent<T>() where T : IntegrationEventModel;
        bool HasSubscriptionsForEvent(string eventName);
        Type GetEventTypeByName(string eventName);
        void Clear();
        IEnumerable<SubscriptionInfoModel> GetHandlersForEvent<T>() where T : IntegrationEventModel;
        IEnumerable<SubscriptionInfoModel> GetHandlersForEvent(string eventName);
        string GetEventKey<T>();
    }
}
