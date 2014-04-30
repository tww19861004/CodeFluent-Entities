﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManager.Services
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated Thursday, 13 February 2014 19:31.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0762")]
    public partial class ContactService : ContactManager.Services.IContactService
    {
        
        public virtual string Validate(ContactManager.Contact contact, string culture)
        {
            System.Globalization.CultureInfo cultureInfo = ConvertUtilities.ToCultureInfo(culture);
            ContactManager.Contact contact1 = contact;
            if ((contact1 == null))
            {
                return default(string);
            }
            return contact1.Validate(cultureInfo);
        }
        
        public virtual bool Delete(ContactManager.Contact contact)
        {
            ContactManager.Contact contact1 = contact;
            if ((contact1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return contact1.Delete();
        }
        
        public virtual ContactManager.Contact Load(int id)
        {
            return ContactManager.Contact.Load(id);
        }
        
        public virtual ContactManager.Contact LoadByEmail(string email)
        {
            return ContactManager.Contact.LoadByEmail(email);
        }
        
        public virtual ContactManager.Contact LoadByAddress(int addressId)
        {
            return ContactManager.Contact.LoadByAddress(addressId);
        }
        
        public virtual bool Save(ContactManager.Contact contact)
        {
            ContactManager.Contact contact1 = contact;
            if ((contact1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return contact1.Save();
        }
        
        public virtual bool SaveByRef(ref ContactManager.Contact contact)
        {
            ContactManager.Contact contact1 = contact;
            if ((contact1 == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            bool ret = contact1.Save();
            contact = contact1;
            return ret;
        }
        
        public virtual ContactManager.Contact LoadByEntityKey(string key)
        {
            return ContactManager.Contact.LoadByEntityKey(key);
        }
        
        public virtual bool DeleteByKey(int id)
        {
            ContactManager.Contact contact = ContactManager.Contact.Load(id);
            if ((contact == null))
            {
                return CodeFluentPersistence.DefaultBooleanValue;
            }
            return contact.Delete();
        }
        
        public virtual void SaveAll(ContactManager.ContactCollection contactCollection)
        {
            ContactManager.ContactCollection contactCollection1 = contactCollection;
            contactCollection1.SaveAll();
        }
        
        public virtual ContactManager.ContactCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            return ContactManager.ContactCollection.PageLoadAll(pageIndex, pageSize, pageOptions);
        }
        
        public virtual ContactManager.ContactCollection LoadAll()
        {
            return ContactManager.ContactCollection.LoadAll();
        }
        
        public virtual ContactManager.ContactCollection PageLoadByContactSource(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, string contactSourceEntityKey)
        {
            if ((contactSourceEntityKey == null))
            {
                throw new System.ArgumentNullException("contactSourceEntityKey");
            }
            ContactManager.ContactSource contactSource = ContactManager.ContactSource.LoadByEntityKey(contactSourceEntityKey);
            return ContactManager.ContactCollection.PageLoadByContactSource(pageIndex, pageSize, pageOptions, contactSource);
        }
        
        public virtual ContactManager.ContactCollection LoadByContactSource(string contactSourceEntityKey)
        {
            if ((contactSourceEntityKey == null))
            {
                throw new System.ArgumentNullException("contactSourceEntityKey");
            }
            ContactManager.ContactSource contactSource = ContactManager.ContactSource.LoadByEntityKey(contactSourceEntityKey);
            return ContactManager.ContactCollection.LoadByContactSource(contactSource);
        }
        
        public virtual ContactManager.ContactCollection PageLoadByUser(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, string userEntityKey)
        {
            if ((userEntityKey == null))
            {
                throw new System.ArgumentNullException("userEntityKey");
            }
            ContactManager.User user = ContactManager.User.LoadByEntityKey(userEntityKey);
            return ContactManager.ContactCollection.PageLoadByUser(pageIndex, pageSize, pageOptions, user);
        }
        
        public virtual ContactManager.ContactCollection LoadByUser(string userEntityKey)
        {
            if ((userEntityKey == null))
            {
                throw new System.ArgumentNullException("userEntityKey");
            }
            ContactManager.User user = ContactManager.User.LoadByEntityKey(userEntityKey);
            return ContactManager.ContactCollection.LoadByUser(user);
        }
    }
}