namespace GameForm
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picTL = new PictureBox();
            picTM = new PictureBox();
            picTR = new PictureBox();
            picML = new PictureBox();
            picMM = new PictureBox();
            picMR = new PictureBox();
            picBL = new PictureBox();
            picBM = new PictureBox();
            picBR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picML).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBR).BeginInit();
            SuspendLayout();
            // 
            // picTL
            // 
            picTL.BackColor = Color.Transparent;
            picTL.BackgroundImageLayout = ImageLayout.Stretch;
            picTL.Location = new Point(50, 42);
            picTL.Name = "picTL";
            picTL.Size = new Size(191, 157);
            picTL.SizeMode = PictureBoxSizeMode.StretchImage;
            picTL.TabIndex = 0;
            picTL.TabStop = false;
            picTL.Click += picTL_Click;
            // 
            // picTM
            // 
            picTM.BackColor = Color.Transparent;
            picTM.BackgroundImageLayout = ImageLayout.Stretch;
            picTM.Location = new Point(277, 42);
            picTM.Name = "picTM";
            picTM.Size = new Size(185, 157);
            picTM.SizeMode = PictureBoxSizeMode.StretchImage;
            picTM.TabIndex = 1;
            picTM.TabStop = false;
            picTM.Click += picTM_Click;
            // 
            // picTR
            // 
            picTR.BackColor = Color.Transparent;
            picTR.BackgroundImageLayout = ImageLayout.Stretch;
            picTR.Location = new Point(504, 42);
            picTR.Name = "picTR";
            picTR.Size = new Size(182, 157);
            picTR.SizeMode = PictureBoxSizeMode.StretchImage;
            picTR.TabIndex = 2;
            picTR.TabStop = false;
            picTR.Click += picTR_Click;
            // 
            // picML
            // 
            picML.BackColor = Color.Transparent;
            picML.BackgroundImageLayout = ImageLayout.Stretch;
            picML.Location = new Point(50, 227);
            picML.Name = "picML";
            picML.Size = new Size(191, 146);
            picML.SizeMode = PictureBoxSizeMode.StretchImage;
            picML.TabIndex = 3;
            picML.TabStop = false;
            picML.Click += picML_Click;
            // 
            // picMM
            // 
            picMM.BackColor = Color.Transparent;
            picMM.BackgroundImageLayout = ImageLayout.Stretch;
            picMM.Location = new Point(277, 227);
            picMM.Name = "picMM";
            picMM.Size = new Size(185, 146);
            picMM.SizeMode = PictureBoxSizeMode.StretchImage;
            picMM.TabIndex = 4;
            picMM.TabStop = false;
            picMM.Click += picMM_Click;
            // 
            // picMR
            // 
            picMR.BackColor = Color.Transparent;
            picMR.BackgroundImageLayout = ImageLayout.Stretch;
            picMR.Location = new Point(504, 227);
            picMR.Name = "picMR";
            picMR.Size = new Size(182, 146);
            picMR.SizeMode = PictureBoxSizeMode.StretchImage;
            picMR.TabIndex = 5;
            picMR.TabStop = false;
            picMR.Click += picMR_Click;
            // 
            // picBL
            // 
            picBL.BackColor = Color.Transparent;
            picBL.BackgroundImageLayout = ImageLayout.Stretch;
            picBL.Location = new Point(50, 407);
            picBL.Name = "picBL";
            picBL.Size = new Size(191, 147);
            picBL.SizeMode = PictureBoxSizeMode.StretchImage;
            picBL.TabIndex = 6;
            picBL.TabStop = false;
            picBL.Click += picBL_Click;
            // 
            // picBM
            // 
            picBM.BackColor = Color.Transparent;
            picBM.BackgroundImageLayout = ImageLayout.Stretch;
            picBM.Location = new Point(277, 407);
            picBM.Name = "picBM";
            picBM.Size = new Size(185, 147);
            picBM.SizeMode = PictureBoxSizeMode.StretchImage;
            picBM.TabIndex = 7;
            picBM.TabStop = false;
            picBM.Click += picBM_Click;
            // 
            // picBR
            // 
            picBR.BackColor = Color.Transparent;
            picBR.BackgroundImageLayout = ImageLayout.Stretch;
            picBR.Location = new Point(504, 407);
            picBR.Name = "picBR";
            picBR.Size = new Size(182, 147);
            picBR.SizeMode = PictureBoxSizeMode.StretchImage;
            picBR.TabIndex = 8;
            picBR.TabStop = false;
            picBR.Click += picBR_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.board;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 598);
            Controls.Add(picBR);
            Controls.Add(picBM);
            Controls.Add(picBL);
            Controls.Add(picMR);
            Controls.Add(picMM);
            Controls.Add(picML);
            Controls.Add(picTR);
            Controls.Add(picTM);
            Controls.Add(picTL);
            Name = "TicTacToe";
            Text = "Tic Tac Toe Game";
            FormClosing += TicTacToe_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picTL).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTM).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picML).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBL).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBM).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picTL;
        private PictureBox picTM;
        private PictureBox picTR;
        private PictureBox picML;
        private PictureBox picMM;
        private PictureBox picMR;
        private PictureBox picBL;
        private PictureBox picBM;
        private PictureBox picBR;
    }
}
