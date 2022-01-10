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
    using System.Threading.Tasks;
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Client;
    using OpenRiaServices.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// The 'student' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/SilverlightWCFRIA.Web")]
    public sealed partial class student : Entity
    {
        
        private long _id;
        
        private int _studentAge;
        
        private string _studentName;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnStudentAgeChanging(int value);
        partial void OnStudentAgeChanged();
        partial void OnStudentNameChanging(string value);
        partial void OnStudentNameChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="student"/> class.
        /// </summary>
        public student()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'ID' value.
        /// </summary>
        // The following attributes were not generated:
        // 
        // - The attribute 'System.ComponentModel.DataAnnotations.EditableAttribute' is not visible in the client project 'SilverlightWCFRIA'. Are you missing an assembly reference?
        // [EditableAttribute(False, AllowInitialValue = True)]
        // 
        // - The attribute 'System.ComponentModel.DataAnnotations.KeyAttribute' is not visible in the client project 'SilverlightWCFRIA'. Are you missing an assembly reference?
        // [KeyAttribute()]
        // 
        // - The attribute 'System.ComponentModel.DataAnnotations.RoundtripOriginalAttribute' is not visible in the client project 'SilverlightWCFRIA'. Are you missing an assembly reference?
        // [RoundtripOriginalAttribute()]
        // 
        [DataMember()]
        public long ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIDChanging(value);
                    this.ValidateProperty("ID", value);
                    this._id = value;
                    this.RaisePropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'StudentAge' value.
        /// </summary>
        [DataMember()]
        public int StudentAge
        {
            get
            {
                return this._studentAge;
            }
            set
            {
                if ((this._studentAge != value))
                {
                    this.OnStudentAgeChanging(value);
                    this.RaiseDataMemberChanging("StudentAge");
                    this.ValidateProperty("StudentAge", value);
                    this._studentAge = value;
                    this.RaiseDataMemberChanged("StudentAge");
                    this.OnStudentAgeChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'StudentName' value.
        /// </summary>
        // The following attributes were not generated:
        // 
        // - The attribute 'System.ComponentModel.DataAnnotations.RequiredAttribute' is not visible in the client project 'SilverlightWCFRIA'. Are you missing an assembly reference?
        // [RequiredAttribute()]
        // 
        // - The attribute 'System.ComponentModel.DataAnnotations.StringLengthAttribute' is not visible in the client project 'SilverlightWCFRIA'. Are you missing an assembly reference?
        // [StringLengthAttribute(50)]
        // 
        [DataMember()]
        public string StudentName
        {
            get
            {
                return this._studentName;
            }
            set
            {
                if ((this._studentName != value))
                {
                    this.OnStudentNameChanging(value);
                    this.RaiseDataMemberChanging("StudentName");
                    this.ValidateProperty("StudentName", value);
                    this._studentName = value;
                    this.RaiseDataMemberChanged("StudentName");
                    this.OnStudentNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'StudentDomainService' DomainService.
    /// </summary>
    public sealed partial class StudentDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentDomainContext"/> class.
        /// </summary>
        public StudentDomainContext() : 
                this(new Uri("SilverlightWCFRIA-Web-StudentDomainService.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The StudentDomainService service URI.</param>
        public StudentDomainContext(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IStudentDomainServiceContract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public StudentDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="student"/> entity instances that have been loaded into this <see cref="StudentDomainContext"/> instance.
        /// </summary>
        public EntitySet<student> students
        {
            get
            {
                return base.EntityContainer.GetEntitySet<student>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="student"/> entity instances using the 'GetStudents' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="student"/> entity instances.</returns>
        public EntityQuery<student> GetStudentsQuery()
        {
            this.ValidateMethod("GetStudentsQuery", null);
            return base.CreateQuery<student>("GetStudents", null, false, true);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="student"/> entity instances using the 'GetStudentsByID' query.
        /// </summary>
        /// <param name="id">The value for the 'id' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="student"/> entity instances.</returns>
        public EntityQuery<student> GetStudentsByIDQuery(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            this.ValidateMethod("GetStudentsByIDQuery", parameters);
            return base.CreateQuery<student>("GetStudentsByID", parameters, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new StudentDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'StudentDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IStudentDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetStudents' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/StudentDomainService/GetStudents", ReplyAction="http://tempuri.org/StudentDomainService/GetStudentsResponse")]
            IAsyncResult BeginGetStudents(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetStudents'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetStudents'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetStudents' operation.</returns>
            QueryResult<student> EndGetStudents(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetStudentsByID' operation.
            /// </summary>
            /// <param name="id">The value for the 'id' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/StudentDomainService/GetStudentsByID", ReplyAction="http://tempuri.org/StudentDomainService/GetStudentsByIDResponse")]
            IAsyncResult BeginGetStudentsByID(int id, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetStudentsByID'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetStudentsByID'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetStudentsByID' operation.</returns>
            QueryResult<student> EndGetStudentsByID(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/StudentDomainService/SubmitChanges", ReplyAction="http://tempuri.org/StudentDomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class StudentDomainContextEntityContainer : EntityContainer
        {
            
            public StudentDomainContextEntityContainer()
            {
                this.CreateEntitySet<student>(EntitySetOperations.All);
            }
        }
    }
}
