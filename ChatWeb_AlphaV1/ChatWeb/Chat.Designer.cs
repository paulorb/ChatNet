﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ChatWeb
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ChatContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ChatContainer object using the connection string found in the 'ChatContainer' section of the application configuration file.
        /// </summary>
        public ChatContainer() : base("name=ChatContainer", "ChatContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ChatContainer object.
        /// </summary>
        public ChatContainer(string connectionString) : base(connectionString, "ChatContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ChatContainer object.
        /// </summary>
        public ChatContainer(EntityConnection connection) : base(connection, "ChatContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Friends> FriendsSet
        {
            get
            {
                if ((_FriendsSet == null))
                {
                    _FriendsSet = base.CreateObjectSet<Friends>("FriendsSet");
                }
                return _FriendsSet;
            }
        }
        private ObjectSet<Friends> _FriendsSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Messages> MessagesSet
        {
            get
            {
                if ((_MessagesSet == null))
                {
                    _MessagesSet = base.CreateObjectSet<Messages>("MessagesSet");
                }
                return _MessagesSet;
            }
        }
        private ObjectSet<Messages> _MessagesSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OnLineUsers> OnLineUsersSet
        {
            get
            {
                if ((_OnLineUsersSet == null))
                {
                    _OnLineUsersSet = base.CreateObjectSet<OnLineUsers>("OnLineUsersSet");
                }
                return _OnLineUsersSet;
            }
        }
        private ObjectSet<OnLineUsers> _OnLineUsersSet;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FriendsSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFriendsSet(Friends friends)
        {
            base.AddObject("FriendsSet", friends);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MessagesSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMessagesSet(Messages messages)
        {
            base.AddObject("MessagesSet", messages);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OnLineUsersSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOnLineUsersSet(OnLineUsers onLineUsers)
        {
            base.AddObject("OnLineUsersSet", onLineUsers);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Chat", Name="Friends")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Friends : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Friends object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="username_Friend">Initial value of the Username_Friend property.</param>
        public static Friends CreateFriends(global::System.Int32 id, global::System.String username, global::System.String username_Friend)
        {
            Friends friends = new Friends();
            friends.Id = id;
            friends.Username = username;
            friends.Username_Friend = username_Friend;
            return friends;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username_Friend
        {
            get
            {
                return _Username_Friend;
            }
            set
            {
                OnUsername_FriendChanging(value);
                ReportPropertyChanging("Username_Friend");
                _Username_Friend = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username_Friend");
                OnUsername_FriendChanged();
            }
        }
        private global::System.String _Username_Friend;
        partial void OnUsername_FriendChanging(global::System.String value);
        partial void OnUsername_FriendChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Chat", Name="Messages")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Messages : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Messages object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username_Orig">Initial value of the Username_Orig property.</param>
        /// <param name="username_Dest">Initial value of the Username_Dest property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        /// <param name="message">Initial value of the Message property.</param>
        public static Messages CreateMessages(global::System.Int32 id, global::System.String username_Orig, global::System.String username_Dest, global::System.DateTime date, global::System.String message)
        {
            Messages messages = new Messages();
            messages.Id = id;
            messages.Username_Orig = username_Orig;
            messages.Username_Dest = username_Dest;
            messages.Date = date;
            messages.Message = message;
            return messages;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username_Orig
        {
            get
            {
                return _Username_Orig;
            }
            set
            {
                OnUsername_OrigChanging(value);
                ReportPropertyChanging("Username_Orig");
                _Username_Orig = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username_Orig");
                OnUsername_OrigChanged();
            }
        }
        private global::System.String _Username_Orig;
        partial void OnUsername_OrigChanging(global::System.String value);
        partial void OnUsername_OrigChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username_Dest
        {
            get
            {
                return _Username_Dest;
            }
            set
            {
                OnUsername_DestChanging(value);
                ReportPropertyChanging("Username_Dest");
                _Username_Dest = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username_Dest");
                OnUsername_DestChanged();
            }
        }
        private global::System.String _Username_Dest;
        partial void OnUsername_DestChanging(global::System.String value);
        partial void OnUsername_DestChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Message
        {
            get
            {
                return _Message;
            }
            set
            {
                OnMessageChanging(value);
                ReportPropertyChanging("Message");
                _Message = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Message");
                OnMessageChanged();
            }
        }
        private global::System.String _Message;
        partial void OnMessageChanging(global::System.String value);
        partial void OnMessageChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Chat", Name="OnLineUsers")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OnLineUsers : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OnLineUsers object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="isOnline">Initial value of the IsOnline property.</param>
        public static OnLineUsers CreateOnLineUsers(global::System.Int32 id, global::System.String username, global::System.Boolean isOnline)
        {
            OnLineUsers onLineUsers = new OnLineUsers();
            onLineUsers.Id = id;
            onLineUsers.Username = username;
            onLineUsers.IsOnline = isOnline;
            return onLineUsers;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                if (_Username != value)
                {
                    OnUsernameChanging(value);
                    ReportPropertyChanging("Username");
                    _Username = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsOnline
        {
            get
            {
                return _IsOnline;
            }
            set
            {
                OnIsOnlineChanging(value);
                ReportPropertyChanging("IsOnline");
                _IsOnline = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsOnline");
                OnIsOnlineChanged();
            }
        }
        private global::System.Boolean _IsOnline;
        partial void OnIsOnlineChanging(global::System.Boolean value);
        partial void OnIsOnlineChanged();

        #endregion

    
    }

    #endregion

    
}
