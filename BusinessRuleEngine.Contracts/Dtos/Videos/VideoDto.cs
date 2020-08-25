using System;
using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Contracts.Dtos.Videos
{
    public class VideoDto
    {
        public Guid Id { get; set; }

        public VideoType VideoType { get; set; }
    }
}
