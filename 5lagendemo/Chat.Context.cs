﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ChatMessage.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class ChatMessageContainer : DbContext
{
    public ChatMessageContainer()
        : base("name=ChatMessageContainer")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<BUChatMessage> ChatMessageSet { get; set; }

}

}

