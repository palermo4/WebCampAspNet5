using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace WebCampAspNet5.Migrations
{
    public partial class initial : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn("AspNetUsers", "LockoutEnd", c => c.DateTimeOffset());
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn("AspNetUsers", "LockoutEnd", c => c.DateTimeOffset(nullable: false));
        }
    }
}