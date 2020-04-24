﻿namespace Quizler.Web.Shared.Models.Quizzes
{
    using AutoMapper;
    using Quizler.Data.Models;
    using Quizler.Services.Mapping;

    public class QuizDetailsResponse : IMapFrom<Quiz>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public int Plays { get; set; }

        public int Questions { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Quiz, QuizDetailsResponse>()
                .ForMember(q => q.Category, options =>
                {
                    options.MapFrom(q => q.Category.Name);
                    options.MapFrom(q => q.Questions.Count);
                });
        }
    }
}
