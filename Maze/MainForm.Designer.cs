namespace Maze
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.algorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.AstarRadioButton = new System.Windows.Forms.RadioButton();
            this.DFSradioButtion = new System.Windows.Forms.RadioButton();
            this.BFSradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.initRadioButton = new System.Windows.Forms.RadioButton();
            this.obsticleRadioButton = new System.Windows.Forms.RadioButton();
            this.endRadioButton = new System.Windows.Forms.RadioButton();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.BFS = new System.Windows.Forms.Timer(this.components);
            this.DFS = new System.Windows.Forms.Timer(this.components);
            this.Astar = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.algorithmGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmGroupBox
            // 
            this.algorithmGroupBox.Controls.Add(this.AstarRadioButton);
            this.algorithmGroupBox.Controls.Add(this.DFSradioButtion);
            this.algorithmGroupBox.Controls.Add(this.BFSradioButton);
            this.algorithmGroupBox.Location = new System.Drawing.Point(12, 12);
            this.algorithmGroupBox.Name = "algorithmGroupBox";
            this.algorithmGroupBox.Size = new System.Drawing.Size(102, 63);
            this.algorithmGroupBox.TabIndex = 0;
            this.algorithmGroupBox.TabStop = false;
            this.algorithmGroupBox.Text = "演算法";
            // 
            // AstarRadioButton
            // 
            this.AstarRadioButton.AutoSize = true;
            this.AstarRadioButton.Location = new System.Drawing.Point(56, 17);
            this.AstarRadioButton.Name = "AstarRadioButton";
            this.AstarRadioButton.Size = new System.Drawing.Size(37, 16);
            this.AstarRadioButton.TabIndex = 1;
            this.AstarRadioButton.TabStop = true;
            this.AstarRadioButton.Text = "A*";
            this.AstarRadioButton.UseVisualStyleBackColor = true;
            this.AstarRadioButton.Visible = false;
            // 
            // DFSradioButtion
            // 
            this.DFSradioButtion.AutoSize = true;
            this.DFSradioButtion.Location = new System.Drawing.Point(6, 39);
            this.DFSradioButtion.Name = "DFSradioButtion";
            this.DFSradioButtion.Size = new System.Drawing.Size(43, 16);
            this.DFSradioButtion.TabIndex = 0;
            this.DFSradioButtion.TabStop = true;
            this.DFSradioButtion.Text = "DFS";
            this.DFSradioButtion.UseVisualStyleBackColor = true;
            // 
            // BFSradioButton
            // 
            this.BFSradioButton.AutoSize = true;
            this.BFSradioButton.Location = new System.Drawing.Point(7, 17);
            this.BFSradioButton.Name = "BFSradioButton";
            this.BFSradioButton.Size = new System.Drawing.Size(43, 16);
            this.BFSradioButton.TabIndex = 0;
            this.BFSradioButton.TabStop = true;
            this.BFSradioButton.Text = "BFS";
            this.BFSradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.initRadioButton);
            this.groupBox1.Controls.Add(this.obsticleRadioButton);
            this.groupBox1.Controls.Add(this.endRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(120, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設計";
            // 
            // initRadioButton
            // 
            this.initRadioButton.AutoSize = true;
            this.initRadioButton.ForeColor = System.Drawing.Color.Coral;
            this.initRadioButton.Location = new System.Drawing.Point(6, 39);
            this.initRadioButton.Name = "initRadioButton";
            this.initRadioButton.Size = new System.Drawing.Size(47, 16);
            this.initRadioButton.TabIndex = 0;
            this.initRadioButton.TabStop = true;
            this.initRadioButton.Text = "開始";
            this.initRadioButton.UseVisualStyleBackColor = true;
            // 
            // obsticleRadioButton
            // 
            this.obsticleRadioButton.AutoSize = true;
            this.obsticleRadioButton.Location = new System.Drawing.Point(59, 17);
            this.obsticleRadioButton.Name = "obsticleRadioButton";
            this.obsticleRadioButton.Size = new System.Drawing.Size(47, 16);
            this.obsticleRadioButton.TabIndex = 0;
            this.obsticleRadioButton.TabStop = true;
            this.obsticleRadioButton.Text = "障礙";
            this.obsticleRadioButton.UseVisualStyleBackColor = true;
            // 
            // endRadioButton
            // 
            this.endRadioButton.AutoSize = true;
            this.endRadioButton.Location = new System.Drawing.Point(6, 17);
            this.endRadioButton.Name = "endRadioButton";
            this.endRadioButton.Size = new System.Drawing.Size(47, 16);
            this.endRadioButton.TabIndex = 0;
            this.endRadioButton.TabStop = true;
            this.endRadioButton.Text = "終點";
            this.endRadioButton.UseVisualStyleBackColor = true;
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(11, 82);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(302, 301);
            this.gridPanel.TabIndex = 2;
            // 
            // BFS
            // 
            this.BFS.Tick += new System.EventHandler(this.BFS_Tick);
            // 
            // DFS
            // 
            this.DFS.Tick += new System.EventHandler(this.DFS_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(239, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(74, 63);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "重設";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 395);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.algorithmGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.algorithmGroupBox.ResumeLayout(false);
            this.algorithmGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox algorithmGroupBox;
        private System.Windows.Forms.RadioButton AstarRadioButton;
        private System.Windows.Forms.RadioButton DFSradioButtion;
        private System.Windows.Forms.RadioButton BFSradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton initRadioButton;
        private System.Windows.Forms.RadioButton obsticleRadioButton;
        private System.Windows.Forms.RadioButton endRadioButton;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Timer BFS;
        private System.Windows.Forms.Timer DFS;
        private System.Windows.Forms.Timer Astar;
        private System.Windows.Forms.Button resetButton;
    }
}

