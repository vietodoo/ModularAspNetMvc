﻿namespace FieldReporting.Infrastructure.Eventing
{
    public interface IEventSubscriber<in TEventType> 
    {
        void Receive(TEventType @event);
    }
}
