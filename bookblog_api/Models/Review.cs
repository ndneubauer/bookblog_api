namespace bookblog_api.Models
{
    public class ReviewSummary
    {
        public int ReviewId { get; set; }

        public string BookTitle { get; set; }

        public string BookAuthor { get; set; }

        public string ReviewAuthor { get; set; }

        public string ReviewDate { get; set; }

        public string ImageUrl { get; set; }

        public string Summary { get; set; }

        public ReviewSummary()
        {
        }

        public ReviewSummary(int reviewId, string bookTitle, string bookAuthor, string reviewAuthor, string reviewDate, string imageUrl, string summary)
        {
            ReviewId = reviewId;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            ReviewAuthor = reviewAuthor;
            ReviewDate = reviewDate;
            ImageUrl = imageUrl;
            Summary = summary;
        }
    }

    public class FeaturedReview
    {
        public int ReviewId { get; set; }

        public string BookTitle { get; set; }

        public string BookAuthor { get; set; }

        public string ImageUrl { get; set; }

        public FeaturedReview()
        {
        }

        public FeaturedReview(int reviewId, string bookTitle, string bookAuthor, string imageUrl)
        {
            ReviewId = reviewId;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            ImageUrl = imageUrl;
        }
    }
}
