
namespace GUIHomework {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent() {
            mainContainer = new ListBox();
            titleField = new TextBox();
            descField = new TextBox();
            linkField = new TextBox();
            submitAction = new Button();
            imageRenderer = new PictureBox();
            filterText = new TextBox();
            dropAction = new Button();
            groupBox1 = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)imageRenderer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();

            //
            // mainContainer
            //
            mainContainer.FormattingEnabled = true;
            mainContainer.HorizontalScrollbar = true;
            mainContainer.Location = new Point(12, 47);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(658, 229);
            mainContainer.TabIndex = 9;
            mainContainer.SelectedIndexChanged += ShowImage;

            //
            // titleField
            //
            titleField.Location = new Point(5, 25);
            titleField.Name = "titleField";
            titleField.PlaceholderText = "노래 제목";
            titleField.Size = new Size(231, 31);
            titleField.TabIndex = 0;

            //
            // descField
            //
            descField.Location = new Point(242, 25);
            descField.Name = "descField";
            descField.PlaceholderText = "가수 이름";
            descField.Size = new Size(231, 31);
            descField.TabIndex = 4;

            //
            // linkField
            //
            linkField.Location = new Point(479, 25);
            linkField.Name = "linkField";
            linkField.PlaceholderText = "앨범 커버 이미지 URL (선택)";
            linkField.Size = new Size(231, 31);
            linkField.TabIndex = 5;

            //
            // submitAction
            //
            submitAction.Location = new Point(716, 23);
            submitAction.Name = "submitAction";
            submitAction.Size = new Size(231, 35);
            submitAction.TabIndex = 6;
            submitAction.Text = "음악 추가";
            submitAction.UseVisualStyleBackColor = true;
            submitAction.Click += InsertMusic;

            //
            // imageRenderer
            //
            imageRenderer.BorderStyle = BorderStyle.FixedSingle;
            imageRenderer.Location = new Point(676, 12);
            imageRenderer.Name = "imageRenderer";
            imageRenderer.Size = new Size(310, 310);
            imageRenderer.SizeMode = PictureBoxSizeMode.Zoom;
            imageRenderer.TabIndex = 11;
            imageRenderer.TabStop = false;

            //
            // filterText
            //
            filterText.Location = new Point(12, 12);
            filterText.Name = "filterText";
            filterText.PlaceholderText = "노래 제목 또는 가수 검색";
            filterText.Size = new Size(658, 31);
            filterText.TabIndex = 7;
            filterText.TextChanged += ApplyFilter;

            //
            // dropAction
            //
            dropAction.Enabled = false;
            dropAction.Location = new Point(12, 287);
            dropAction.Name = "dropAction";
            dropAction.Size = new Size(658, 35);
            dropAction.TabIndex = 10;
            dropAction.Text = "선택 음악 삭제";
            dropAction.UseVisualStyleBackColor = true;
            dropAction.Click += DeleteMusic;

            //
            // groupBox1
            //
            groupBox1.Controls.Add(submitAction);
            groupBox1.Controls.Add(linkField);
            groupBox1.Controls.Add(descField);
            groupBox1.Controls.Add(titleField);
            groupBox1.Location = new Point(15, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 72);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "음악 추가";

            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 414);

            Controls.Add(groupBox1);
            Controls.Add(dropAction);
            Controls.Add(imageRenderer);
            Controls.Add(filterText);
            Controls.Add(mainContainer);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "음악 목록 관리 프로그램";

            ((System.ComponentModel.ISupportInitialize)imageRenderer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;

        private TextBox titleField;
        private TextBox descField;
        private TextBox linkField;
        private Button submitAction;

        private ListBox mainContainer;
        private PictureBox imageRenderer;

        private TextBox filterText;
        private Button dropAction;
    }
}
