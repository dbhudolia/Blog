using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogPostController : ControllerBase
{
    private readonly ILogger<BlogPostController> _logger;

    public BlogPostController(ILogger<BlogPostController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public List<BlogPost> Get()
    {
        List<BlogPost> blogPosts = new List<BlogPost>();

        BlogPost blog1 = new BlogPost();
        blog1.Title = "Socket Programming — JAVA";
        blog1.Category = "Java";
        blog1.Date = "08 July 2021";
        blog1.Context = "The socket is one of the endpoints for two-way communication between two computers present on a network.";
        blog1.ReadMore = "https://medium.com/@bhudoliadevansh/socket-programming-java-4b7895790973";
        blogPosts.Add(blog1);

        BlogPost blog2 = new BlogPost();
        blog2.Title = "What Did People Do Before Smartphones?";
        blog2.Category = "Technology";
        blog2.Date = "12 June 2023";
        blog2.Context = "In 2000, I got the RIM 957, my first BlackBerry. It received, in real time, emails sent to my work account.";
        blog2.ReadMore = "https://www.theatlantic.com/technology/archive/2023/07/before-smartphones-boredom/674631/?utm_source=pocket-newtab-intl-en";
        blogPosts.Add(blog2);

        BlogPost blog3 = new BlogPost();
        blog3.Title = "Why Midlife Is So Hard";
        blog3.Category = "Parenting";
        blog3.Date = "03 July 2023";
        blog3.Context = "The modern midlife crisis comes from the stresses of caregiving for both children and parents, while facing financial struggles.";
        blog3.ReadMore = "https://greatergood.berkeley.edu/article/item/why_midlife_is_so_hard_especially_now?utm_source=pocket-newtab-intl-en";
        blogPosts.Add(blog3);

        BlogPost blog4 = new BlogPost();
        blog4.Title = "Wimbledon: The controversy of tennis's";
        blog4.Category = "Fashion";
        blog4.Date = "07 July 2023";
        blog4.Context = "For the first time in its history, Wimbledon has relaxed its dress code rules. Why are they so strict?";
        blog4.ReadMore = "https://www.bbc.com/culture/article/20230707-wimbledon-the-controversy-of-tenniss-strict-146-year-old-dress-code?utm_source=pocket-newtab-intl-en";
        blogPosts.Add(blog4);

        return blogPosts;
    }
}


