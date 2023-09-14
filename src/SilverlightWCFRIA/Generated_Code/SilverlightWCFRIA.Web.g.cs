//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilverlightWCFRIA.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Threading;
    using System.Threading.Tasks;
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Client;
    using OpenRiaServices.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'AuthenticationService' DomainService.
    /// </summary>
    public sealed partial class AuthenticationContext : global::OpenRiaServices.DomainServices.Client.ApplicationServices.AuthenticationDomainContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        ///This method is invoked from the constructor once initialization is complete and
        ///can be used for further object setup.
        ///</summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationContext"/> class.
        /// </summary>
        public AuthenticationContext() : 
                this(new Uri("SilverlightWCFRIA-Web-AuthenticationService.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The AuthenticationService service URI.</param>
        public AuthenticationContext(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IAuthenticationServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public AuthenticationContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="User"/> entity instances that have been loaded into this <see cref="AuthenticationContext"/> instance.
        /// </summary>
        public EntitySet<User> Users
        {
            get
            {
                return base.EntityContainer.GetEntitySet<User>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User"/> entity instances using the 'GetUser' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User"/> entity instances.</returns>
        public EntityQuery<User> GetUserQuery()
        {
            this.ValidateMethod("GetUserQuery", null);
            return base.CreateQuery<User>("GetUser", null, false, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User"/> entity instances using the 'Login' query.
        /// </summary>
        /// <param name="userName">The value for the 'userName' parameter of the query.</param>
        /// <param name="password">The value for the 'password' parameter of the query.</param>
        /// <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        /// <param name="customData">The value for the 'customData' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User"/> entity instances.</returns>
        public EntityQuery<User> LoginQuery(string userName, string password, bool isPersistent, string customData)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("userName", userName);
            parameters.Add("password", password);
            parameters.Add("isPersistent", isPersistent);
            parameters.Add("customData", customData);
            this.ValidateMethod("LoginQuery", parameters);
            return base.CreateQuery<User>("Login", parameters, true, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User"/> entity instances using the 'Logout' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User"/> entity instances.</returns>
        public EntityQuery<User> LogoutQuery()
        {
            this.ValidateMethod("LogoutQuery", null);
            return base.CreateQuery<User>("Logout", null, true, false);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new AuthenticationContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'AuthenticationService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IAuthenticationServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetUser' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService/GetUser", ReplyAction="http://tempuri.org/AuthenticationService/GetUserResponse")]
            IAsyncResult BeginGetUser(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetUser'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            QueryResult<User> EndGetUser(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Login' operation.
            /// </summary>
            /// <param name="userName">The value for the 'userName' parameter of this action.</param>
            /// <param name="password">The value for the 'password' parameter of this action.</param>
            /// <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            /// <param name="customData">The value for the 'customData' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService/Login", ReplyAction="http://tempuri.org/AuthenticationService/LoginResponse")]
            IAsyncResult BeginLogin(string userName, string password, bool isPersistent, string customData, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogin'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            /// <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            QueryResult<User> EndLogin(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Logout' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService/Logout", ReplyAction="http://tempuri.org/AuthenticationService/LogoutResponse")]
            IAsyncResult BeginLogout(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogout'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            /// <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            QueryResult<User> EndLogout(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService/SubmitChanges", ReplyAction="http://tempuri.org/AuthenticationService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class AuthenticationContextEntityContainer : EntityContainer
        {
            
            public AuthenticationContextEntityContainer()
            {
                this.CreateEntitySet<User>(EntitySetOperations.Edit);
            }
        }
    }
    
    /// <summary>
    /// Enum CreateUserStatus
    /// </summary>
    public enum CreateUserStatus
    {
        
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// InvalidUserName
        /// </summary>
        InvalidUserName = 1,
        
        /// <summary>
        /// InvalidPassword
        /// </summary>
        InvalidPassword = 2,
        
        /// <summary>
        /// InvalidQuestion
        /// </summary>
        InvalidQuestion = 3,
        
        /// <summary>
        /// InvalidAnswer
        /// </summary>
        InvalidAnswer = 4,
        
        /// <summary>
        /// InvalidEmail
        /// </summary>
        InvalidEmail = 5,
        
        /// <summary>
        /// DuplicateUserName
        /// </summary>
        DuplicateUserName = 6,
        
        /// <summary>
        /// DuplicateEmail
        /// </summary>
        DuplicateEmail = 7,
        
        /// <summary>
        /// Failure
        /// </summary>
        Failure = 8,
    }
    
    /// <summary>
    /// The 'RegistrationData' class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightWCFRIA.Web")]
    public sealed partial class RegistrationData : ComplexObject
    {
        
        private string _answer;
        
        private string _email;
        
        private string _friendlyName;
        
        private string _question;
        
        private string _userName;
        
        #region Extensibility Method Definitions

        /// <summary>
        ///This method is invoked from the constructor once initialization is complete and
        ///can be used for further object setup.
        ///</summary>
        partial void OnCreated();
        partial void OnAnswerChanging(string value);
        partial void OnAnswerChanged();
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        partial void OnFriendlyNameChanging(string value);
        partial void OnFriendlyNameChanged();
        partial void OnQuestionChanging(string value);
        partial void OnQuestionChanged();
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationData"/> class.
        /// </summary>
        public RegistrationData()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Answer' value.
        /// </summary>
        [DataMember()]
        [Display(Name="Security answer", Order=6)]
        [Required(ErrorMessage="This field is required")]
        [StringLength(128, ErrorMessage="The security answer cannot be more than 128 characters long")]
        public string Answer
        {
            get
            {
                return this._answer;
            }
            set
            {
                if ((this._answer != value))
                {
                    this.OnAnswerChanging(value);
                    this.RaiseDataMemberChanging("Answer");
                    this.ValidateProperty("Answer", value);
                    this._answer = value;
                    this.RaiseDataMemberChanged("Answer");
                    this.OnAnswerChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Email' value.
        /// </summary>
        [DataMember()]
        [Display(Name="Email", Order=2)]
        [RegularExpression("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4" +
            "}|[0-9]{1,3})(\\]?)$", ErrorMessage="Invalid email. An email must use the format user@company.com")]
        [Required(ErrorMessage="This field is required")]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if ((this._email != value))
                {
                    this.OnEmailChanging(value);
                    this.RaiseDataMemberChanging("Email");
                    this.ValidateProperty("Email", value);
                    this._email = value;
                    this.RaiseDataMemberChanged("Email");
                    this.OnEmailChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'FriendlyName' value.
        /// </summary>
        [DataMember()]
        [Display(Description="How do you want your name to be displayed in the application", Name="Friendly name", Order=1)]
        [StringLength(255, ErrorMessage="The friendly name cannot be more than 255 characters long")]
        public string FriendlyName
        {
            get
            {
                return this._friendlyName;
            }
            set
            {
                if ((this._friendlyName != value))
                {
                    this.OnFriendlyNameChanging(value);
                    this.RaiseDataMemberChanging("FriendlyName");
                    this.ValidateProperty("FriendlyName", value);
                    this._friendlyName = value;
                    this.RaiseDataMemberChanged("FriendlyName");
                    this.OnFriendlyNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Question' value.
        /// </summary>
        [DataMember()]
        [Display(Name="Security question", Order=5)]
        [Required(ErrorMessage="This field is required")]
        public string Question
        {
            get
            {
                return this._question;
            }
            set
            {
                if ((this._question != value))
                {
                    this.OnQuestionChanging(value);
                    this.RaiseDataMemberChanging("Question");
                    this.ValidateProperty("Question", value);
                    this._question = value;
                    this.RaiseDataMemberChanged("Question");
                    this.OnQuestionChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'UserName' value.
        /// </summary>
        [DataMember()]
        [Display(Name="User name", Order=0)]
        [RegularExpression("^[a-zA-Z0-9_]*$", ErrorMessage="Invalid user name. It must contain only alphanumeric characters")]
        [Required(ErrorMessage="This field is required")]
        [StringLength(255, ErrorMessage="The user name must be at least 4 and at most 255 characters long", MinimumLength=4)]
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                if ((this._userName != value))
                {
                    this.OnUserNameChanging(value);
                    this.RaiseDataMemberChanging("UserName");
                    this.ValidateProperty("UserName", value);
                    this._userName = value;
                    this.RaiseDataMemberChanged("UserName");
                    this.OnUserNameChanged();
                }
            }
        }
    }
    
    /// <summary>
    /// The 'User' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightWCFRIA.Web")]
    public sealed partial class User : Entity, global::System.Security.Principal.IIdentity, global::System.Security.Principal.IPrincipal
    {
        
        private string _friendlyName;
        
        private string _name = string.Empty;
        
        private IEnumerable<string> _roles;
        
        #region Extensibility Method Definitions

        /// <summary>
        ///This method is invoked from the constructor once initialization is complete and
        ///can be used for further object setup.
        ///</summary>
        partial void OnCreated();
        partial void OnFriendlyNameChanging(string value);
        partial void OnFriendlyNameChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnRolesChanging(IEnumerable<string> value);
        partial void OnRolesChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'FriendlyName' value.
        /// </summary>
        [DataMember()]
        public string FriendlyName
        {
            get
            {
                return this._friendlyName;
            }
            set
            {
                if ((this._friendlyName != value))
                {
                    this.OnFriendlyNameChanging(value);
                    this.RaiseDataMemberChanging("FriendlyName");
                    this.ValidateProperty("FriendlyName", value);
                    this._friendlyName = value;
                    this.RaiseDataMemberChanged("FriendlyName");
                    this.OnFriendlyNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Name' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnNameChanging(value);
                    this.ValidateProperty("Name", value);
                    this._name = value;
                    this.RaisePropertyChanged("Name");
                    this.OnNameChanged();
                    this.RaisePropertyChanged("IsAuthenticated");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Roles' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public IEnumerable<string> Roles
        {
            get
            {
                return this._roles;
            }
            set
            {
                if ((this._roles != value))
                {
                    this.OnRolesChanging(value);
                    this.ValidateProperty("Roles", value);
                    this._roles = value;
                    this.RaisePropertyChanged("Roles");
                    this.OnRolesChanged();
                }
            }
        }
        
        string global::System.Security.Principal.IIdentity.AuthenticationType
        {
            get
            {
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the identity is authenticated.
        /// </summary>
        /// <remarks>
        /// This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        /// </remarks>
        public bool IsAuthenticated
        {
            get
            {
                return (true != string.IsNullOrEmpty(this.Name));
            }
        }
        
        string global::System.Security.Principal.IIdentity.Name
        {
            get
            {
                return this.Name;
            }
        }
        
        global::System.Security.Principal.IIdentity global::System.Security.Principal.IPrincipal.Identity
        {
            get
            {
                return this;
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._name;
        }
        
        /// <summary>
        /// Return whether the principal is in the role.
        /// </summary>
        /// <remarks>
        /// Returns whether the specified role is contained in the roles.
        /// This implementation is case sensitive.
        /// </remarks>
        /// <param name="role">The name of the role for which to check membership.</param>
        /// <returns>Whether the principal is in the role.</returns>
        public bool IsInRole(string role)
        {
            if ((this.Roles == null))
            {
                return false;
            }
            return global::System.Linq.Enumerable.Contains(this.Roles, role);
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'UserRegistrationService' DomainService.
    /// </summary>
    public sealed partial class UserRegistrationContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        ///This method is invoked from the constructor once initialization is complete and
        ///can be used for further object setup.
        ///</summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationContext"/> class.
        /// </summary>
        public UserRegistrationContext() : 
                this(new Uri("SilverlightWCFRIA-Web-UserRegistrationService.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The UserRegistrationService service URI.</param>
        public UserRegistrationContext(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IUserRegistrationServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public UserRegistrationContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Asynchronously invokes the 'CreateUser' method of the DomainService.
        /// </summary>
        /// <param name="user">The value for the 'user' parameter of this action.</param>
        /// <param name="password">The value for the 'password' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<CreateUserStatus> CreateUser(RegistrationData user, [RegularExpression("^.*[^a-zA-Z0-9].*$", ErrorMessage="A password needs to contain at least one special character e.g. @ or #")] [Required(ErrorMessage="This field is required")] [StringLength(50, ErrorMessage="Password must be at least 7 and at most 50 characters long", MinimumLength=7)] string password, Action<InvokeOperation<CreateUserStatus>> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("user", user);
            parameters.Add("password", password);
            this.ValidateMethod("CreateUser", parameters);
            return this.InvokeOperation<CreateUserStatus>("CreateUser", typeof(CreateUserStatus), parameters, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'CreateUser' method of the DomainService.
        /// </summary>
        /// <param name="user">The value for the 'user' parameter of this action.</param>
        /// <param name="password">The value for the 'password' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<CreateUserStatus> CreateUser(RegistrationData user, [RegularExpression("^.*[^a-zA-Z0-9].*$", ErrorMessage="A password needs to contain at least one special character e.g. @ or #")] [Required(ErrorMessage="This field is required")] [StringLength(50, ErrorMessage="Password must be at least 7 and at most 50 characters long", MinimumLength=7)] string password)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("user", user);
            parameters.Add("password", password);
            this.ValidateMethod("CreateUser", parameters);
            return this.InvokeOperation<CreateUserStatus>("CreateUser", typeof(CreateUserStatus), parameters, true, null, null);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'CreateUser' method of the DomainService.
        /// </summary>
        /// <param name="user">The value for the 'user' parameter of this action.</param>
        /// <param name="password">The value for the 'password' parameter of this action.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public System.Threading.Tasks.Task<InvokeResult<CreateUserStatus>> CreateUserAsync(RegistrationData user, [RegularExpression("^.*[^a-zA-Z0-9].*$", ErrorMessage="A password needs to contain at least one special character e.g. @ or #")] [Required(ErrorMessage="This field is required")] [StringLength(50, ErrorMessage="Password must be at least 7 and at most 50 characters long", MinimumLength=7)] string password, CancellationToken cancellationToken = default(CancellationToken))
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("user", user);
            parameters.Add("password", password);
            this.ValidateMethod("CreateUser", parameters);
            return this.InvokeOperationAsync<CreateUserStatus>("CreateUser", parameters, true, cancellationToken);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new UserRegistrationContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'UserRegistrationService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IUserRegistrationServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'CreateUser' operation.
            /// </summary>
            /// <param name="user">The value for the 'user' parameter of this action.</param>
            /// <param name="password">The value for the 'password' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/UserRegistrationService/CreateUser", ReplyAction="http://tempuri.org/UserRegistrationService/CreateUserResponse")]
            IAsyncResult BeginCreateUser(RegistrationData user, string password, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginCreateUser'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginCreateUser'.</param>
            /// <returns>The 'CreateUserStatus' returned from the 'CreateUser' operation.</returns>
            CreateUserStatus EndCreateUser(IAsyncResult result);
        }
        
        internal sealed class UserRegistrationContextEntityContainer : EntityContainer
        {
            
            public UserRegistrationContextEntityContainer()
            {
            }
        }
    }
}
