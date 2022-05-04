using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisSubPub
{
    public class RedisSubPubCenter
    {
        private readonly ConnectionMultiplexer connectionMultiplexer;
        private readonly string host = ConfigurationHelper.GetConfigString("redisHost");
        public RedisSubPubCenter()
        {
            connectionMultiplexer = ConnectionMultiplexer.Connect(host);
        }

        public void Subscribe(string topic, Action<ChannelMessage> messageHandler)
        {
            var subscriber = connectionMultiplexer.GetSubscriber();
            var channelMsgQueue = subscriber.Subscribe(topic);
            channelMsgQueue.OnMessage(messageHandler);
        }

        public void Publish(string topic, string message)
        {
            var subscriber = connectionMultiplexer.GetSubscriber();
            subscriber.Publish(topic, message);
        }
    }
}
