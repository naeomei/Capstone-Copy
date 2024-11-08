using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// the content controller is responsible for handling HTTP requests in relation to the educational content 
/// and provides endpoints for retrieving all content, filtering by type, and getting content by ID
/// </summary>


[Route("api/[controller]")]
[ApiController]
public class ContentController : ControllerBase
{
    /// <summary>
    /// service instance for managing and retrieving content.
    /// </summary>
    
    private readonly ContentService _contentService;

    /// <summary>
    /// this initializes a new instance of the ContentController class.
    /// and INJECTS a ContentService to manage content operations.
    /// </summary>
    /// <param name="contentService">this is a ContentService instance.</param>
    

    public ContentController(ContentService contentService)
    {
        _contentService = contentService;
    }

    /// <summary>
    /// this retrieves all content items.
    /// </summary>
    /// <returns>a list of all content items in the system.</returns>
    /// 

    [HttpGet]
    public ActionResult<IEnumerable<Content>> GetAllContent()
    {
        // Use ContentService to get all content
        var contents = _contentService.GetAllContent();
        return Ok(contents);
    }

    /// <summary>
    /// this retrieves content items filtered by a specified type like: "Introductory", "Glossary", "Scenario"
    /// </summary>
    /// <param name="contentType">the type of content to retrieve.</param>
    /// <returns>a list of content items that matches the specified type (or a 404 status if none are found) </returns>
    
    [HttpGet("type/{contentType}")]
    public ActionResult<IEnumerable<Content>> GetContentByType(string contentType)
    {
        var filteredContent = _contentService.GetContentByType(contentType);

        if (!filteredContent.Any())
            return NotFound(new { Message = $"No content found for type '{contentType}'" });

        return Ok(filteredContent);
    }

    /// <summary>
    /// this retrieves a specific content item by its ID
    /// </summary>
    /// <param name="id">the unique identifier of the content item.</param>
    /// <returns>the content item with the specified ID, or a 404 status if its not found</returns>
    [HttpGet("{id}")]
    public ActionResult<Content> GetContentById(int id)
    {
        var content = _contentService.GetContentById(id);

        if (content == null)
            return NotFound(new { Message = $"Content with ID '{id}' not found" });

        return Ok(content);
    }
}
