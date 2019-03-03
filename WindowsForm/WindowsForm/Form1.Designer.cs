namespace WindowsForm {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.helloListView = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.argument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // helloListView
            // 
            this.helloListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.argument});
            this.helloListView.Location = new System.Drawing.Point(-3, -3);
            this.helloListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helloListView.Name = "helloListView";
            this.helloListView.Size = new System.Drawing.Size(901, 599);
            this.helloListView.TabIndex = 0;
            this.helloListView.UseCompatibleStateImageBehavior = false;
            this.helloListView.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "序号";
            // 
            // argument
            // 
            this.argument.Text = "命令行参数";
            this.argument.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.helloListView);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hello WinForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView helloListView;
        public System.Windows.Forms.ListView hello {
            get {
                return helloListView;
            }
        }
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader argument;
    }
}

