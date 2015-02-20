using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using WebCampAspNet5.Models;

namespace src.Migrations
{
    [ContextType(typeof(WebCampAspNet5.Models.TriviaDBContext))]
    public partial class initial : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201502201820478_initial";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta2-11909";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("WebCampAspNet5.Models.TriviaAnswer", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<int>("OptionId");
                        b.Property<int>("QuestionId");
                        b.Property<string>("UserId");
                        b.Key("Id");
                    });
                
                builder.Entity("WebCampAspNet5.Models.TriviaOption", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<bool>("IsCorrect");
                        b.Property<int>("QuestionId");
                        b.Property<string>("Title");
                        b.Key("Id");
                    });
                
                builder.Entity("WebCampAspNet5.Models.TriviaQuestion", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Title");
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}