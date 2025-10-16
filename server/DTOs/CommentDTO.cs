﻿namespace server.DTOs
{
    public class CommentDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string UserPhotoUrl { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public TimeSpan TimeAgo { get; set; }

        public int LikesCount { get; set; }
    }
}
