using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using WebCampAspNet5.Models;

namespace src.Migrations.TriviaDBContext
{
    [ContextType(typeof(WebCampAspNet5.Models.TriviaDBContext))]
    public class TriviaDBContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
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