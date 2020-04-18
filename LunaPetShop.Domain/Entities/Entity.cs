using System;

namespace LunaPetShop.Domain.Entities {
    public abstract class Entity {
        public Entity () {
            this.Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
    }
}