// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductDAL;

namespace ProductDAL.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20221020102514_productApi")]
    partial class productApi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProductEntity.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ArticleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("tblArticle");
                });

            modelBuilder.Entity("ProductEntity.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("tblColor");
                });

            modelBuilder.Entity("ProductEntity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductYear")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<int?>("tblSizeSizeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("tblSizeSizeId");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("ProductEntity.SizeScale", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SizeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("tblSizeScale");
                });

            modelBuilder.Entity("ProductEntity.Article", b =>
                {
                    b.HasOne("ProductEntity.Color", "tblColor")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductEntity.Product", "tblProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tblColor");

                    b.Navigation("tblProduct");
                });

            modelBuilder.Entity("ProductEntity.Product", b =>
                {
                    b.HasOne("ProductEntity.SizeScale", "tblSize")
                        .WithMany()
                        .HasForeignKey("tblSizeSizeId");

                    b.Navigation("tblSize");
                });
#pragma warning restore 612, 618
        }
    }
}
