using AnnaStore.SharedKernel;
using AnnaStore.SharedKernel.Events;
using System;
using System.Collections.Generic;

namespace AnnaStore.CrossCutting
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Dispose()
        {
            this._notifications = new List<DomainNotification>();
        }

        public List<DomainNotification> GetValue()
        {
            return _notifications;
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }
    }
}