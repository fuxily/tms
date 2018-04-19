using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Tms.BuildingBlocks.EventBusCommon.EventModels
{
    public class SubscriptionInfoModel
    {
        public bool IsDynamic { get; }
        public Type HandlerType { get; }

        private SubscriptionInfoModel(bool isDynamic, Type handlerType)
        {
            IsDynamic = isDynamic;
            HandlerType = handlerType;
        }

        public static SubscriptionInfoModel Dynamic(Type handlerType)
        {
            return new SubscriptionInfoModel(true, handlerType);
        }
        public static SubscriptionInfoModel Typed(Type handlerType)
        {
            return new SubscriptionInfoModel(false, handlerType);
        }
    }
}
