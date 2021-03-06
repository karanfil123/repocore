// <auto-generated />
using System;
using CoreData.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreData.Migrations
{
    [DbContext(typeof(CoreContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreEntity.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 835, DateTimeKind.Local).AddTicks(9666),
                            CreateName = "Bülent",
                            Description = "Kategori açıklası",
                            IsActive = true,
                            Name = "Teknoloji"
                        },
                        new
                        {
                            ID = 2,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 836, DateTimeKind.Local).AddTicks(1601),
                            CreateName = "Bülent",
                            Description = "Telefon açıklası",
                            IsActive = true,
                            Name = "Telefon"
                        });
                });

            modelBuilder.Entity("CoreEntity.Concrete.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 839, DateTimeKind.Local).AddTicks(5560),
                            CreateName = "Admin",
                            Email = "ayl@gmail.com",
                            FirstName = "Aylin",
                            ImageUrl = "asd.jpg",
                            IsActive = true,
                            LastName = "Kırnmızı",
                            Password = "123",
                            RoleID = 1
                        },
                        new
                        {
                            ID = 2,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 840, DateTimeKind.Local).AddTicks(2353),
                            CreateName = "Admin",
                            Email = "mehmet@gmail.com",
                            FirstName = "Mehmet",
                            ImageUrl = "asdqwerty.jpg",
                            IsActive = true,
                            LastName = "Yeşil",
                            Password = "123",
                            RoleID = 2
                        });
                });

            modelBuilder.Entity("CoreEntity.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("ID");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("CoreEntity.Concrete.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 844, DateTimeKind.Local).AddTicks(7407),
                            CreateName = "Admin",
                            CustomerID = 1,
                            Description = "İphone 13 tüm özellikleri",
                            IsActive = true,
                            Name = "İphone13",
                            Price = 19000m,
                            Stock = 1000
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 844, DateTimeKind.Local).AddTicks(7458),
                            CreateName = "Admin",
                            CustomerID = 2,
                            Description = "S20 tüm özellikleri",
                            IsActive = true,
                            Name = "Samsung S20",
                            Price = 12000m,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("CoreEntity.Concrete.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 846, DateTimeKind.Local).AddTicks(5301),
                            CreateName = "Admin",
                            CustomerType = "User",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CreateDate = new DateTime(2022, 4, 2, 14, 4, 32, 846, DateTimeKind.Local).AddTicks(5824),
                            CreateName = "Admin",
                            CustomerType = "Admin",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("CoreEntity.Concrete.Customer", b =>
                {
                    b.HasOne("CoreEntity.Concrete.Role", "Role")
                        .WithMany("Customers")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CoreEntity.Concrete.Product", b =>
                {
                    b.HasOne("CoreEntity.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreEntity.Concrete.Customer", "Customer")
                        .WithMany("Products")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CoreEntity.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CoreEntity.Concrete.Customer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CoreEntity.Concrete.Role", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
