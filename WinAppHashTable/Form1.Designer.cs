namespace WinAppHashTable
{
    partial class HashTableTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashtableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusHastable = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDictionary = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSortedDictionary = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBoxFileInitial = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCheckSpell = new System.Windows.Forms.RichTextBox();
            this.CheckSpellButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.openFileToolStripMenuItem.Text = "O&pen File... ";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashtableToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.sortedDictionaryToolStripMenuItem});
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.tToolStripMenuItem.Text = "Test";
            // 
            // hashtableToolStripMenuItem
            // 
            this.hashtableToolStripMenuItem.Name = "hashtableToolStripMenuItem";
            this.hashtableToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.hashtableToolStripMenuItem.Text = "Hashtable";
            this.hashtableToolStripMenuItem.Click += new System.EventHandler(this.hashtableToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // sortedDictionaryToolStripMenuItem
            // 
            this.sortedDictionaryToolStripMenuItem.Name = "sortedDictionaryToolStripMenuItem";
            this.sortedDictionaryToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.sortedDictionaryToolStripMenuItem.Text = "Sorted Dictionary";
            this.sortedDictionaryToolStripMenuItem.Click += new System.EventHandler(this.sortedDictionaryToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusHastable,
            this.toolStripStatusDictionary,
            this.toolStripStatusSortedDictionary});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1177, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusHastable
            // 
            this.toolStripStatusHastable.Name = "toolStripStatusHastable";
            this.toolStripStatusHastable.Size = new System.Drawing.Size(135, 20);
            this.toolStripStatusHastable.Text = "Runtime Hashtable";
            // 
            // toolStripStatusDictionary
            // 
            this.toolStripStatusDictionary.Name = "toolStripStatusDictionary";
            this.toolStripStatusDictionary.Size = new System.Drawing.Size(136, 20);
            this.toolStripStatusDictionary.Text = "Runtime Dictionary";
            // 
            // toolStripStatusSortedDictionary
            // 
            this.toolStripStatusSortedDictionary.Name = "toolStripStatusSortedDictionary";
            this.toolStripStatusSortedDictionary.Size = new System.Drawing.Size(184, 20);
            this.toolStripStatusSortedDictionary.Text = "Runtime Sorted Dictionary";
            // 
            // richTextBoxFileInitial
            // 
            this.richTextBoxFileInitial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxFileInitial.Location = new System.Drawing.Point(29, 34);
            this.richTextBoxFileInitial.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxFileInitial.Name = "richTextBoxFileInitial";
            this.richTextBoxFileInitial.Size = new System.Drawing.Size(462, 597);
            this.richTextBoxFileInitial.TabIndex = 2;
            this.richTextBoxFileInitial.Text = "";
            // 
            // richTextBoxCheckSpell
            // 
            this.richTextBoxCheckSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCheckSpell.Location = new System.Drawing.Point(698, 34);
            this.richTextBoxCheckSpell.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxCheckSpell.Name = "richTextBoxCheckSpell";
            this.richTextBoxCheckSpell.Size = new System.Drawing.Size(462, 597);
            this.richTextBoxCheckSpell.TabIndex = 3;
            this.richTextBoxCheckSpell.Text = "";
            // 
            // CheckSpellButton
            // 
            this.CheckSpellButton.Location = new System.Drawing.Point(550, 325);
            this.CheckSpellButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckSpellButton.Name = "CheckSpellButton";
            this.CheckSpellButton.Size = new System.Drawing.Size(100, 28);
            this.CheckSpellButton.TabIndex = 4;
            this.CheckSpellButton.Text = "Check Spell";
            this.CheckSpellButton.UseVisualStyleBackColor = true;
            this.CheckSpellButton.Click += new System.EventHandler(this.CheckSpell_Click);
            // 
            // HashTableTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 662);
            this.Controls.Add(this.CheckSpellButton);
            this.Controls.Add(this.richTextBoxCheckSpell);
            this.Controls.Add(this.richTextBoxFileInitial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HashTableTest";
            this.Text = "HashTable Testing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashtableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedDictionaryToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHastable;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDictionary;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSortedDictionary;
        private System.Windows.Forms.RichTextBox richTextBoxFileInitial;
        private System.Windows.Forms.RichTextBox richTextBoxCheckSpell;
        private System.Windows.Forms.Button CheckSpellButton;
    }
}

