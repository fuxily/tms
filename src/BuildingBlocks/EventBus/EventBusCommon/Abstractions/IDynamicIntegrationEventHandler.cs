using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zh.Tms.BuildingBlocks.EventBusCommon.Abstractions
{
    /// <summary>
    /// 动态集成事件处理器接口。
    /// </summary>
    public interface IDynamicIntegrationEventHandler
    {
        /// <summary>
        /// 处理事件。
        /// </summary>
        /// <param name="eventData" type="dynamic">事件数据。</param>
        /// <returns></returns>
        Task Handle(dynamic eventData);
    }
}
