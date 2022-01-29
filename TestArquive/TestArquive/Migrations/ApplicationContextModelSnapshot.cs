﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestArquive.Data;

namespace TestArquive.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestArquive.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("CHAR(36)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("NameUser")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}