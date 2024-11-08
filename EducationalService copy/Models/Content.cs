/// <summary>
/// represeting a content item for my Educational service
/// this class holds the essential information for my educational content 
/// such as: articles, glossary terms, or scenarios related to dark matter and dark energy.
/// </summary>
public class Content
{
    /// <summary>
    /// here is a unique identifier for each content item. 
    /// im using this to distinguish individual content entries in the database.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// represents  the title of the content, like "Introduction to Dark Matter"
    /// intention: to give users a quick understanding of the content's focus
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// represents a brief description or summary of the content
    /// this provides a short overview that can be displayed in lists or previews
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// this represents the type of content, so it indicates its category, like "Introductory", "Glossary", or "Scenario". (planning on only one examplescenario )
    /// This helps in organizing and filtering content by its purpose or format
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// this would represent like full text or detailed information of the content
    /// anf the field holds the main educational info
    /// </summary>
    public string Body { get; set; }
}
