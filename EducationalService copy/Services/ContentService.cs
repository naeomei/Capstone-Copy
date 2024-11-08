using System.Collections.Generic;
using System.Linq;
/// <summary>
/// this is my service class rthat is esponsible for managing and retrieving content items
/// and it acts as a simple content repository it provides methods to access content by type, ID, or all items 
/// </summary>


public class ContentService
{


    /// <summary>
    ///  in-memory list of content items.
    /// TEMPORARY data store for testing purposes.
    /// </summary>

    private readonly List<Content> _contents = new List<Content>
    {
        new Content { Id = 1, Title = "Introduction to Dark Matter", Description = "Basic info on dark matter", ContentType = "Introductory", Body = "Dark matter is..."},
        new Content { Id = 2, Title = "What is Dark Energy?", Description = "Overview of dark energy", ContentType = "Introductory", Body = "Dark energy is..."},
        new Content { Id = 3, Title = "Glossary - Dark Matter", Description = "Glossary entry for Dark Matter", ContentType = "Glossary", Body = "Dark Matter: A type of matter..."},
        new Content { Id = 4, Title = "Sample Scenario", Description = "An example scenario for simulations", ContentType = "Scenario", Body = "In this scenario, you will explore..."}
    };


    /// <summary>
    /// retrives all content items
    /// thi sserves for displaying the full list of educational materials to users
    /// </summary>
    /// <returns>an IEnumerable of all content items</returns>
    public IEnumerable<Content> GetAllContent()
    {
        return _contents;
    }



    /// <summary>
    /// retrieves content items based on their type like : "Introductory", "Glossary", "Scenario" 
    /// allows users to filter content by category for easier navigation.
    /// </summary>
    /// <param name="contentType">the type of content to filter by</param>
    /// <returns>an IEnumerable of content items matching the specified type.</returns>
    /// 

    public IEnumerable<Content> GetContentByType(string contentType)
    {
        return _contents.Where(c => c.ContentType.ToLower() == contentType.ToLower());
    }


    /// <summary>
    /// retrieves a specific content item by its unique ID
    /// so this method is useful for fetching detailed content when a SPECIFIC item is selected
    /// </summary>
    /// <param name="id">the unique identifier of the content item </param>
    /// <returns>the content item with the specified ID or null if its not found</returns>
    public Content GetContentById(int id)
    {
        return _contents.FirstOrDefault(c => c.Id == id);
    }
}
