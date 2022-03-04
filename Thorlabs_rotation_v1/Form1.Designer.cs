
namespace Thorlabs_rotation_v1
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
            this.buttonChannelOneEnable = new System.Windows.Forms.Button();
            this.buttonChannelOneConnect = new System.Windows.Forms.Button();
            this.buttonChannelOneHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.start_job = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.angle_val = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.move_stg = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle_val)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChannelOneEnable
            // 
            this.buttonChannelOneEnable.Location = new System.Drawing.Point(21, 68);
            this.buttonChannelOneEnable.Name = "buttonChannelOneEnable";
            this.buttonChannelOneEnable.Size = new System.Drawing.Size(87, 21);
            this.buttonChannelOneEnable.TabIndex = 10;
            this.buttonChannelOneEnable.Text = "Enable";
            this.buttonChannelOneEnable.UseVisualStyleBackColor = true;
            // 
            // buttonChannelOneConnect
            // 
            this.buttonChannelOneConnect.Location = new System.Drawing.Point(21, 37);
            this.buttonChannelOneConnect.Name = "buttonChannelOneConnect";
            this.buttonChannelOneConnect.Size = new System.Drawing.Size(87, 23);
            this.buttonChannelOneConnect.TabIndex = 8;
            this.buttonChannelOneConnect.Text = "Connect";
            this.buttonChannelOneConnect.UseVisualStyleBackColor = true;
            this.buttonChannelOneConnect.Click += new System.EventHandler(this.buttonChannelOneConnect_Click);
            // 
            // buttonChannelOneHome
            // 
            this.buttonChannelOneHome.Location = new System.Drawing.Point(21, 97);
            this.buttonChannelOneHome.Name = "buttonChannelOneHome";
            this.buttonChannelOneHome.Size = new System.Drawing.Size(87, 21);
            this.buttonChannelOneHome.TabIndex = 9;
            this.buttonChannelOneHome.Text = "Home";
            this.buttonChannelOneHome.UseVisualStyleBackColor = true;
            this.buttonChannelOneHome.Click += new System.EventHandler(this.buttonChannelOneHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 200);
            this.progressBar1.Maximum = 360;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 18;
            // 
            // start_job
            // 
            this.start_job.BackColor = System.Drawing.Color.Red;
            this.start_job.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_job.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_job.Location = new System.Drawing.Point(61, 253);
            this.start_job.Name = "start_job";
            this.start_job.Size = new System.Drawing.Size(120, 48);
            this.start_job.TabIndex = 17;
            this.start_job.Text = "Start Job";
            this.start_job.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.angle_val);
            this.groupBox4.Location = new System.Drawing.Point(147, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 63);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Angle :";
            // 
            // angle_val
            // 
            this.angle_val.Location = new System.Drawing.Point(69, 26);
            this.angle_val.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angle_val.Name = "angle_val";
            this.angle_val.Size = new System.Drawing.Size(61, 21);
            this.angle_val.TabIndex = 14;
            this.angle_val.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChannelOneConnect);
            this.groupBox1.Controls.Add(this.buttonChannelOneHome);
            this.groupBox1.Controls.Add(this.buttonChannelOneEnable);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 138);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stage Control";
            // 
            // move_stg
            // 
            this.move_stg.Location = new System.Drawing.Point(167, 96);
            this.move_stg.Name = "move_stg";
            this.move_stg.Size = new System.Drawing.Size(87, 21);
            this.move_stg.TabIndex = 22;
            this.move_stg.Text = "Move";
            this.move_stg.UseVisualStyleBackColor = true;
            this.move_stg.Click += new System.EventHandler(this.move_stg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.move_stg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.start_job);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angle_val)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChannelOneEnable;
        private System.Windows.Forms.Button buttonChannelOneConnect;
        private System.Windows.Forms.Button buttonChannelOneHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button start_job;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown angle_val;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button move_stg;
    }
}

