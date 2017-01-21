﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "Dal\App.config"
//     Connection String Name: "DbContext"
//     Connection String:      "Server=localhost\SQLEXPRESS;Database=CWMD;Integrated Security=True;"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Express Edition (64-bit)
// Database Engine Edition: Express

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    #region Unit of work

    public interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Document> Documents { get; set; } // Documents
        System.Data.Entity.DbSet<Flow> Flows { get; set; } // Flows
        System.Data.Entity.DbSet<FlowType> FlowTypes { get; set; } // FlowTypes
        System.Data.Entity.DbSet<FlowTypesContributor> FlowTypesContributors { get; set; } // FlowTypes_Contributors
        System.Data.Entity.DbSet<Log> Logs { get; set; } // Logs
        System.Data.Entity.DbSet<Person> People { get; set; } // Persons
        System.Data.Entity.DbSet<Role> Roles { get; set; } // Roles
        System.Data.Entity.DbSet<User> Users { get; set; } // Users

        IDbSet<T> Set<T>() where T : class;
        DbEntityEntry Entry(object entity);

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class MyDbContext : System.Data.Entity.DbContext, IMyDbContext
    {
        public System.Data.Entity.DbSet<Document> Documents { get; set; } // Documents
        public System.Data.Entity.DbSet<Flow> Flows { get; set; } // Flows
        public System.Data.Entity.DbSet<FlowType> FlowTypes { get; set; } // FlowTypes
        public System.Data.Entity.DbSet<FlowTypesContributor> FlowTypesContributors { get; set; } // FlowTypes_Contributors
        public System.Data.Entity.DbSet<Log> Logs { get; set; } // Logs
        public System.Data.Entity.DbSet<Person> People { get; set; } // Persons
        public System.Data.Entity.DbSet<Role> Roles { get; set; } // Roles
        public System.Data.Entity.DbSet<User> Users { get; set; } // Users

        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=DbContext")
        {
        }

        public MyDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new DocumentConfiguration());
            modelBuilder.Configurations.Add(new FlowConfiguration());
            modelBuilder.Configurations.Add(new FlowTypeConfiguration());
            modelBuilder.Configurations.Add(new FlowTypesContributorConfiguration());
            modelBuilder.Configurations.Add(new LogConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new DocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new FlowConfiguration(schema));
            modelBuilder.Configurations.Add(new FlowTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new FlowTypesContributorConfiguration(schema));
            modelBuilder.Configurations.Add(new LogConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonConfiguration(schema));
            modelBuilder.Configurations.Add(new RoleConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            return modelBuilder;
        }

        IDbSet<T> IMyDbContext.Set<T>()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FakeMyDbContext : IMyDbContext
    {
        public System.Data.Entity.DbSet<Document> Documents { get; set; }
        public System.Data.Entity.DbSet<Flow> Flows { get; set; }
        public System.Data.Entity.DbSet<FlowType> FlowTypes { get; set; }
        public System.Data.Entity.DbSet<FlowTypesContributor> FlowTypesContributors { get; set; }
        public System.Data.Entity.DbSet<Log> Logs { get; set; }
        public System.Data.Entity.DbSet<Person> People { get; set; }
        public System.Data.Entity.DbSet<Role> Roles { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }

        public FakeMyDbContext()
        {
            Documents = new FakeDbSet<Document>("Id");
            Flows = new FakeDbSet<Flow>("Id");
            FlowTypes = new FakeDbSet<FlowType>("Id");
            FlowTypesContributors = new FakeDbSet<FlowTypesContributor>("Id", "PersonId");
            Logs = new FakeDbSet<Log>("Id");
            People = new FakeDbSet<Person>("Id");
            Roles = new FakeDbSet<Role>("Id");
            Users = new FakeDbSet<User>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public IDbSet<T> Set<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry Entry(object entity)
        {
            throw new NotImplementedException();
        }
    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TElement>(expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Documents
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Document
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Type { get; set; } // Type (length: 50)
        public System.DateTime AddedDate { get; set; } // AddedDate
        public System.DateTime UpdatedDate { get; set; } // UpdatedDate
        public int PersonId { get; set; } // PersonId
        public int? PrincipalDocumentId { get; set; } // PrincipalDocumentId
        public string Version { get; set; } // Version (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Document> Documents { get; set; } // Documents.FK__Documents__Princ__1B0907CE
        public virtual System.Collections.Generic.ICollection<Flow> Flows { get; set; } // Flows.FK__Flows__Principal__1CF15040

        // Foreign keys
        public virtual Document PrincipalDocument { get; set; } // FK__Documents__Princ__1B0907CE
        public virtual Person Person { get; set; } // FK__Documents__Perso__1A14E395

        public Document()
        {
            AddedDate = System.DateTime.Now;
            UpdatedDate = System.DateTime.Now;
            Documents = new System.Collections.Generic.List<Document>();
            Flows = new System.Collections.Generic.List<Flow>();
        }
    }

    // Flows
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Flow
    {
        public int Id { get; set; } // Id (Primary key)
        public int FlowTypeId { get; set; } // FlowTypeId
        public int PrincipalDocumentId { get; set; } // PrincipalDocumentId
        public int CurrentPersonOrder { get; set; } // CurrentPersonOrder

        // Foreign keys
        public virtual Document Document { get; set; } // FK__Flows__Principal__1CF15040
        public virtual FlowType FlowType { get; set; } // FK__Flows__FlowTypeI__1BFD2C07
    }

    // FlowTypes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FlowType
    {
        public int Id { get; set; } // Id (Primary key)
        public string Type { get; set; } // Type (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Flow> Flows { get; set; } // Flows.FK__Flows__FlowTypeI__1BFD2C07
        public virtual System.Collections.Generic.ICollection<FlowTypesContributor> FlowTypesContributors { get; set; } // Many to many mapping

        public FlowType()
        {
            Flows = new System.Collections.Generic.List<Flow>();
            FlowTypesContributors = new System.Collections.Generic.List<FlowTypesContributor>();
        }
    }

    // FlowTypes_Contributors
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FlowTypesContributor
    {
        public int Id { get; set; } // Id (Primary key)
        public int PersonId { get; set; } // PersonId (Primary key)
        public int PersonOrder { get; set; } // PersonOrder

        // Foreign keys
        public virtual FlowType FlowType { get; set; } // FK__FlowTypes_Co__Id__1DE57479
        public virtual Person Person { get; set; } // FK__FlowTypes__Perso__1ED998B2
    }

    // Logs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Log
    {
        public int Id { get; set; } // Id (Primary key)
        public int UserId { get; set; } // UserId
        public string EventName { get; set; } // EventName (length: 50)
        public string EventDate { get; set; } // EventDate (length: 50)
    }

    // Persons
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Person
    {
        public int Id { get; set; } // Id (Primary key)
        public int RoleId { get; set; } // RoleId
        public string FirstName { get; set; } // FirstName (length: 50)
        public string LastName { get; set; } // LastName (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Document> Documents { get; set; } // Documents.FK__Documents__Perso__1A14E395
        public virtual System.Collections.Generic.ICollection<FlowTypesContributor> FlowTypesContributors { get; set; } // Many to many mapping
        public virtual User User { get; set; } // Users.FK__Users__Id__1AD3FDA4

        // Foreign keys
        public virtual Role Role { get; set; } // FK__Persons__RoleId__1FCDBCEB

        public Person()
        {
            Documents = new System.Collections.Generic.List<Document>();
            FlowTypesContributors = new System.Collections.Generic.List<FlowTypesContributor>();
        }
    }

    // Roles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Role
    {
        public int Id { get; set; } // Id (Primary key)
        public string Role_ { get; set; } // Role (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Person> People { get; set; } // Persons.FK__Persons__RoleId__1FCDBCEB

        public Role()
        {
            People = new System.Collections.Generic.List<Person>();
        }
    }

    // Users
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class User
    {
        public int Id { get; set; } // Id (Primary key)
        public string UserName { get; set; } // UserName (length: 50)
        public string Password { get; set; } // Password (length: 250)

        // Foreign keys
        public virtual Person Person { get; set; } // FK__Users__Id__1AD3FDA4
    }

    #endregion

    #region POCO Configuration

    // Documents
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class DocumentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Document>
    {
        public DocumentConfiguration()
            : this("dbo")
        {
        }

        public DocumentConfiguration(string schema)
        {
            ToTable("Documents", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Type).HasColumnName(@"Type").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.AddedDate).HasColumnName(@"AddedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.PersonId).HasColumnName(@"PersonId").IsRequired().HasColumnType("int");
            Property(x => x.PrincipalDocumentId).HasColumnName(@"PrincipalDocumentId").IsOptional().HasColumnType("int");
            Property(x => x.Version).HasColumnName(@"Version").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.PrincipalDocument).WithMany(b => b.Documents).HasForeignKey(c => c.PrincipalDocumentId).WillCascadeOnDelete(false); // FK__Documents__Princ__1B0907CE
            HasRequired(a => a.Person).WithMany(b => b.Documents).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); // FK__Documents__Perso__1A14E395
        }
    }

    // Flows
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FlowConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Flow>
    {
        public FlowConfiguration()
            : this("dbo")
        {
        }

        public FlowConfiguration(string schema)
        {
            ToTable("Flows", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FlowTypeId).HasColumnName(@"FlowTypeId").IsRequired().HasColumnType("int");
            Property(x => x.PrincipalDocumentId).HasColumnName(@"PrincipalDocumentId").IsRequired().HasColumnType("int");
            Property(x => x.CurrentPersonOrder).HasColumnName(@"CurrentPersonOrder").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Document).WithMany(b => b.Flows).HasForeignKey(c => c.PrincipalDocumentId).WillCascadeOnDelete(false); // FK__Flows__Principal__1CF15040
            HasRequired(a => a.FlowType).WithMany(b => b.Flows).HasForeignKey(c => c.FlowTypeId).WillCascadeOnDelete(false); // FK__Flows__FlowTypeI__1BFD2C07
        }
    }

    // FlowTypes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FlowTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FlowType>
    {
        public FlowTypeConfiguration()
            : this("dbo")
        {
        }

        public FlowTypeConfiguration(string schema)
        {
            ToTable("FlowTypes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Type).HasColumnName(@"Type").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }

    // FlowTypes_Contributors
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class FlowTypesContributorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FlowTypesContributor>
    {
        public FlowTypesContributorConfiguration()
            : this("dbo")
        {
        }

        public FlowTypesContributorConfiguration(string schema)
        {
            ToTable("FlowTypes_Contributors", schema);
            HasKey(x => new { x.Id, x.PersonId });

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName(@"PersonId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PersonOrder).HasColumnName(@"PersonOrder").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.FlowType).WithMany(b => b.FlowTypesContributors).HasForeignKey(c => c.Id).WillCascadeOnDelete(false); // FK__FlowTypes_Co__Id__1DE57479
            HasRequired(a => a.Person).WithMany(b => b.FlowTypesContributors).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); // FK__FlowTypes__Perso__1ED998B2
        }
    }

    // Logs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class LogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
            : this("dbo")
        {
        }

        public LogConfiguration(string schema)
        {
            ToTable("Logs", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.EventName).HasColumnName(@"EventName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.EventDate).HasColumnName(@"EventDate").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }

    // Persons
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class PersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
            : this("dbo")
        {
        }

        public PersonConfiguration(string schema)
        {
            ToTable("Persons", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsRequired().HasColumnType("int");
            Property(x => x.FirstName).HasColumnName(@"FirstName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Role).WithMany(b => b.People).HasForeignKey(c => c.RoleId).WillCascadeOnDelete(false); // FK__Persons__RoleId__1FCDBCEB
        }
    }

    // Roles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
            : this("dbo")
        {
        }

        public RoleConfiguration(string schema)
        {
            ToTable("Roles", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Role_).HasColumnName(@"Role").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }

    // Users
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class UserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            : this("dbo")
        {
        }

        public UserConfiguration(string schema)
        {
            ToTable("Users", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserName).HasColumnName(@"UserName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Password).HasColumnName(@"Password").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(250);

            // Foreign keys
            HasRequired(a => a.Person).WithOptional(b => b.User); // FK__Users__Id__1AD3FDA4
        }
    }

    #endregion

}
// </auto-generated>

