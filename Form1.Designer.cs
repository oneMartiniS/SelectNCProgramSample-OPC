namespace SelectNCProgramSample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdCurrentProgram = new System.Windows.Forms.Button();
            this.cmdCurrentMode = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtCurrentMode = new System.Windows.Forms.TextBox();
            this.txtCurrentProgram = new System.Windows.Forms.TextBox();
            this.cmdChangeMode = new System.Windows.Forms.Button();
            this.txtNewProgram = new System.Windows.Forms.TextBox();
            this.cmdChangeProgram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerShape = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(348, 19);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(131, 23);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "连接OPC服务器";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(348, 94);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(131, 23);
            this.cmdDisconnect.TabIndex = 1;
            this.cmdDisconnect.Text = "断开连接";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            // 
            // cmdCurrentProgram
            // 
            this.cmdCurrentProgram.Location = new System.Drawing.Point(283, 123);
            this.cmdCurrentProgram.Name = "cmdCurrentProgram";
            this.cmdCurrentProgram.Size = new System.Drawing.Size(131, 23);
            this.cmdCurrentProgram.TabIndex = 2;
            this.cmdCurrentProgram.Text = "应用";
            this.cmdCurrentProgram.UseVisualStyleBackColor = true;
            this.cmdCurrentProgram.Click += new System.EventHandler(this.cmdCurrentProgram_Click);
            // 
            // cmdCurrentMode
            // 
            this.cmdCurrentMode.Location = new System.Drawing.Point(283, 36);
            this.cmdCurrentMode.Name = "cmdCurrentMode";
            this.cmdCurrentMode.Size = new System.Drawing.Size(131, 23);
            this.cmdCurrentMode.TabIndex = 3;
            this.cmdCurrentMode.Text = "应用";
            this.cmdCurrentMode.UseVisualStyleBackColor = true;
            this.cmdCurrentMode.Click += new System.EventHandler(this.cmdCurrentMode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(111, 21);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(166, 21);
            this.txtNodeName.TabIndex = 4;
            this.txtNodeName.Text = "127.0.0.1";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(111, 58);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(166, 21);
            this.txtServerName.TabIndex = 5;
            this.txtServerName.Text = "OPC.IwSCP.1";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(111, 96);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(231, 21);
            this.txtClientName.TabIndex = 6;
            this.txtClientName.Text = "OPC_VB Programmanwahl TestClient";
            // 
            // txtCurrentMode
            // 
            this.txtCurrentMode.Location = new System.Drawing.Point(111, 38);
            this.txtCurrentMode.Name = "txtCurrentMode";
            this.txtCurrentMode.Size = new System.Drawing.Size(166, 21);
            this.txtCurrentMode.TabIndex = 7;
            this.txtCurrentMode.Text = "Text1";
            // 
            // txtCurrentProgram
            // 
            this.txtCurrentProgram.Location = new System.Drawing.Point(111, 123);
            this.txtCurrentProgram.Name = "txtCurrentProgram";
            this.txtCurrentProgram.Size = new System.Drawing.Size(166, 21);
            this.txtCurrentProgram.TabIndex = 8;
            this.txtCurrentProgram.Text = "Text1";
            // 
            // cmdChangeMode
            // 
            this.cmdChangeMode.Location = new System.Drawing.Point(111, 80);
            this.cmdChangeMode.Name = "cmdChangeMode";
            this.cmdChangeMode.Size = new System.Drawing.Size(303, 23);
            this.cmdChangeMode.TabIndex = 9;
            this.cmdChangeMode.Text = "更改模式";
            this.cmdChangeMode.UseVisualStyleBackColor = true;
            this.cmdChangeMode.Click += new System.EventHandler(this.cmdChangeMode_Click);
            // 
            // txtNewProgram
            // 
            this.txtNewProgram.Location = new System.Drawing.Point(111, 173);
            this.txtNewProgram.Name = "txtNewProgram";
            this.txtNewProgram.Size = new System.Drawing.Size(166, 21);
            this.txtNewProgram.TabIndex = 11;
            this.txtNewProgram.Text = "/ment/test.png";
            // 
            // cmdChangeProgram
            // 
            this.cmdChangeProgram.Location = new System.Drawing.Point(283, 173);
            this.cmdChangeProgram.Name = "cmdChangeProgram";
            this.cmdChangeProgram.Size = new System.Drawing.Size(131, 23);
            this.cmdChangeProgram.TabIndex = 10;
            this.cmdChangeProgram.Text = "更改程序";
            this.cmdChangeProgram.UseVisualStyleBackColor = true;
            this.cmdChangeProgram.Click += new System.EventHandler(this.cmdChangeProgram_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "OPC 服务器的名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "客户端名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerShape);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNodeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Controls.Add(this.cmdDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 131);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNewProgram);
            this.groupBox2.Controls.Add(this.cmdCurrentMode);
            this.groupBox2.Controls.Add(this.cmdChangeProgram);
            this.groupBox2.Controls.Add(this.cmdCurrentProgram);
            this.groupBox2.Controls.Add(this.cmdChangeMode);
            this.groupBox2.Controls.Add(this.txtCurrentMode);
            this.groupBox2.Controls.Add(this.txtCurrentProgram);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 250);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "当前模式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前程序";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "程序路径";
            // 
            // ServerShape
            // 
            this.ServerShape.AutoSize = true;
            this.ServerShape.BackColor = System.Drawing.Color.Red;
            this.ServerShape.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerShape.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerShape.Location = new System.Drawing.Point(302, 24);
            this.ServerShape.Name = "ServerShape";
            this.ServerShape.Size = new System.Drawing.Size(31, 16);
            this.ServerShape.TabIndex = 15;
            this.ServerShape.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SelectNCProgramSample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.Button cmdCurrentProgram;
        private System.Windows.Forms.Button cmdCurrentMode;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCurrentMode;
        private System.Windows.Forms.TextBox txtCurrentProgram;
        private System.Windows.Forms.Button cmdChangeMode;
        private System.Windows.Forms.TextBox txtNewProgram;
        private System.Windows.Forms.Button cmdChangeProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ServerShape;
    }
}

