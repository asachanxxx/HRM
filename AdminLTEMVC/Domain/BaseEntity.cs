using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum EntityStateOption { 
        Active,
        Deleted,
    }

    public abstract class BaseEntity
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; set; }
        public bool Isvalied {
            get {
                return Checkvalied();
            }
        }
        public abstract bool Checkvalied();

    }
}
