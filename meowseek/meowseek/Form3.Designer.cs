namespace meowseek
{
    partial class pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.playerscore = new System.Windows.Forms.Label();
            this.cpuscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Window;
            this.ball.Location = new System.Drawing.Point(434, 238);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 27);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.SystemColors.WindowText;
            this.cpu.Location = new System.Drawing.Point(897, 230);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.WindowText;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // playerscore
            // 
            this.playerscore.AutoSize = true;
            this.playerscore.BackColor = System.Drawing.Color.Transparent;
            this.playerscore.Font = new System.Drawing.Font("ByteBounce", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerscore.Location = new System.Drawing.Point(105, 9);
            this.playerscore.Name = "playerscore";
            this.playerscore.Size = new System.Drawing.Size(37, 20);
            this.playerscore.TabIndex = 3;
            this.playerscore.Text = "00";
            // 
            // cpuscore
            // 
            this.cpuscore.AutoSize = true;
            this.cpuscore.BackColor = System.Drawing.Color.Transparent;
            this.cpuscore.Font = new System.Drawing.Font("ByteBounce", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuscore.Location = new System.Drawing.Point(735, 9);
            this.cpuscore.Name = "cpuscore";
            this.cpuscore.Size = new System.Drawing.Size(37, 20);
            this.cpuscore.TabIndex = 5;
            this.cpuscore.Text = "00";
            // 
            // pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuscore);
            this.Controls.Add(this.playerscore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Name = "pong";
            this.Text = "pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pong_keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label playerscore;
        private System.Windows.Forms.Label cpuscore;
    }
}