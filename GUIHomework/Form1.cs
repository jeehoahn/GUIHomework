namespace GUIHomework;

public partial class Form1 : Form {
    private Database MusicStore = new();

    public Form1() {
        InitializeComponent();

        MusicStore.Database.EnsureCreated();

        if (!MusicStore.Tuples.Any())
            MusicStore.AddInitMusic();

        ExecuteQuery();
    }

    private void ApplyFilter(object sender, EventArgs e) {
        ExecuteQuery();
    }

    private void ExecuteQuery() {
        mainContainer.Items.Clear();

        string keyword = filterText.Text.Trim().ToLower();

        var filteredResult = MusicStore.Tuples
            .Where(item => item.Name.ToLower().Contains(keyword) ||
                item.Artist.ToLower().Contains(keyword))
            .ToList();

        foreach (var item in filteredResult)
            mainContainer.Items.Add(item);
    }

    private void ShowImage(object sender, EventArgs e) {
        if (mainContainer.SelectedItem is not Music selected) {
            dropAction.Enabled = false;
            imageRenderer.Image = null;
            return;
        }

        dropAction.Enabled = true;

        if (string.IsNullOrEmpty(selected.Image)) {
            imageRenderer.Image = null;
            return;
        }

        imageRenderer.LoadAsync(selected.Image);
    }

    private void InsertMusic(object sender, EventArgs e) {
        string title = titleField.Text.Trim();
        string artist = descField.Text.Trim();
        string image = linkField.Text.Trim();

        if (title.Length == 0 || artist.Length == 0) {
            MessageBox.Show("노래 제목과 가수 이름을 입력하세요.");
            return;
        }

        MusicStore.Tuples.Add(new Music(title, artist, image));
        MusicStore.SaveChanges();

        ExecuteQuery();

        titleField.Clear();
        descField.Clear();
        linkField.Clear();
    }

    private void DeleteMusic(object sender, EventArgs e) {
        if (mainContainer.SelectedItem is not Music selected) {
            dropAction.Enabled = false;
            return;
        }

        var result = MessageBox.Show(
            $"{selected.Name}\n\n이 음악을 삭제할까요?",
            "삭제 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
            return;

        MusicStore.Tuples.Remove(selected);
        MusicStore.SaveChanges();

        ExecuteQuery();

        dropAction.Enabled = false;
        imageRenderer.Image = null;
    }
}