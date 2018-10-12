// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ProfileCards.ProfilesManagement
{

    // Person
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    internal partial class PersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
            : this("dbo")
        {
        }

        public PersonConfiguration(string schema)
        {
            ToTable("Person", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ProfileImage).HasColumnName(@"ProfileImage").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.BackgroundImage).HasColumnName(@"BackgroundImage").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.SiteId).HasColumnName(@"SiteId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Site).WithMany(b => b.People).HasForeignKey(c => c.SiteId).WillCascadeOnDelete(false); // FK_Person_Site
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
