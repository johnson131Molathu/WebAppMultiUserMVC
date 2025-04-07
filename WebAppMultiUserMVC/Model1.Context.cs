﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMultiUserMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminReg_tab> AdminReg_tab { get; set; }
        public virtual DbSet<Login_tab> Login_tab { get; set; }
        public virtual DbSet<UserReg> UserRegs { get; set; }
    
        public virtual int sp_adminregtab(Nullable<int> aid, string ana, string aaddr, string phone, string aemail)
        {
            var aidParameter = aid.HasValue ?
                new ObjectParameter("aid", aid) :
                new ObjectParameter("aid", typeof(int));
    
            var anaParameter = ana != null ?
                new ObjectParameter("ana", ana) :
                new ObjectParameter("ana", typeof(string));
    
            var aaddrParameter = aaddr != null ?
                new ObjectParameter("aaddr", aaddr) :
                new ObjectParameter("aaddr", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var aemailParameter = aemail != null ?
                new ObjectParameter("aemail", aemail) :
                new ObjectParameter("aemail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_adminregtab", aidParameter, anaParameter, aaddrParameter, phoneParameter, aemailParameter);
        }
    
        public virtual int sp_login(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_login", unaParameter, pwdParameter, status);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_loginCountId(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_loginCountId", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_loginId(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_loginId", unaParameter, pwdParameter);
        }
    
        public virtual int sp_userReg(Nullable<int> uid, string na, Nullable<int> ag, string addr, string em, string ph)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var emParameter = em != null ?
                new ObjectParameter("em", em) :
                new ObjectParameter("em", typeof(string));
    
            var phParameter = ph != null ?
                new ObjectParameter("ph", ph) :
                new ObjectParameter("ph", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_userReg", uidParameter, naParameter, agParameter, addrParameter, emParameter, phParameter);
        }
    
        public virtual int sp_logininsert(Nullable<int> rid, string una, string pwd, string utype)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            var utypeParameter = utype != null ?
                new ObjectParameter("utype", utype) :
                new ObjectParameter("utype", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_logininsert", ridParameter, unaParameter, pwdParameter, utypeParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_MaxIdLogin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_MaxIdLogin");
        }
    
        public virtual ObjectResult<string> sp_loginType(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_loginType", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<sp_selectallusers_Result> sp_selectallusers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_selectallusers_Result>("sp_selectallusers");
        }
    
        public virtual ObjectResult<sp_selectusers_Result> sp_selectusers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_selectusers_Result>("sp_selectusers");
        }
    }
}
