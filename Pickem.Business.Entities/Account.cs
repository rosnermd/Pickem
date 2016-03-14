﻿using Core.Common.Contracts;
using Core.Common.Core;
using System.Runtime.Serialization;

namespace Pickem.Business.Entities
{
    [DataContract]
    public class Account : EntityBase, IIdentifiableEntity, IAccountOwnedEntity
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string LoginEmail { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }


        #region IIdentifiableEntity members

        public int Id
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        #endregion

        #region IAccountOwnedEntity

        public int OwnerAccountId
        {
            get { return AccountId; }
        }

        #endregion
    }
}