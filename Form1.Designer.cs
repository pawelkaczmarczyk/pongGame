namespace pong
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.White;
            this.playground.Controls.Add(this.gameOverLbl);
            this.playground.Controls.Add(this.scoreLabel);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.ball);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(830, 575);
            this.playground.TabIndex = 0;
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOverLbl.Location = new System.Drawing.Point(246, 130);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(413, 288);
            this.gameOverLbl.TabIndex = 4;
            this.gameOverLbl.Text = "Game Over!\r\nF1 - new game\r\nEsc - Exit";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(138, 32);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.LimeGreen;
            this.racket.Location = new System.Drawing.Point(300, 512);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(210, 18);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.OrangeRed;
            this.ball.Location = new System.Drawing.Point(24, 119);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 575);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
    }
}

