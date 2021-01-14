﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradingDayAnalyzerDal;

namespace TradingDayAnalyzerDal.Migrations
{
    [DbContext(typeof(TradingDayContext))]
    partial class TradingDayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TradingDayAnalyzerDal.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EuroRate")
                        .HasColumnType("float");

                    b.Property<int?>("TradingDayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TradingDayId");

                    b.ToTable("ExchangeRates");
                });

            modelBuilder.Entity("TradingDayAnalyzerDal.TradingDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TradingDays");
                });

            modelBuilder.Entity("TradingDayAnalyzerDal.ExchangeRate", b =>
                {
                    b.HasOne("TradingDayAnalyzerDal.TradingDay", "TradingDay")
                        .WithMany("ExchangeRates")
                        .HasForeignKey("TradingDayId");

                    b.Navigation("TradingDay");
                });

            modelBuilder.Entity("TradingDayAnalyzerDal.TradingDay", b =>
                {
                    b.Navigation("ExchangeRates");
                });
#pragma warning restore 612, 618
        }
    }
}