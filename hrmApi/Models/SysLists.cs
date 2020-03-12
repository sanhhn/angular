using System.ComponentModel.DataAnnotations;

public class SysLists {
    [Key]
    public string ListID { get; set; } //(nvarchar(20), not null)
    public string MenuGroup { get; set; } //(nvarchar(20), null)
    public string ListGroup { get; set; } //(nvarchar(20), null)
    public string Name { get; set; } //(nvarchar(150), null)
    public string NameEN { get; set; } //(nvarchar(150), null)
    public string SQLSelect { get; set; } //(nvarchar(4000), null)
    public string SQLSelectEN { get; set; } //(nvarchar(4000), null)
    public string ColWidths { get; set; } //(nvarchar(200), null)
    public string ColDisables { get; set; } //(nvarchar(400), null)
    public int? Rank { get; set; } //(int, null)
    public string ImportInfo { get; set; } //(nvarchar(300), null)
    public string GridKey { get; set; } //(nvarchar(40), null)
    public string MenuTitle { get; set; } //(nvarchar(150), null)
    public string MenuTitleVN { get; set; } //(nvarchar(150), null)
}
