using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Events;
using CleanArchitecture.Domain.Exceptions;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class PackingList : AggreateRoot<PackingListId>
    {
        public PackingListId Id { get; private set; }

        private Localization _localization;
        private PackingListName _packingName;

        private readonly LinkedList<PackingItem> _items = new();

        private PackingList(PackingListName PackingName, Localization localization, PackingListId id, LinkedList<PackingItem> items)
            : this(id, localization, PackingName)
        {
            AddItems(items);
        }

        private PackingList()
        {
        }

        internal PackingList(PackingListId id, Localization localization, PackingListName packingName)
        {
            Id = id;
            _localization = localization;
            _packingName = packingName;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExist = _items.Any(q=>q.Name == item.Name);

            if (alreadyExist)
            {
                throw new PackingItemAlreadyExistException(_packingName.Value, item.Name);
            }

            _items.AddLast(item);
            AddEvent(new PackingItemAdded(this, item));
        }

        public void AddItems(IEnumerable<PackingItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }

        public void PackItem(string itemName)
        {
            var item = GetItem(itemName);
            var packedItem = item with { IsPacked = true };

            _items.Find(item).Value = packedItem;
            AddEvent(new PackingItemPacked(this, item));
        }

        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
            AddEvent(new PackingItemRemoved(this, item));
        }

        private PackingItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(q=>q.Name == itemName);

            if(item is null)
            {
                throw new PackingItemNotFoundException(itemName);
            }

            return item;
        }
    }
}
