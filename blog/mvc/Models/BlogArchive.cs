using Piranha.AttributeBuilder;
using Piranha.Models;

namespace MvcBlog.Models
{
    [PageType(Title = "Blog archive", UseBlocks = false)]
    public class BlogArchive  : ArchivePage<BlogArchive>
    {
    }
}