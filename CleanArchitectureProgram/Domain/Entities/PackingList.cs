using CleanArchitecture.Domain.Exceptions;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class PackingList
    {
        public PackingListId Id { get; private set; }
        public Localization Localization { get; private set; }
        public PackingListName PackingName { get; private set; }

        private readonly LinkedList<PackingItem> _items = new();

        public PackingList(string name, Localization localization, Guid id, LinkedList<PackingItem> items)
        {
            PackingName = name;
            Localization = localization;
            Id = id;
            _items = items;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExist = _items.Any(q=>q.Name == item.Name);

            if (alreadyExist)
            {
                throw new PackingItemAlreadyExistException(PackingName.Value, item.Name);
            }

            _items.AddLast(item);
        }
    }
}
