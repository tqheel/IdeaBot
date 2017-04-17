using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using IdeaBot.Models;

namespace IdeaBot.Migrations
{
    [DbContext(typeof(IdeaContext))]
    partial class IdeaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("IdeaBot.Models.Idea", b =>
                {
                    b.Property<int>("IdeaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdeaBatchId");

                    b.Property<string>("IdeaText");

                    b.Property<long>("IdeaTime");

                    b.HasKey("IdeaId");

                    b.HasIndex("IdeaBatchId");

                    b.ToTable("Ideas");
                });

            modelBuilder.Entity("IdeaBot.Models.IdeaBatch", b =>
                {
                    b.Property<int>("IdeaBatchId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("IdeaBatchTime");

                    b.Property<string>("IdeaText");

                    b.Property<long>("IdeaTime");

                    b.Property<int>("NumIdeasInBatch");

                    b.HasKey("IdeaBatchId");

                    b.ToTable("IdeaBatches");
                });

            modelBuilder.Entity("IdeaBot.Models.Idea", b =>
                {
                    b.HasOne("IdeaBot.Models.IdeaBatch", "IdeaBatch")
                        .WithMany("Ideas")
                        .HasForeignKey("IdeaBatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
