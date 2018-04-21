using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BuildingBlocks.EventBusCommon.EventModels
{
    /// <summary>
    /// 集成事件模型。
    /// </summary>
    public class IntegrationEventModel
    {
        public IntegrationEventModel()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        /// <summary>
        /// 集成事件的标识Id。
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// 集成事件的创建时间。
        /// </summary>
        public DateTime CreationDate { get; }
    }
}
