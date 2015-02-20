using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace src.Migrations.TriviaDBContext
{
    public partial class initial : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("TriviaAnswer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OptionId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.String()
                    })
                .PrimaryKey("PK_TriviaAnswer", t => t.Id);
            
            migrationBuilder.CreateTable("TriviaOption",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCorrect = c.Boolean(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        Title = c.String()
                    })
                .PrimaryKey("PK_TriviaOption", t => t.Id);
            
            migrationBuilder.CreateTable("TriviaQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String()
                    })
                .PrimaryKey("PK_TriviaQuestion", t => t.Id);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("TriviaAnswer");
            
            migrationBuilder.DropTable("TriviaOption");
            
            migrationBuilder.DropTable("TriviaQuestion");
        }
    }
}