using System.ComponentModel.DataAnnotations;

namespace GUIHomework;

public record Music(
    string Name,
    string Artist,
    string Image
) {
    [Key]
    public int Id { get; init; }

    public override string ToString() => $"[{Name}] {Artist}";
}