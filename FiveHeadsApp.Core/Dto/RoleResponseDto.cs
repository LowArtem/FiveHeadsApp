namespace FiveHeadsApp.Core.Dto;

/// <summary>
/// Информация о роли пользователя
/// </summary>
public class RoleResponseDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
}