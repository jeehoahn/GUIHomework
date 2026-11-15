using Microsoft.EntityFrameworkCore;

namespace GUIHomework;

public class Database : DbContext {
    public DbSet<Music> Tuples { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder
    ) {
        optionsBuilder.UseSqlite("Data Source=music.db");
    }

    public void AddInitMusic() {
        Tuples.AddRange(new Music[] {
            new("Dynamite", "BTS", ""),
            new("Butter", "BTS", ""),
            new("Spring Day", "BTS", ""),
            new("DDU-DU DDU-DU", "BLACKPINK", ""),
            new("How You Like That", "BLACKPINK", ""),
            new("Celebrity", "IU", ""),
            new("밤편지", "IU", ""),
            new("좋은 날", "IU", ""),
            new("Hype Boy", "NewJeans", ""),
            new("Ditto", "NewJeans", ""),
            new("Supernova", "aespa", ""),
            new("Next Level", "aespa", ""),
            new("APT.", "ROSÉ & Bruno Mars", ""),
            new("Die With A Smile", "Lady Gaga & Bruno Mars", ""),
            new("Shape of You", "Ed Sheeran", ""),
            new("Blinding Lights", "The Weeknd", ""),
            new("bad guy", "Billie Eilish", ""),
            new("Love Story", "Taylor Swift", ""),
            new("Gangnam Style", "PSY", ""),
            new("Any Song", "ZICO", "")
        });

        SaveChanges();
    }
}