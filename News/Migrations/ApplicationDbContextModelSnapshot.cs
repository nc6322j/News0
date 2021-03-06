// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "0510656f-30d5-4caf-92b6-585ccb92b2e6",
                            RoleId = "020ddda2-387b-47e7-ab1c-d29ea211bbdf"
                        },
                        new
                        {
                            UserId = "53f3c157-5372-4523-801d-3624234edded",
                            RoleId = "eb0b232e-af5f-419f-ba81-d69184ea6c6b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            category_Id = "8464ddb0-a549-43aa-b974-1a84a7de7b21",
                            IsDelete = false,
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "d4cfd95f-73ed-48b4-8fcf-583618990c11",
                            IsDelete = false,
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "e84f3d54-9184-4e70-b967-89f9d889e0e8",
                            IsDelete = false,
                            category_Description = "Des 3",
                            category_Name = "Category3"
                        });
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.Property<string>("cmt_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("cmt_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmt_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("cmt_UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cmt_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cmt_Id");

                    b.HasIndex("cmt_IdeaId");

                    b.HasIndex("cmt_UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            cmt_Id = "7bff4340-0ac7-4d52-a943-421ddee5c70f",
                            IsDelete = false,
                            cmt_Content = "Comment1",
                            cmt_IdeaId = "792577e7-3f3f-4c19-a839-3a8ccbbb6b9a",
                            cmt_UpdateDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "53f3c157-5372-4523-801d-3624234edded"
                        },
                        new
                        {
                            cmt_Id = "2f0c61b0-8ad6-46e7-b387-edac13ed9220",
                            IsDelete = false,
                            cmt_Content = "Comment2",
                            cmt_IdeaId = "792577e7-3f3f-4c19-a839-3a8ccbbb6b9a",
                            cmt_UpdateDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "0510656f-30d5-4caf-92b6-585ccb92b2e6"
                        },
                        new
                        {
                            cmt_Id = "2d7000fb-6e8e-4b74-be6d-8d3012294f95",
                            IsDelete = false,
                            cmt_Content = "Comment3",
                            cmt_IdeaId = "792577e7-3f3f-4c19-a839-3a8ccbbb6b9a",
                            cmt_UpdateDate = new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "53f3c157-5372-4523-801d-3624234edded"
                        });
                });

            modelBuilder.Entity("News.Entities.ContactEmail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactEmail");

                    b.HasData(
                        new
                        {
                            Id = "9fce8974-701d-4ce3-921c-6485c53e3b1d",
                            Email = "Email Test",
                            Message = "Message Test",
                            Name = "Name Test",
                            Subject = "Subject Test"
                        });
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            department_Id = "a98ed757-c447-4613-a8ad-b12e1818ed31",
                            IsDelete = false,
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "42f8de0f-a392-4bad-a690-9938944d72f3",
                            IsDelete = false,
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "16b6a1ec-90d8-4008-8765-3d8d9950f8c9",
                            IsDelete = false,
                            department_Description = "Department 3",
                            department_Name = "Department 3"
                        });
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("idea_Agree")
                        .HasColumnType("bit");

                    b.Property<string>("idea_CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idea_View")
                        .HasColumnType("int");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_SubmissionId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea");

                    b.HasData(
                        new
                        {
                            idea_Id = "792577e7-3f3f-4c19-a839-3a8ccbbb6b9a",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "8464ddb0-a549-43aa-b974-1a84a7de7b21",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-1.png",
                            idea_SubmissionId = "15dae071-0e4c-4b08-8f61-1cdf45f3b389",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "0510656f-30d5-4caf-92b6-585ccb92b2e6",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "05aedb3e-584a-4434-8aaf-1c99ac84fab2",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "d4cfd95f-73ed-48b4-8fcf-583618990c11",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-2.png",
                            idea_SubmissionId = "15dae071-0e4c-4b08-8f61-1cdf45f3b389",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "0510656f-30d5-4caf-92b6-585ccb92b2e6",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "37bb99f7-862c-4639-ac70-a424de5eb705",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "d4cfd95f-73ed-48b4-8fcf-583618990c11",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-3.png",
                            idea_SubmissionId = "15dae071-0e4c-4b08-8f61-1cdf45f3b389",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "53f3c157-5372-4523-801d-3624234edded",
                            idea_View = 0
                        });
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.Property<string>("likeInIdea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("likeInIdea_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("likeInIdea_DisLike")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("likeInIdea_Like")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("likeInIdea_Id");

                    b.HasIndex("likeInIdea_IdeaId");

                    b.HasIndex("likeInIdea_UserId");

                    b.ToTable("LikeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Property<string>("submission_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("submission_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("submission_Id");

                    b.HasIndex("submission_UserId");

                    b.ToTable("Submission");

                    b.HasData(
                        new
                        {
                            submission_Id = "15dae071-0e4c-4b08-8f61-1cdf45f3b389",
                            IsDelete = false,
                            submission_Description = "Submission1",
                            submission_DueTime = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            submission_Name = "Submission1",
                            submission_StartTime = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.Property<string>("uid_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uid_DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uid_UserId", "uid_DepartmentId");

                    b.HasIndex("uid_DepartmentId");

                    b.ToTable("UserInDepartment");

                    b.HasData(
                        new
                        {
                            uid_UserId = "53f3c157-5372-4523-801d-3624234edded",
                            uid_DepartmentId = "a98ed757-c447-4613-a8ad-b12e1818ed31"
                        },
                        new
                        {
                            uid_UserId = "0510656f-30d5-4caf-92b6-585ccb92b2e6",
                            uid_DepartmentId = "42f8de0f-a392-4bad-a690-9938944d72f3"
                        });
                });

            modelBuilder.Entity("News.Models.AssignToRoleModels", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AssignToRoleModels");
                });

            modelBuilder.Entity("News.Models.DetailIdeaModels", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idea_Id");

                    b.ToTable("DetailIdeaModels");
                });

            modelBuilder.Entity("News.Entities.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("AppRole");

                    b.HasData(
                        new
                        {
                            Id = "020ddda2-387b-47e7-ab1c-d29ea211bbdf",
                            ConcurrencyStamp = "116718b1-0c74-471c-b157-ee9b6d13c62a",
                            Name = "Coordinator",
                            NormalizedName = "coordinator",
                            Description = "Coordinator",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "eb0b232e-af5f-419f-ba81-d69184ea6c6b",
                            ConcurrencyStamp = "8528ff59-07ba-443e-b832-27da444e52a5",
                            Name = "Admin",
                            NormalizedName = "admin",
                            Description = "Admin",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "53f3c157-5372-4523-801d-3624234edded",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "90d29d64-2096-477c-bb69-aa8d7898421c",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIgmkF725EwBteNv2YWICsLk3mMT4Cr5Ivk0I39HQq9x+SjThEzhc8gCYnLrCFyU/Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "57a57b5a-b5c5-4487-a1b6-ca08ace9e894",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "0510656f-30d5-4caf-92b6-585ccb92b2e6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "014dcee2-45ea-4d8e-a93a-87a780515b71",
                            Email = "coordinator@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBTzt3/5Jc20cflRuCaes6l96L3ejWNjV+kTuZl/xUcc18ZE44BqFKrBRsgph5Hbog==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "081ad3d6-a85b-46ad-852c-31f16d0a0ce2",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Coordinator"
                        },
                        new
                        {
                            Id = "c05f59fc-f925-41d5-a9f6-492b5babe630",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f001efcc-fa8b-478b-a887-7ae09e94e88e",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECd3Nj7jvWU9JmUlwVDtGE7B6q02foKP9MJ93ZyWXDUqP/JPY5Ca4jHfS/aVMYhAIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f1989c0f-717e-4a6b-9c9f-3329b21ea1d8",
                            TwoFactorEnabled = false,
                            UserName = "Staff2",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Staff2"
                        },
                        new
                        {
                            Id = "ac54262d-1b34-4373-8e14-4120b62027d0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f355746-e283-4412-ac68-e4a3c31b7cf0",
                            Email = "anonymous@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANOYMOUS@GMAIL.COM",
                            NormalizedUserName = "ANOYMOUS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPfypOSmNeiBfvCA4xDGMlGcH2fiHZmQNj3sXfgimDbWM0e5kx/SfM9kB8gDuYAt6Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1b87e43a-1eed-47b4-bf19-718041292a2a",
                            TwoFactorEnabled = false,
                            UserName = "Anonymous",
                            DoB = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Anonymous"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.HasOne("News.Entities.Idea", "IdeaFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUserFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_UserId");

                    b.Navigation("AppUserFk");

                    b.Navigation("IdeaFk");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.HasOne("News.Entities.Categories", "categoriesFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_CategoryId");

                    b.HasOne("News.Entities.Submission", "submissionFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_SubmissionId");

                    b.HasOne("News.Entities.AppUser", "appUserFK")
                        .WithMany("ideasList")
                        .HasForeignKey("idea_UserId");

                    b.Navigation("appUserFK");

                    b.Navigation("categoriesFK");

                    b.Navigation("submissionFK");
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.HasOne("News.Entities.Idea", "Idea")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUser")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_UserId");

                    b.Navigation("AppUser");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.HasOne("News.Entities.AppUser", "userFK")
                        .WithMany("Submission")
                        .HasForeignKey("submission_UserId");

                    b.Navigation("userFK");
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.HasOne("News.Entities.Department", "DepartmentFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entities.AppUser", "AppUserFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserFK");

                    b.Navigation("DepartmentFK");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Navigation("userInDepartmentsList");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("likeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ideasList");

                    b.Navigation("likeInIdea");

                    b.Navigation("Submission");

                    b.Navigation("userInDepartmentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
