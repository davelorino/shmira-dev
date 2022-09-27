﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220918095216_someuserchanges3")]
    partial class someuserchanges3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("assignee_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("second_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Assignee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("employment_contract_type")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("id_app_user")
                        .HasColumnType("TEXT");

                    b.Property<string>("id_of_direct_report")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.Property<string>("second_name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Assignees");
                });

            modelBuilder.Entity("Domain.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("currently_estimated_duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("description_text")
                        .HasColumnType("TEXT");

                    b.Property<string>("issue_type")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("original_estimated_duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("priority")
                        .HasColumnType("TEXT");

                    b.Property<string>("project_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("reporter_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("reviewer_id")
                        .HasColumnType("TEXT");

                    b.Property<int>("sort_order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sprint_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.Property<string>("team_id")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("time_logged")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("time_remaining")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Domain.IssueAssignee", b =>
                {
                    b.Property<Guid>("AssigneeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IssueId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isOwner")
                        .HasColumnType("INTEGER");

                    b.HasKey("AssigneeId", "IssueId");

                    b.HasIndex("IssueId");

                    b.ToTable("IssueAssignees");
                });

            modelBuilder.Entity("Domain.IssueReporter", b =>
                {
                    b.Property<Guid>("ReporterId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IssueId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isOwner")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReporterId", "IssueId");

                    b.HasIndex("IssueId");

                    b.ToTable("IssueReporter");
                });

            modelBuilder.Entity("Domain.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Domain.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AssigneeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("description_text")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("owner_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("priority")
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.Property<string>("team_id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Domain.ProjectAssignee", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AssigneeId")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId", "AssigneeId");

                    b.HasIndex("AssigneeId");

                    b.ToTable("ProjectAssignees");
                });

            modelBuilder.Entity("Domain.ProjectSprint", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SprintId")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId", "SprintId");

                    b.HasIndex("SprintId");

                    b.ToTable("ProjectSprint");
                });

            modelBuilder.Entity("Domain.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("closing_summary")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date_end")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date_start")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("description_text")
                        .HasColumnType("TEXT");

                    b.Property<bool>("is_active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("priority")
                        .HasColumnType("TEXT");

                    b.Property<string>("project_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("Domain.SprintIssue", b =>
                {
                    b.Property<Guid>("SprintId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IssueId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("SprintId", "IssueId");

                    b.HasIndex("IssueId");

                    b.ToTable("SprintIssues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Assignee", b =>
                {
                    b.HasOne("Domain.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("Domain.IssueAssignee", b =>
                {
                    b.HasOne("Domain.Assignee", "Assignee")
                        .WithMany("issues")
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Issue", "Issue")
                        .WithMany("assignees")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Domain.IssueReporter", b =>
                {
                    b.HasOne("Domain.Issue", "Issue")
                        .WithMany()
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Assignee", "Reporter")
                        .WithMany()
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("Domain.Project", b =>
                {
                    b.HasOne("Domain.Assignee", null)
                        .WithMany("projects")
                        .HasForeignKey("AssigneeId");
                });

            modelBuilder.Entity("Domain.ProjectAssignee", b =>
                {
                    b.HasOne("Domain.Assignee", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Project", "Project")
                        .WithMany("assignees")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Domain.ProjectSprint", b =>
                {
                    b.HasOne("Domain.Project", "Project")
                        .WithMany("sprints")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Sprint");
                });

            modelBuilder.Entity("Domain.SprintIssue", b =>
                {
                    b.HasOne("Domain.Issue", "Issue")
                        .WithMany()
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Sprint", "Sprint")
                        .WithMany("issues")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");

                    b.Navigation("Sprint");
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
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
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

                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Assignee", b =>
                {
                    b.Navigation("issues");

                    b.Navigation("projects");
                });

            modelBuilder.Entity("Domain.Issue", b =>
                {
                    b.Navigation("assignees");
                });

            modelBuilder.Entity("Domain.Project", b =>
                {
                    b.Navigation("assignees");

                    b.Navigation("sprints");
                });

            modelBuilder.Entity("Domain.Sprint", b =>
                {
                    b.Navigation("issues");
                });
#pragma warning restore 612, 618
        }
    }
}