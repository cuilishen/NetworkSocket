﻿using NetworkSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebsocketChatServer
{
    /// <summary>
    /// 昵称设置过滤器
    /// </summary>
    public class NickNameFilter : JsonWebSocketFilterAttribute
    {
        public NickNameFilter()
        {
            this.Order = -1;
        }

        protected override void OnExecuting(ActionContext filterContext)
        {
            if (filterContext.Session.TagBag.Name == null)
            {
                // 未设置昵称的将抛出异常给客户端
                throw new Exception("请设置昵称后再聊天 ..");
            }
        }
    }
}