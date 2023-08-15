namespace JsonTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnObject = new DevExpress.XtraEditors.SimpleButton();
            this.grdSample = new DevExpress.XtraGrid.GridControl();
            this.gvSample = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(590, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 42);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnObject
            // 
            this.btnObject.Location = new System.Drawing.Point(409, 16);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(157, 38);
            this.btnObject.TabIndex = 1;
            this.btnObject.Text = "객체의 값을 넣어서 조회";
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // grdSample
            // 
            this.grdSample.Location = new System.Drawing.Point(12, 94);
            this.grdSample.MainView = this.gvSample;
            this.grdSample.Name = "grdSample";
            this.grdSample.Size = new System.Drawing.Size(764, 344);
            this.grdSample.TabIndex = 2;
            this.grdSample.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSample});
            // 
            // gvSample
            // 
            this.gvSample.GridControl = this.grdSample;
            this.gvSample.Name = "gvSample";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(125, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(131, 52);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.grdSample);
            this.Controls.Add(this.btnObject);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnObject;
        private DevExpress.XtraGrid.GridControl grdSample;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSample;
        private System.Windows.Forms.Button btnTest;
    }
}

