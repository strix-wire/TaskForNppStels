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
            this.tableLayoutPanelCache = new System.Windows.Forms.TableLayoutPanel();
            this.labelCache = new System.Windows.Forms.Label();
            this.RichTextBoxCache = new System.Windows.Forms.RichTextBox();
            this.buttonDatabaseToCache = new System.Windows.Forms.Button();
            this.tableLayoutPanelDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.richTextBoxDatabase = new System.Windows.Forms.RichTextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tableLayoutPanelCache.SuspendLayout();
            this.tableLayoutPanelDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCache
            // 
            this.tableLayoutPanelCache.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelCache.ColumnCount = 1;
            this.tableLayoutPanelCache.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCache.Controls.Add(this.labelCache, 0, 0);
            this.tableLayoutPanelCache.Controls.Add(this.RichTextBoxCache, 0, 1);
            this.tableLayoutPanelCache.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelCache.Name = "tableLayoutPanelCache";
            this.tableLayoutPanelCache.RowCount = 2;
            this.tableLayoutPanelCache.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.385093F));
            this.tableLayoutPanelCache.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.61491F));
            this.tableLayoutPanelCache.Size = new System.Drawing.Size(387, 419);
            this.tableLayoutPanelCache.TabIndex = 33;
            this.tableLayoutPanelCache.TabStop = true;
            // 
            // labelCache
            // 
            this.labelCache.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCache.AutoSize = true;
            this.labelCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCache.Location = new System.Drawing.Point(4, 1);
            this.labelCache.Name = "labelCache";
            this.labelCache.Size = new System.Drawing.Size(379, 34);
            this.labelCache.TabIndex = 0;
            this.labelCache.Text = "Cache";
            this.labelCache.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextBoxCache
            // 
            this.RichTextBoxCache.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxCache.Location = new System.Drawing.Point(4, 39);
            this.RichTextBoxCache.Name = "RichTextBoxCache";
            this.RichTextBoxCache.ReadOnly = true;
            this.RichTextBoxCache.Size = new System.Drawing.Size(379, 376);
            this.RichTextBoxCache.TabIndex = 0;
            this.RichTextBoxCache.Text = "";
            // 
            // buttonDatabaseToCache
            // 
            this.buttonDatabaseToCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDatabaseToCache.Location = new System.Drawing.Point(405, 213);
            this.buttonDatabaseToCache.Name = "buttonDatabaseToCache";
            this.buttonDatabaseToCache.Size = new System.Drawing.Size(95, 32);
            this.buttonDatabaseToCache.TabIndex = 34;
            this.buttonDatabaseToCache.Text = "<<<";
            this.buttonDatabaseToCache.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDatabase
            // 
            this.tableLayoutPanelDatabase.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelDatabase.ColumnCount = 1;
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDatabase.Controls.Add(this.labelDatabase, 0, 0);
            this.tableLayoutPanelDatabase.Controls.Add(this.richTextBoxDatabase, 0, 1);
            this.tableLayoutPanelDatabase.Location = new System.Drawing.Point(506, 12);
            this.tableLayoutPanelDatabase.Name = "tableLayoutPanelDatabase";
            this.tableLayoutPanelDatabase.RowCount = 2;
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.385093F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.61491F));
            this.tableLayoutPanelDatabase.Size = new System.Drawing.Size(387, 419);
            this.tableLayoutPanelDatabase.TabIndex = 35;
            this.tableLayoutPanelDatabase.TabStop = true;
            // 
            // labelDatabase
            // 
            this.labelDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDatabase.Location = new System.Drawing.Point(4, 1);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(379, 34);
            this.labelDatabase.TabIndex = 0;
            this.labelDatabase.Text = "Database";
            this.labelDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxDatabase
            // 
            this.richTextBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDatabase.Location = new System.Drawing.Point(4, 39);
            this.richTextBoxDatabase.Name = "richTextBoxDatabase";
            this.richTextBoxDatabase.ReadOnly = true;
            this.richTextBoxDatabase.Size = new System.Drawing.Size(379, 376);
            this.richTextBoxDatabase.TabIndex = 0;
            this.richTextBoxDatabase.Text = "";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 437);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(95, 32);
            this.buttonPlus.TabIndex = 36;
            this.buttonPlus.Text = "-";
            this.buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(113, 437);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(95, 32);
            this.buttonMinus.TabIndex = 37;
            this.buttonMinus.Text = "+";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonValue
            // 
            this.buttonValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonValue.Location = new System.Drawing.Point(214, 437);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(95, 32);
            this.buttonValue.TabIndex = 38;
            this.buttonValue.Text = "Value";
            this.buttonValue.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.Location = new System.Drawing.Point(405, 437);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(95, 32);
            this.buttonApply.TabIndex = 39;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(506, 437);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 32);
            this.buttonReset.TabIndex = 40;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonValue);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.tableLayoutPanelDatabase);
            this.Controls.Add(this.buttonDatabaseToCache);
            this.Controls.Add(this.tableLayoutPanelCache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CachedDataBase";
            this.tableLayoutPanelCache.ResumeLayout(false);
            this.tableLayoutPanelCache.PerformLayout();
            this.tableLayoutPanelDatabase.ResumeLayout(false);
            this.tableLayoutPanelDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCache;
        private System.Windows.Forms.Label labelCache;
        private System.Windows.Forms.RichTextBox RichTextBoxCache;
        private System.Windows.Forms.Button buttonDatabaseToCache;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDatabase;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.RichTextBox richTextBoxDatabase;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonReset;
    }
}

