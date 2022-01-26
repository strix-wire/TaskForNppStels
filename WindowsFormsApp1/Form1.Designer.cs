namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutPanelCache = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCache = new System.Windows.Forms.Label();
            this.ButtonDatabaseToCache = new System.Windows.Forms.Button();
            this.TableLayoutPanelDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDatabase = new System.Windows.Forms.Label();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonValue = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.TreeViewDataBase = new Tree.MyTreeView();
            this.TreeViewCache = new Tree.MyTreeView();
            this.TableLayoutPanelCache.SuspendLayout();
            this.TableLayoutPanelDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelCache
            // 
            this.TableLayoutPanelCache.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanelCache.ColumnCount = 1;
            this.TableLayoutPanelCache.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCache.Controls.Add(this.LabelCache, 0, 0);
            this.TableLayoutPanelCache.Controls.Add(this.TreeViewCache, 0, 1);
            this.TableLayoutPanelCache.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanelCache.Name = "TableLayoutPanelCache";
            this.TableLayoutPanelCache.RowCount = 2;
            this.TableLayoutPanelCache.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.385093F));
            this.TableLayoutPanelCache.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.61491F));
            this.TableLayoutPanelCache.Size = new System.Drawing.Size(387, 419);
            this.TableLayoutPanelCache.TabIndex = 33;
            this.TableLayoutPanelCache.TabStop = true;
            // 
            // LabelCache
            // 
            this.LabelCache.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCache.AutoSize = true;
            this.LabelCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCache.Location = new System.Drawing.Point(4, 1);
            this.LabelCache.Name = "LabelCache";
            this.LabelCache.Size = new System.Drawing.Size(379, 34);
            this.LabelCache.TabIndex = 0;
            this.LabelCache.Text = "Cache";
            this.LabelCache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonDatabaseToCache
            // 
            this.ButtonDatabaseToCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDatabaseToCache.Location = new System.Drawing.Point(405, 213);
            this.ButtonDatabaseToCache.Name = "ButtonDatabaseToCache";
            this.ButtonDatabaseToCache.Size = new System.Drawing.Size(95, 32);
            this.ButtonDatabaseToCache.TabIndex = 34;
            this.ButtonDatabaseToCache.Text = "<<<";
            this.ButtonDatabaseToCache.UseVisualStyleBackColor = true;
            this.ButtonDatabaseToCache.Click += new System.EventHandler(this.ButtonDatabaseToCache_Click);
            // 
            // TableLayoutPanelDatabase
            // 
            this.TableLayoutPanelDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelDatabase.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanelDatabase.ColumnCount = 1;
            this.TableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDatabase.Controls.Add(this.LabelDatabase, 0, 0);
            this.TableLayoutPanelDatabase.Controls.Add(this.TreeViewDataBase, 0, 1);
            this.TableLayoutPanelDatabase.Location = new System.Drawing.Point(506, 12);
            this.TableLayoutPanelDatabase.Name = "TableLayoutPanelDatabase";
            this.TableLayoutPanelDatabase.RowCount = 2;
            this.TableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.385093F));
            this.TableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.61491F));
            this.TableLayoutPanelDatabase.Size = new System.Drawing.Size(387, 419);
            this.TableLayoutPanelDatabase.TabIndex = 35;
            this.TableLayoutPanelDatabase.TabStop = true;
            // 
            // LabelDatabase
            // 
            this.LabelDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDatabase.AutoSize = true;
            this.LabelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDatabase.Location = new System.Drawing.Point(4, 1);
            this.LabelDatabase.Name = "LabelDatabase";
            this.LabelDatabase.Size = new System.Drawing.Size(379, 34);
            this.LabelDatabase.TabIndex = 0;
            this.LabelDatabase.Text = "Database";
            this.LabelDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(12, 437);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(95, 32);
            this.ButtonMinus.TabIndex = 36;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.Location = new System.Drawing.Point(113, 437);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(95, 32);
            this.ButtonPlus.TabIndex = 37;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonValue
            // 
            this.ButtonValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonValue.Location = new System.Drawing.Point(214, 437);
            this.ButtonValue.Name = "ButtonValue";
            this.ButtonValue.Size = new System.Drawing.Size(95, 32);
            this.ButtonValue.TabIndex = 38;
            this.ButtonValue.Text = "Value";
            this.ButtonValue.UseVisualStyleBackColor = true;
            this.ButtonValue.Click += new System.EventHandler(this.ButtonValue_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonApply.Location = new System.Drawing.Point(405, 437);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(95, 32);
            this.ButtonApply.TabIndex = 39;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReset.Location = new System.Drawing.Point(506, 437);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(95, 32);
            this.ButtonReset.TabIndex = 40;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // TreeViewDataBase
            // 
            this.TreeViewDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewDataBase.Location = new System.Drawing.Point(1, 36);
            this.TreeViewDataBase.Margin = new System.Windows.Forms.Padding(0);
            this.TreeViewDataBase.Name = "TreeViewDataBase";
            this.TreeViewDataBase.Size = new System.Drawing.Size(385, 382);
            this.TreeViewDataBase.TabIndex = 1;
            // 
            // TreeViewCache
            // 
            this.TreeViewCache.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewCache.Location = new System.Drawing.Point(1, 36);
            this.TreeViewCache.Margin = new System.Windows.Forms.Padding(0);
            this.TreeViewCache.Name = "TreeViewCache";
            this.TreeViewCache.Size = new System.Drawing.Size(385, 382);
            this.TreeViewCache.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonValue);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.TableLayoutPanelDatabase);
            this.Controls.Add(this.ButtonDatabaseToCache);
            this.Controls.Add(this.TableLayoutPanelCache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CachedDataBase";
            this.TableLayoutPanelCache.ResumeLayout(false);
            this.TableLayoutPanelCache.PerformLayout();
            this.TableLayoutPanelDatabase.ResumeLayout(false);
            this.TableLayoutPanelDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCache;
        private System.Windows.Forms.Label LabelCache;
        private System.Windows.Forms.Button ButtonDatabaseToCache;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelDatabase;
        private System.Windows.Forms.Label LabelDatabase;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonValue;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonReset;
        private Tree.MyTreeView TreeViewCache;
        private Tree.MyTreeView TreeViewDataBase;
    }
}

