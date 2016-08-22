using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Chattruta.Models;

namespace Chattruta.Migrations
{
    [DbContext(typeof(ChattrutaContext))]
    [Migration("20160822193735_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chattruta.Models.Chattmeddelande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Meddelande")
                        .HasAnnotation("MaxLength", 240);

                    b.Property<string>("Namn")
                        .HasAnnotation("MaxLength", 80);

                    b.HasKey("Id");

                    b.ToTable("Chattmeddelande");
                });
        }
    }
}
