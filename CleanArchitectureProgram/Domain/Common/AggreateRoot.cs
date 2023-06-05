using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common
{
    public abstract class AggreateRoot<T>
    {
        private readonly List<IDomainEvent> _events = new();
        private bool _versionIncremented;

        public T Id { get; protected set; }
        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent domainEvent)
        {
            if(!_events.Any() && !_versionIncremented)
            {
                Version++;
                _versionIncremented = true;

                _events.Add(domainEvent);
            }
        }

        public void ClearEvent() => _events.Clear();

        protected void IncrementVersion()
        {
            if (_versionIncremented)
            {
                return;
            }

            Version++;
            _versionIncremented = true;
        }
    }
}
